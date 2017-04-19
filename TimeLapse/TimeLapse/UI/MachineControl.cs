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
        public string StepUnit { get; set; }
        public int MotionSpeed { get; set; }
        public MachineControl()
        {
            InitializeComponent();
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

            this.labelZAxis.Text = X.ToString("0.0000") + " μm";
            this.labelYAxis.Text = Y.ToString("0.0000") + " μm";
            this.labelXAxis.Text = Z.ToString("0.0000") + " μm";
            this.labelZOffset.Text = XError.ToString("0.0000") + " μm";
            this.labelYOffset.Text = YError.ToString("0.0000") + " μm";
            this.labelXOffset.Text = ZError.ToString("0.0000") + " μm";
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
                    CommandSetMoveSpeedX commandSetMoveSpeedX = CommandFactory.CreateCommand<CommandSetMoveSpeedX>("Set Move Speed X");
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
                    CommandSetMoveSpeedX commandSetMoveSpeedX = CommandFactory.CreateCommand<CommandSetMoveSpeedX>("Set Move Speed X");
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
                    CommandSetMoveSpeedY commandSetMoveSpeedY = CommandFactory.CreateCommand<CommandSetMoveSpeedY>("Set Move Speed Y");
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
                    CommandSetMoveSpeedY commandSetMoveSpeedY = CommandFactory.CreateCommand<CommandSetMoveSpeedY>("Set Move Speed Y");
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
    }
}
