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
    public partial class ControlForm : Office2007RibbonForm
    {
        private MachineSettingForm machineSettingForm;

        private CommandQueue CommandQueue;

        public Dictionary<string, Operation.Command> CommandFactory { get; set; }

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
            CommandCameraPosition commandCameraPosition = (CommandCameraPosition)CommandFactory["Camera Position"];
            commandCameraPosition.UpdateMotionPositionHandler += UpdateMotionPositionHandler;

            CommandMoveStart commandMoveStart = (CommandMoveStart)CommandFactory["Move Start"];
            commandMoveStart.UpdateMotionCtrlsHandler += UpdateMotionCtrlsHandler;

            CommandMoveExit commandMoveExit = (CommandMoveExit)CommandFactory["Move Exit"];
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
            CommandCameraStart command = (CommandCameraStart)CommandFactory["Start Camera"];
            command.CommandName = "Start Camera";
            command.IntPtr = this.pictureBox.Handle;
            CommandQueue.Push(command);
        }

        private void buttonItemPause_Click(object sender, EventArgs e)
        {
            CommandCameraPause command = (CommandCameraPause)CommandFactory["Pause Camera"];
            command.CommandName = "Pause Camera";
            CommandQueue.Push(command);
        }

        private void buttonItemStop_Click(object sender, EventArgs e)
        {
            CommandCameraClose command = (CommandCameraClose)CommandFactory["Close Camera"];
            command.CommandName = "Close Camera";
            CommandQueue.Push(command);
        }

        private void buttonItemSnapShot_Click(object sender, EventArgs e)
        {

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

                CommandSetMoveResolution command = (CommandSetMoveResolution)CommandFactory["Set Move Resolution"];
                command.CommandName = "Set Move Resolution";
                command.Resolution = CalculateResolution(this.machineControl.StepUnit);
                CommandQueue.Push(command);
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

        }
    }
}
