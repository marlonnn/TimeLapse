namespace TimeLapse.UI
{
    partial class MachineControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new DevComponents.DotNetBar.PanelEx();
            this.btnZRight = new DevComponents.DotNetBar.ButtonX();
            this.btnZLeft = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYRight = new DevComponents.DotNetBar.ButtonX();
            this.btnYLeft = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXRight = new DevComponents.DotNetBar.ButtonX();
            this.btnXLeft = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.expandablePanel1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAbsulate = new DevComponents.DotNetBar.ButtonX();
            this.inputAbsoluteZ = new DevComponents.Editors.IntegerInput();
            this.inputAbsoluteY = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expandablePanel2 = new DevComponents.DotNetBar.PanelEx();
            this.labelZOffset = new DevComponents.DotNetBar.LabelX();
            this.labelYOffset = new DevComponents.DotNetBar.LabelX();
            this.labelXOffset = new DevComponents.DotNetBar.LabelX();
            this.labelZAxis = new DevComponents.DotNetBar.LabelX();
            this.labelYAxis = new DevComponents.DotNetBar.LabelX();
            this.labelXAxis = new DevComponents.DotNetBar.LabelX();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inputAbsoluteX = new DevComponents.Editors.IntegerInput();
            this.panel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteY)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.CanvasColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnZRight);
            this.panel1.Controls.Add(this.btnZLeft);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnYRight);
            this.panel1.Controls.Add(this.btnYLeft);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXRight);
            this.panel1.Controls.Add(this.btnXLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 158);
            this.panel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panel1.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.panel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panel1.TabIndex = 33;
            // 
            // btnZRight
            // 
            this.btnZRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnZRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnZRight.Enabled = false;
            this.btnZRight.Location = new System.Drawing.Point(162, 108);
            this.btnZRight.Name = "btnZRight";
            this.btnZRight.Size = new System.Drawing.Size(75, 23);
            this.btnZRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnZRight.TabIndex = 6;
            this.btnZRight.Text = "&Right";
            this.btnZRight.Click += new System.EventHandler(this.btnZRight_Click);
            // 
            // btnZLeft
            // 
            this.btnZLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnZLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnZLeft.Enabled = false;
            this.btnZLeft.Location = new System.Drawing.Point(59, 108);
            this.btnZLeft.Name = "btnZLeft";
            this.btnZLeft.Size = new System.Drawing.Size(75, 23);
            this.btnZLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnZLeft.TabIndex = 5;
            this.btnZLeft.Text = "&Left";
            this.btnZLeft.Click += new System.EventHandler(this.btnZLeft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Z Axis:";
            // 
            // btnYRight
            // 
            this.btnYRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYRight.Enabled = false;
            this.btnYRight.Location = new System.Drawing.Point(162, 67);
            this.btnYRight.Name = "btnYRight";
            this.btnYRight.Size = new System.Drawing.Size(75, 23);
            this.btnYRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYRight.TabIndex = 4;
            this.btnYRight.Text = "&Right";
            this.btnYRight.Click += new System.EventHandler(this.btnYRight_Click);
            // 
            // btnYLeft
            // 
            this.btnYLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYLeft.Enabled = false;
            this.btnYLeft.Location = new System.Drawing.Point(59, 67);
            this.btnYLeft.Name = "btnYLeft";
            this.btnYLeft.Size = new System.Drawing.Size(75, 23);
            this.btnYLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYLeft.TabIndex = 3;
            this.btnYLeft.Text = "&Left";
            this.btnYLeft.Click += new System.EventHandler(this.btnYLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Y Axis:";
            // 
            // btnXRight
            // 
            this.btnXRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXRight.Enabled = false;
            this.btnXRight.Location = new System.Drawing.Point(162, 25);
            this.btnXRight.Name = "btnXRight";
            this.btnXRight.Size = new System.Drawing.Size(75, 23);
            this.btnXRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXRight.TabIndex = 2;
            this.btnXRight.Text = "&Right";
            this.btnXRight.Click += new System.EventHandler(this.btnXRight_Click);
            // 
            // btnXLeft
            // 
            this.btnXLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXLeft.Enabled = false;
            this.btnXLeft.Location = new System.Drawing.Point(59, 25);
            this.btnXLeft.Name = "btnXLeft";
            this.btnXLeft.Size = new System.Drawing.Size(75, 23);
            this.btnXLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXLeft.TabIndex = 1;
            this.btnXLeft.Text = "&Left";
            this.btnXLeft.Click += new System.EventHandler(this.btnXLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "X Axis:";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.Color.Transparent;
            this.expandablePanel1.Controls.Add(this.inputAbsoluteX);
            this.expandablePanel1.Controls.Add(this.btnAbsulate);
            this.expandablePanel1.Controls.Add(this.inputAbsoluteZ);
            this.expandablePanel1.Controls.Add(this.inputAbsoluteY);
            this.expandablePanel1.Controls.Add(this.label3);
            this.expandablePanel1.Controls.Add(this.label4);
            this.expandablePanel1.Controls.Add(this.label6);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel1.Location = new System.Drawing.Point(0, 158);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(280, 155);
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel1.TabIndex = 34;
            // 
            // btnAbsulate
            // 
            this.btnAbsulate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAbsulate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAbsulate.Enabled = false;
            this.btnAbsulate.Location = new System.Drawing.Point(162, 66);
            this.btnAbsulate.Name = "btnAbsulate";
            this.btnAbsulate.Size = new System.Drawing.Size(75, 23);
            this.btnAbsulate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAbsulate.TabIndex = 10;
            this.btnAbsulate.Text = "&Absulate";
            this.btnAbsulate.Click += new System.EventHandler(this.btnAbsulate_Click);
            // 
            // inputAbsoluteZ
            // 
            // 
            // 
            // 
            this.inputAbsoluteZ.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputAbsoluteZ.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputAbsoluteZ.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputAbsoluteZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputAbsoluteZ.Location = new System.Drawing.Point(59, 111);
            this.inputAbsoluteZ.Name = "inputAbsoluteZ";
            this.inputAbsoluteZ.ShowUpDown = true;
            this.inputAbsoluteZ.Size = new System.Drawing.Size(75, 23);
            this.inputAbsoluteZ.TabIndex = 9;
            this.inputAbsoluteZ.Value = 1;
            // 
            // inputAbsoluteY
            // 
            // 
            // 
            // 
            this.inputAbsoluteY.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputAbsoluteY.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputAbsoluteY.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputAbsoluteY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputAbsoluteY.Location = new System.Drawing.Point(59, 71);
            this.inputAbsoluteY.Name = "inputAbsoluteY";
            this.inputAbsoluteY.ShowUpDown = true;
            this.inputAbsoluteY.Size = new System.Drawing.Size(75, 23);
            this.inputAbsoluteY.TabIndex = 8;
            this.inputAbsoluteY.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Z Axis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Y Axis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "X Axis:";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.Color.Transparent;
            this.expandablePanel2.Controls.Add(this.labelZOffset);
            this.expandablePanel2.Controls.Add(this.labelYOffset);
            this.expandablePanel2.Controls.Add(this.labelXOffset);
            this.expandablePanel2.Controls.Add(this.labelZAxis);
            this.expandablePanel2.Controls.Add(this.labelYAxis);
            this.expandablePanel2.Controls.Add(this.labelXAxis);
            this.expandablePanel2.Controls.Add(this.label12);
            this.expandablePanel2.Controls.Add(this.label11);
            this.expandablePanel2.Controls.Add(this.label10);
            this.expandablePanel2.Controls.Add(this.label7);
            this.expandablePanel2.Controls.Add(this.label8);
            this.expandablePanel2.Controls.Add(this.label9);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 313);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(280, 155);
            this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.expandablePanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel2.TabIndex = 35;
            // 
            // labelZOffset
            // 
            // 
            // 
            // 
            this.labelZOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelZOffset.Location = new System.Drawing.Point(195, 112);
            this.labelZOffset.Name = "labelZOffset";
            this.labelZOffset.Size = new System.Drawing.Size(75, 23);
            this.labelZOffset.TabIndex = 47;
            this.labelZOffset.Text = "0.0000um";
            // 
            // labelYOffset
            // 
            // 
            // 
            // 
            this.labelYOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelYOffset.Location = new System.Drawing.Point(195, 71);
            this.labelYOffset.Name = "labelYOffset";
            this.labelYOffset.Size = new System.Drawing.Size(75, 23);
            this.labelYOffset.TabIndex = 46;
            this.labelYOffset.Text = "0.0000um";
            // 
            // labelXOffset
            // 
            // 
            // 
            // 
            this.labelXOffset.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXOffset.Location = new System.Drawing.Point(195, 22);
            this.labelXOffset.Name = "labelXOffset";
            this.labelXOffset.Size = new System.Drawing.Size(75, 23);
            this.labelXOffset.TabIndex = 45;
            this.labelXOffset.Text = "0.0000um";
            // 
            // labelZAxis
            // 
            // 
            // 
            // 
            this.labelZAxis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelZAxis.Location = new System.Drawing.Point(60, 112);
            this.labelZAxis.Name = "labelZAxis";
            this.labelZAxis.Size = new System.Drawing.Size(75, 23);
            this.labelZAxis.TabIndex = 44;
            this.labelZAxis.Text = "0.0000um";
            // 
            // labelYAxis
            // 
            // 
            // 
            // 
            this.labelYAxis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelYAxis.Location = new System.Drawing.Point(59, 71);
            this.labelYAxis.Name = "labelYAxis";
            this.labelYAxis.Size = new System.Drawing.Size(75, 23);
            this.labelYAxis.TabIndex = 43;
            this.labelYAxis.Text = "0.0000um";
            // 
            // labelXAxis
            // 
            // 
            // 
            // 
            this.labelXAxis.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelXAxis.Location = new System.Drawing.Point(60, 22);
            this.labelXAxis.Name = "labelXAxis";
            this.labelXAxis.Size = new System.Drawing.Size(75, 23);
            this.labelXAxis.TabIndex = 42;
            this.labelXAxis.Text = "0.0000um";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(141, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Z Offset:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(141, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Y Offset:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(141, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "X Offset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(15, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Z Axis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Y Axis:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "X Axis:";
            // 
            // inputAbsoluteX
            // 
            // 
            // 
            // 
            this.inputAbsoluteX.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputAbsoluteX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputAbsoluteX.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputAbsoluteX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputAbsoluteX.Location = new System.Drawing.Point(60, 29);
            this.inputAbsoluteX.Name = "inputAbsoluteX";
            this.inputAbsoluteX.ShowUpDown = true;
            this.inputAbsoluteX.Size = new System.Drawing.Size(75, 23);
            this.inputAbsoluteX.TabIndex = 7;
            this.inputAbsoluteX.Value = 1;
            // 
            // MachineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.expandablePanel2);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MachineControl";
            this.Size = new System.Drawing.Size(280, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteY)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            this.expandablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panel1;
        private DevComponents.DotNetBar.PanelEx expandablePanel1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.ButtonX btnZRight;
        private DevComponents.DotNetBar.ButtonX btnZLeft;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnYRight;
        private DevComponents.DotNetBar.ButtonX btnYLeft;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnXRight;
        private DevComponents.DotNetBar.ButtonX btnXLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.PanelEx expandablePanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.LabelX labelZAxis;
        private DevComponents.DotNetBar.LabelX labelYAxis;
        private DevComponents.DotNetBar.LabelX labelXAxis;
        private DevComponents.DotNetBar.LabelX labelZOffset;
        private DevComponents.DotNetBar.LabelX labelYOffset;
        private DevComponents.DotNetBar.LabelX labelXOffset;
        private DevComponents.Editors.IntegerInput inputAbsoluteZ;
        private DevComponents.Editors.IntegerInput inputAbsoluteY;
        private DevComponents.DotNetBar.ButtonX btnAbsulate;
        private DevComponents.Editors.IntegerInput inputAbsoluteX;
    }
}
