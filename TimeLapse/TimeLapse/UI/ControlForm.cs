using DevComponents.DotNetBar;
using Summer.System.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.Operation;
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.UI
{
    /// <summary>
    /// 相机和运动平台调试窗口
    /// 提供相机和运动平台基本控制指令的发送
    /// </summary>
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文
    /// 时间：2017-4-10 
    /// </remarks>
    public partial class ControlForm : Office2007RibbonForm
    {
        private MachineSettingForm machineSettingForm;

        private About aboutForm;

        public CommandFactory CommandFactory { get; set; }

        public delegate void UpdateMotionPosition(float x, float xError, float y, float yError, float z, float zError);
        public delegate void UpdateMotionCtrls(bool isInitialized);

        public ControlForm()
        {
            InitializeComponent();
            this.KeyDown += ControlForm_KeyDown;
            this.Load += ControlForm_Load;
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            CommandCameraPosition commandCameraPosition = CommandFactory.CreateCommand<CommandCameraPosition>("Camera Position");
            commandCameraPosition.UpdateMotionPositionHandler += UpdateMotionPositionHandler;

            CommandMoveStart commandMoveStart = CommandFactory.CreateCommand<CommandMoveStart>("Move Start");
            commandMoveStart.UpdateMotionCtrlsHandler += UpdateMotionCtrlsHandler;

            CommandMoveExit commandMoveExit = CommandFactory.CreateCommand<CommandMoveExit>("Move Exit");
            commandMoveExit.UpdateMotionCtrlsHandler += UpdateMotionCtrlsHandler;
        }

        public void UpdateMotionCtrlsHandler(bool isOpen)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateMotionCtrlsHandler(isOpen)));
            }
            else
            {
                if (machineSettingForm != null)
                {
                    this.machineSettingForm.UpdateMobilityStatus(isOpen);
                }
                this.machineControl.UpdateMotionCtrls(isOpen);
            }
        }

        public void UpdateMotionPositionHandler(float x, float xError, float y, float yError, float z, float zError)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateMotionPositionHandler(x, xError, y, yError, z, zError)));
            }
            else
            {
                this.machineControl.UpdateMotionPosition(x, xError, y, yError, z, zError);
            }

        }

        private void ControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F7)
            {
                viewLog(new string[] { "novoCyte.log"/*, "Simulator.send"*/ });
            }
        }

        private void viewLog(string[] logname)
        {
            string logView = string.Format("{0}\\Resources\\LogView.exe", System.Environment.CurrentDirectory);
            string logFile = "";
            foreach (var log in logname)
            {
                logFile += string.Format("\"{0}\\log\\{1}\" ", System.Environment.CurrentDirectory, log);
            }
            try
            {
                System.Diagnostics.Process.Start("\"" + logView + "\"", logFile);
            }
            catch (Exception)
            {
            }
        }

        private void Exit()
        {
            try
            {
                Quartz.Impl.StdScheduler scheduler = (Quartz.Impl.StdScheduler)SpringHelper.GetContext().GetObject("scheduler");
                scheduler.Shutdown();
            }
            catch (Exception ee)
            {
            }
        }

        private void buttonItemStart_Click(object sender, EventArgs e)
        {
            CommandCameraStart command = CommandFactory.CreateCommand<CommandCameraStart>("Start Camera");
            command.IntPtr = this.pictureBox.Handle;
            CommandFactory.CommandQueue.Push(command);
        }

        private void buttonItemPause_Click(object sender, EventArgs e)
        {
            CommandCameraPause command = CommandFactory.CreateCommand<CommandCameraPause>("Pause Camera");
            CommandFactory.CommandQueue.Push(command);
        }

        private void buttonItemStop_Click(object sender, EventArgs e)
        {
            CommandCameraClose command = CommandFactory.CreateCommand<CommandCameraClose>("Close Camera");
            CommandFactory.CommandQueue.Push(command);
        }

        private void buttonItemSnapShot_Click(object sender, EventArgs e)
        {
            CommandCameraCapture command = CommandFactory.CreateCommand<CommandCameraCapture>("Camera Capture");
            CommandFactory.CommandQueue.Push(command);
        }

        private void buttonItemAutoFocus_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemMachine_Click(object sender, EventArgs e)
        {
            machineSettingForm = SpringHelper.GetObject<MachineSettingForm>("machineSettingForm");
            if (machineSettingForm.ShowDialog() == DialogResult.OK )
            {
                this.machineControl.MotionStep = machineSettingForm.MotionStep;
                this.machineControl.MotionSpeed = machineSettingForm.MotionSpeed;
                this.machineControl.StepUnit = machineSettingForm.StepUnit;
                this.machineControl.IsFixedLength = machineControl.IsFixedLength;

                CommandSetMoveResolution command = CommandFactory.CreateCommand<CommandSetMoveResolution>("Set Move Resolution");
                command.Resolution = CalculateResolution(this.machineControl.StepUnit);
                CommandFactory.CommandQueue.Push(command);
            }
            machineSettingForm.Dispose();
        }

        private int CalculateResolution(string stepUnit)
        {
            int resolution = 20000;
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

        private void buttonItemAbout_Click(object sender, EventArgs e)
        {
            aboutForm = SpringHelper.GetObject<About>("aboutForm");
            aboutForm.ShowDialog();
            aboutForm.Dispose();
        }
    }
}
