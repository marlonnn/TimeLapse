using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeLapse.Operation.MobilityCommand;
using TimeLapse.SystemDevice;
using TimeLapse.SystemFunction;

namespace TimeLapse.Operation
{
    public class MobilityThread
    {
        //命令工厂
        public CommandFactory CommandFactory { get; set; }

        public bool ExecuteMobility { get; set; }

        public Device Device { get; set; }

        private BackgroundWorker backgroundWorker = null;
        private ManualResetEvent busy { get; set; }

        public MobilityThread()
        {
            ExecuteMobility = false;
            busy = new ManualResetEvent(false);
            InitializeWorker();
        }

        private void InitializeWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
        }

        public void StartWorker()
        {
            if (!backgroundWorker.IsBusy)
            {
                ExecuteMobility = true;
                backgroundWorker.RunWorkerAsync();
                busy.Set();
            }
        }

        public void PauseWorker()
        {
            busy.Reset();
        }

        public void ResumeWorker()
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
            busy.Set();
        }

        public void CancelWorker()
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                busy.Set();
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Device != null)
            {
                List<Slide> slides = Device.Slides;
                if (slides != null && slides.Count > 0)
                {
                    while (ExecuteMobility)
                    {
                        for (int i = 0; i < slides.Count; i++)
                        {
                            busy.WaitOne();
                            Thread.Sleep(10);
                            if (backgroundWorker.CancellationPending)
                            {
                                return;
                            }
                            Slide slide = slides[i];
                            string dir = string.Format("{0}\\Images\\{1}", System.Environment.CurrentDirectory, slide.Name);
                            IOUtil.CheckDirectory(dir);
                            List<Cell> cells = slide.Cells;
                            for (int j = 0; j < cells.Count; j++)
                            {
                                //1.移动到培养皿对应坐标位置
                                CommandMoveAbsolute(cells[j].Position);
                                if (j == 0)
                                {
                                    //2.移动到每个培养皿的第一个细胞位置，自动对焦一次
                                    //TO DO 自动对焦
                                }
                                //3.循环拍照
                                //照片名称，照片存放路径
                                string subDir = string.Format("{0}\\Images\\{1}\\{2}", System.Environment.CurrentDirectory,
                                    slide.Name, cells[j].Name);
                                IOUtil.CheckDirectory(dir);
                                for (int z = 0; z < cells[j].FocalCount; z++)
                                {
                                    string focalDir = string.Format("{0}\\Focal{1}", subDir, z);
                                    IOUtil.CheckDirectory(focalDir);
                                    //slideName_cellName_time_focalID
                                    string imageName = string.Format("{0}_{1}_{2}", slide.Name, cells[j].Name,
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms"), z);
                                    CommandCameraCapture(imageName, focalDir);
                                }

                                //4.存数据库
                            }
                        }
                    }
                }
            }
        }

        public void Start()
        {
            ExecuteMobility = true;
        }

        public void Stop()
        {
            ExecuteMobility = false;
        }

        public void Execute()
        {
            if (Device != null)
            {
                List<Slide> slides = Device.Slides;
                if (slides != null && slides.Count > 0)
                {
                    while (ExecuteMobility)
                    {
                        for (int i=0; i<slides.Count; i++)
                        {
                            busy.WaitOne();


                            Slide slide = slides[i];
                            string dir = string.Format("{0}\\Images\\{1}", System.Environment.CurrentDirectory, slide.Name);
                            IOUtil.CheckDirectory(dir);
                            List<Cell> cells = slide.Cells;
                            for (int j=0; j<cells.Count; j++)
                            {
                                //1.移动到培养皿对应坐标位置
                                CommandMoveAbsolute(cells[j].Position);
                                //if (j == 0)
                                //{
                                //    //2.移动到每个培养皿的第一个细胞位置，自动对焦一次
                                //    //TO DO 自动对焦
                                //}
                                //3.循环拍照
                                //照片名称，照片存放路径
                                string subDir = string.Format("{0}\\Images\\{1}\\{2}", System.Environment.CurrentDirectory, 
                                    slide.Name, cells[j].Name);
                                IOUtil.CheckDirectory(dir);
                                for (int z=0; z<cells[j].FocalCount; z++)
                                {
                                    string focalDir = string.Format("{0}\\Focal{1}", subDir, z);
                                    IOUtil.CheckDirectory(focalDir);
                                    //slideName_cellName_time_focalID
                                    string imageName = string.Format("{0}_{1}_{2}.jpeg", slide.Name, cells[j].Name, 
                                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms"), z);
                                    CommandCameraCapture(imageName, focalDir);
                                }

                                //4.存数据库
                            }
                        }
                    }
                }
            }
        }

        public void ExecuteInternal()
        {
            while (true)
            {
                try
                {
                    if (MobilityUtil.MobilityInitialized)
                    {
                        CommandCameraPosition commandCameraPosition = CommandFactory.CreateCommand<CommandCameraPosition>("Camera Position");
                        commandCameraPosition.Execute();
                    }
                }
                catch (Exception)
                {
                    LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", "Camera Position"));
                }
                Thread.Sleep(1000);
            }
        }

        private bool CommandMoveAbsolute(Position position)
        {
            CommandMoveAbsolute commandMoveAbsolute = CommandFactory.CreateCommand<CommandMoveAbsolute>("Move Absolute");
            commandMoveAbsolute.X = position.X;
            commandMoveAbsolute.Y = position.Y;
            commandMoveAbsolute.Z = position.Z;
            return commandMoveAbsolute.Execute();
        }

        private bool CommandCameraCapture(string name, string path)
        {
            CommandCameraCapture commandCameraCapture = CommandFactory.CreateCommand<CommandCameraCapture>("Camera Capture");
            commandCameraCapture.PictureName = name;
            commandCameraCapture.PicturePath = path;
            return commandCameraCapture.Execute();
        }
    }
}
