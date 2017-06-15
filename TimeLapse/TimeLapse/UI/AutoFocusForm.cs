using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.Images;
using TimeLapse.Operation;
using TimeLapse.Operation.MobilityCommand;
using TimeLapse.SystemFunction;

namespace TimeLapse.UI
{
    public partial class AutoFocusForm : Form
    {
        private List<Frame> frames;
        private List<SharpnessImage> sharpnessImages;
        public CommandFactory CommandFactory { get; set; }
        public bool IsFixedLength { get; set; }
        public int MotionStep { get; set; }

        private string stepUnit = "50nm";

        public string StepUnit
        {
            get { return this.stepUnit; }
            set
            {
                if (value != this.stepUnit)
                {
                    this.stepUnit = value;
                    CommandSetMoveResolution command = CommandFactory.CreateCommand<CommandSetMoveResolution>("Set Move Resolution");
                    command.Resolution = CalculateResolution(this.StepUnit);
                    CommandFactory.CommandQueue.Push(command);
                }
            }
        }

        private int CalculateResolution(string stepUnit)
        {
            int resolution = 1;
            switch (stepUnit)
            {
                case "mm":
                    resolution = 20000;
                    break;
                case "um":
                    resolution = 20;
                    break;
                case "50nm":
                    resolution = 1;
                    break;
            }
            return resolution;
        }

        public int MotionSpeed { get; set; }

        public string IpAddress { get; set; }

        public AutoFocusForm()
        {
            InitializeComponent();
            frames = new List<Frame>();
            sharpnessImages = new List<SharpnessImage>();
            this.Load += AutoFocusForm_Load;
            this.cbxStepUnit.SelectedIndexChanged += MotionStep_SelectedIndexChanged;
            this.inputStep.ValueChanged += Step_ValueChanged;
            this.inputSpeed.ValueChanged += Speed_ValueChanged;
        }

        private void AutoFocusForm_Load(object sender, EventArgs e)
        {
            this.cbxMotionMode.SelectedIndex = 0;
            this.cbxStepUnit.SelectedIndex = 2;

            this.stepUnit = this.cbxStepUnit.SelectedItem.ToString();
            this.MotionStep = this.inputStep.Value;
            this.MotionSpeed = this.inputStep.Value;
            this.IpAddress = this.ipAddressInput.Value;
        }

        private void MotionStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StepUnit = this.cbxStepUnit.SelectedItem.ToString();
        }

        private void Step_ValueChanged(object sender, EventArgs e)
        {
            this.MotionStep = this.inputStep.Value;
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            this.MotionSpeed = this.inputSpeed.Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CommandMoveHome command = CommandFactory.CreateCommand<CommandMoveHome>("Move Home");
            CommandFactory.CommandQueue.Push(command);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommandMoveExit command = CommandFactory.CreateCommand<CommandMoveExit>("Move Exit");
            CommandFactory.CommandQueue.Push(command);
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            CommandMoveStart command = CommandFactory.CreateCommand<CommandMoveStart>("Move Start");
            command.IpAddress = this.ipAddressInput.Value;
            CommandFactory.CommandQueue.Push(command);
        }

        private void btnStartFocus_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            frames.Clear();
            sharpnessImages.Clear();
            //开始自动对焦
            //1.先移动到初始化位置
            MoveAbsolutePosition(0, 0, 0);
            //2.连续拍50张照片,50张？
            string dir = string.Format("{0}\\Images\\Focus", System.Environment.CurrentDirectory);
            IOUtil.CheckDirectory(dir);
            for (int i = 0; i < 50; i++)
            {
                string imageName = string.Format("{0}.jpeg", i);
                CommandCameraCapture(imageName, dir);
                Frame frame = new Frame(string.Format("{0}\\{1}", dir, imageName), dir);
                frames.Add(frame);
                MoveZAxis();
            }
            //3.从50张照片中筛选出最清晰的照片
            for (int i = 0; i < frames.Count; i ++)
            {
                double sharpnessValue = SharpnessAlgorithm.Test(frames[i].FileFullName);
                var sharpnessImage = new SharpnessImage(frames[i].FileFullName, sharpnessValue);
                sharpnessImages.Add(sharpnessImage);
            }
            var maxValue = sharpnessImages.Select(sharpnessImage => sharpnessImage.SharpnessValue).Max();
            SharpnessImage finaleIamge = sharpnessImages.Find(sharpnessImage => sharpnessImage.SharpnessValue == maxValue);
            var timelapse = stopWatch.ElapsedMilliseconds.ToString();//一共执行毫秒
        }

        private void MoveZAxis()
        {
            CommandMoveZ commandMoveZ = CommandFactory.CreateCommand<CommandMoveZ>("Move Z");
            commandMoveZ.MoveLength = 1;
            commandMoveZ.Execute();
        }

        private void MoveAbsolutePosition(int x, int y, int z)
        {
            CommandMoveAbsolute commandMoveAbsolute = CommandFactory.CreateCommand<CommandMoveAbsolute>("Move Absolute");
            commandMoveAbsolute.X = x;
            commandMoveAbsolute.Y = y;
            commandMoveAbsolute.Z = z;
            CommandFactory.CommandQueue.Push(commandMoveAbsolute);
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
