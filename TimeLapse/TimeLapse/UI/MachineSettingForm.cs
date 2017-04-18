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
    public partial class MachineSettingForm : ChildForm
    {
        public string IpAddress { get; set; }

        public int MotionStep { get; set; }

        public string StepUnit { get; set; }

        public int MotionSpeed { get; set; }

        public bool IsFixedLength { get; set; }

        private CommandQueue CommandQueue;

        public Dictionary<string, Operation.Command> CommandFactory { get; set; }

        public MachineSettingForm()
        {
            InitializeComponent();
            this.Load += MachineSettingForm_Load;
        }

        private void MachineSettingForm_Load(object sender, EventArgs e)
        {
            this.cbxMotionMode.SelectedIndex = 0;
            this.cbxStepUnit.SelectedIndex = 2;
        }

        public void UpdateMobilityStatus(bool isOpen)
        {
            this.labelStatus.Text = isOpen ? "ON" : "OFF";
            this.btnStart.Enabled = !isOpen;
            this.btnReset.Enabled = isOpen;
            this.btnClose.Enabled = isOpen;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CommandMoveStart command = (CommandMoveStart)CommandFactory["Move Start"];
            command.CommandName = "Move Start";
            command.IpAddress = this.ipAddressInput.Value;
            CommandQueue.Push(command);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CommandMoveHome command = (CommandMoveHome)CommandFactory["Move Home"];
            command.CommandName = "Move Home";
            CommandQueue.Push(command);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommandMoveExit command = (CommandMoveExit)CommandFactory["Move Exit"];
            command.CommandName = "Move Exit";
            CommandQueue.Push(command);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.IpAddress = this.ipAddressInput.Value;
            this.MotionStep = this.inputStep.Value;
            this.MotionSpeed = this.inputSpeed.Value;
            this.StepUnit = this.cbxStepUnit.SelectedItem.ToString();
            this.IsFixedLength = this.cbxMotionMode.SelectedItem.ToString() == "Fixed Length" ? true : false;
            this.DialogResult = DialogResult.OK;
        }
    }
}
