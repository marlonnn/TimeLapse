using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.Operation;
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.UI
{
    /// <summary>
    /// 移动平台基本操作控件
    /// </summary>
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文               
    /// 创建日期：2017-4-8   
    /// </remarks>
    public partial class MachineControl : UserControl
    {
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
        public int MotionSpeed { get; set; }

        public string IpAddress { get; set; }

        public MachineControl()
        {
            InitializeComponent();
            this.Load += MachineControl_Load;
        }

        private void MachineControl_Load(object sender, EventArgs e)
        {
            this.cbxMotionMode.SelectedIndex = 0;
            this.cbxStepUnit.SelectedIndex = 2;

            this.stepUnit = this.cbxStepUnit.SelectedItem.ToString();
            this.MotionStep = this.inputStep.Value;
            this.MotionSpeed = this.inputStep.Value;
            this.IpAddress = this.ipAddressInput.Value;
        }

        public void UpdateMobilityStatus(bool isOpen)
        {
            this.labelStatus.Text = isOpen ? "ON" : "OFF";
            this.labelStatus.ForeColor = isOpen ? Color.DarkGreen : Color.Red;
            this.btnStart.Enabled = !isOpen;
            this.btnReset.Enabled = isOpen;
            this.btnClose.Enabled = isOpen;
        }

        public void UpdateMotionCtrls(bool isOpen)
        {
            this.btnXLeft.Enabled = isOpen;
            this.btnXRight.Enabled = isOpen;
            this.btnYLeft.Enabled = isOpen;
            this.btnYRight.Enabled = isOpen;
            this.btnZLeft.Enabled = isOpen;
            this.btnZRight.Enabled = isOpen;
        }
        public void UpdateMotionPosition(float x, float xError, float y, float yError, float z, float zError)
        {
            //单位换算50nm(最小单位) => μm
            double X = x / 20, XError = xError / 20;
            double Y = y / 20, YError = yError / 20;
            double Z = z / 20, ZError = zError / 20;

            //this.labelZAxis.Text = X.ToString("0.0000") + " μm";
            //this.labelYAxis.Text = Y.ToString("0.0000") + " μm";
            //this.labelXAxis.Text = Z.ToString("0.0000") + " μm";
            //this.labelZOffset.Text = XError.ToString("0.0000") + " μm";
            //this.labelYOffset.Text = YError.ToString("0.0000") + " μm";
            //this.labelXOffset.Text = ZError.ToString("0.0000") + " μm";
        }

        private bool IsLengthLegal(int length)
        {
            if (length != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Should set a value!");
                return false;
            }
        }

        private void btnXLeft_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveX commandMoveX = CommandFactory.CreateCommand<CommandMoveX>("Move X");
                    commandMoveX.MoveLength = -MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveX);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandStartMoveXWithSpeed commandSetMoveSpeedX = CommandFactory.CreateCommand<CommandStartMoveXWithSpeed>("Start Move X With Speed");
                    commandSetMoveSpeedX.Speed = -MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedX);
                }
            }
        }

        private void btnXRight_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveX commandMoveX = CommandFactory.CreateCommand<CommandMoveX>("Move X");
                    commandMoveX.MoveLength = MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveX);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandStartMoveXWithSpeed commandSetMoveSpeedX = CommandFactory.CreateCommand<CommandStartMoveXWithSpeed>("Start Move X With Speed");
                    commandSetMoveSpeedX.Speed = MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedX);
                }
            }
        }

        private void btnYLeft_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveY commandMoveY = CommandFactory.CreateCommand<CommandMoveY>("Move Y");
                    commandMoveY.MoveLength = -MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveY);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandStartMoveYWithSpeed commandSetMoveSpeedY = CommandFactory.CreateCommand<CommandStartMoveYWithSpeed>("Start Move Y With Speed");
                    commandSetMoveSpeedY.Speed = -MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedY);
                }
            }
        }

        private void btnYRight_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveY commandMoveY = CommandFactory.CreateCommand<CommandMoveY>("Move Y");
                    commandMoveY.MoveLength = MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveY);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandStartMoveYWithSpeed commandSetMoveSpeedY = CommandFactory.CreateCommand<CommandStartMoveYWithSpeed>("Start Move Y With Speed");
                    commandSetMoveSpeedY.Speed = MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedY);
                }
            }
        }

        private void btnZLeft_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveZ commandMoveZ = CommandFactory.CreateCommand<CommandMoveZ>("Move Z");
                    commandMoveZ.MoveLength = -MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveZ);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandSetMoveSpeedZ commandSetMoveSpeedZ = CommandFactory.CreateCommand<CommandSetMoveSpeedZ>("Set Move Speed Z");
                    commandSetMoveSpeedZ.Speed = -MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedZ);
                }
            }
        }

        private void btnZRight_Click(object sender, EventArgs e)
        {
            if (IsFixedLength)
            {
                if (IsLengthLegal(this.MotionStep))
                {
                    CommandMoveZ commandMoveZ = CommandFactory.CreateCommand<CommandMoveZ>("Move Z");
                    commandMoveZ.MoveLength = MotionStep;
                    CommandFactory.CommandQueue.Push(commandMoveZ);
                }
            }
            else
            {
                if (IsLengthLegal(MotionSpeed))
                {
                    CommandSetMoveSpeedZ commandSetMoveSpeedZ = CommandFactory.CreateCommand<CommandSetMoveSpeedZ>("Set Move Speed Z");
                    commandSetMoveSpeedZ.Speed = MotionSpeed;
                    CommandFactory.CommandQueue.Push(commandSetMoveSpeedZ);
                }
            }
        }

        private void btnAbsulate_Click(object sender, EventArgs e)
        {
            CommandMoveAbsolute commandMoveAbsolute = CommandFactory.CreateCommand<CommandMoveAbsolute>("Move Absolute");
            commandMoveAbsolute.X = this.inputAbsoluteX.Value;
            commandMoveAbsolute.Y = this.inputAbsoluteY.Value;
            commandMoveAbsolute.Z = this.inputAbsoluteZ.Value;
            CommandFactory.CommandQueue.Push(commandMoveAbsolute);
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

        private void MotionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IsFixedLength = this.cbxMotionMode.SelectedItem.ToString() == "Fixed Length" ? true : false;
        }

        private void MotionStep_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StepUnit = this.cbxStepUnit.SelectedItem.ToString();
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

        private void Step_ValueChanged(object sender, EventArgs e)
        {
            this.MotionStep = this.inputStep.Value;
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            this.MotionSpeed = this.inputSpeed.Value;
        }
    }
}
