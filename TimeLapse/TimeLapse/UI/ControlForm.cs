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
        private CommandQueue CommandQueue;

        public Dictionary<string, Operation.Command> CommandFactory { get; set; }
        public ControlForm()
        {
            InitializeComponent();
            this.KeyDown += ControlForm_KeyDown;
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
    }
}
