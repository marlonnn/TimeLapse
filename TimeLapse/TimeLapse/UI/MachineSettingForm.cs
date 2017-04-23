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
    /// 运动平台设置窗口
    /// 提供IP地址、运动步长、运动速度、运动模式的设置
    /// </summary>
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文
    /// 时间：2017-4-10
    /// </remarks>
    public partial class MachineSettingForm : ChildForm
    {
        public string IpAddress { get; set; }

        public int MotionStep { get; set; }

        public string StepUnit { get; set; }

        public int MotionSpeed { get; set; }

        public bool IsFixedLength { get; set; }

        public CommandFactory CommandFactory { get; set; }

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
            CommandMoveStart command = CommandFactory.CreateCommand<CommandMoveStart>("Move Start");
            command.IpAddress = this.ipAddressInput.Value;
            CommandFactory.CommandQueue.Push(command);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.IpAddress = this.ipAddressInput.Value;
            this.MotionStep = this.inputStep.Value;
            this.MotionSpeed = this.inputSpeed.Value;
            this.StepUnit = this.cbxStepUnit.SelectedItem.ToString();
            this.IsFixedLength = this.cbxMotionMode.SelectedItem.ToString() == "Fixed Length" ? true : false;
            this.DialogResult = DialogResult.OK;
        }

        private void ipAddressInput_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void inputStep_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
