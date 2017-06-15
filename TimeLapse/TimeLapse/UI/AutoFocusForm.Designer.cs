namespace TimeLapse.UI
{
    partial class AutoFocusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnInitialize = new DevComponents.DotNetBar.ButtonX();
            this.cbxMotionMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelStatus = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.ipAddressInput = new DevComponents.Editors.IpAddressInput();
            this.inputSpeed = new DevComponents.Editors.IntegerInput();
            this.cbxStepUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.inputStep = new DevComponents.Editors.IntegerInput();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnStartFocus = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.Color.Transparent;
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.btnReset);
            this.panelEx1.Controls.Add(this.btnInitialize);
            this.panelEx1.Controls.Add(this.cbxMotionMode);
            this.panelEx1.Controls.Add(this.labelX6);
            this.panelEx1.Controls.Add(this.labelX5);
            this.panelEx1.Controls.Add(this.labelStatus);
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.ipAddressInput);
            this.panelEx1.Controls.Add(this.inputSpeed);
            this.panelEx1.Controls.Add(this.cbxStepUnit);
            this.panelEx1.Controls.Add(this.inputStep);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Location = new System.Drawing.Point(4, 12);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(300, 192);
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.TabIndex = 38;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(213, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Stop";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(110, 153);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 25);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInitialize.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInitialize.Location = new System.Drawing.Point(13, 153);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 25);
            this.btnInitialize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInitialize.TabIndex = 48;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // cbxMotionMode
            // 
            this.cbxMotionMode.DisplayMember = "Text";
            this.cbxMotionMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMotionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMotionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxMotionMode.FormattingEnabled = true;
            this.cbxMotionMode.ItemHeight = 17;
            this.cbxMotionMode.Items.AddRange(new object[] {
            this.comboItem2,
            this.comboItem3});
            this.cbxMotionMode.Location = new System.Drawing.Point(94, 104);
            this.cbxMotionMode.Name = "cbxMotionMode";
            this.cbxMotionMode.Size = new System.Drawing.Size(117, 23);
            this.cbxMotionMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMotionMode.TabIndex = 47;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Fixed Length";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Fixed Speed";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(15, 104);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(85, 25);
            this.labelX6.TabIndex = 46;
            this.labelX6.Text = "Motion Mode:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(213, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 25);
            this.labelX5.TabIndex = 45;
            this.labelX5.Text = "um/s";
            // 
            // labelStatus
            // 
            // 
            // 
            // 
            this.labelStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(259, 10);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(33, 25);
            this.labelStatus.TabIndex = 43;
            this.labelStatus.Text = "OFF";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(213, 10);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 25);
            this.labelX4.TabIndex = 42;
            this.labelX4.Text = "Status:";
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.AutoOverwrite = true;
            // 
            // 
            // 
            this.ipAddressInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ipAddressInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ipAddressInput.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.ipAddressInput.ButtonFreeText.Visible = true;
            this.ipAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ipAddressInput.Location = new System.Drawing.Point(94, 10);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(117, 23);
            this.ipAddressInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressInput.TabIndex = 41;
            this.ipAddressInput.Value = "10.0.0.100";
            // 
            // inputSpeed
            // 
            // 
            // 
            // 
            this.inputSpeed.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputSpeed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputSpeed.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputSpeed.Location = new System.Drawing.Point(94, 73);
            this.inputSpeed.MinValue = 1;
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.ShowUpDown = true;
            this.inputSpeed.Size = new System.Drawing.Size(117, 23);
            this.inputSpeed.TabIndex = 40;
            this.inputSpeed.Value = 1;
            // 
            // cbxStepUnit
            // 
            this.cbxStepUnit.DisplayMember = "Text";
            this.cbxStepUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStepUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStepUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStepUnit.FormattingEnabled = true;
            this.cbxStepUnit.ItemHeight = 17;
            this.cbxStepUnit.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem4,
            this.comboItem6});
            this.cbxStepUnit.Location = new System.Drawing.Point(213, 41);
            this.cbxStepUnit.Name = "cbxStepUnit";
            this.cbxStepUnit.Size = new System.Drawing.Size(79, 23);
            this.cbxStepUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStepUnit.TabIndex = 39;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "mm";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "μm";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "50nm";
            // 
            // inputStep
            // 
            // 
            // 
            // 
            this.inputStep.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputStep.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputStep.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputStep.Location = new System.Drawing.Point(94, 41);
            this.inputStep.MinValue = 1;
            this.inputStep.Name = "inputStep";
            this.inputStep.ShowUpDown = true;
            this.inputStep.Size = new System.Drawing.Size(117, 23);
            this.inputStep.TabIndex = 38;
            this.inputStep.Value = 1;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 10);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(83, 25);
            this.labelX3.TabIndex = 37;
            this.labelX3.Text = "IP Address:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 73);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 25);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "Motion Speed:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 25);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "Motion Step:";
            // 
            // btnStartFocus
            // 
            this.btnStartFocus.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStartFocus.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartFocus.Location = new System.Drawing.Point(4, 225);
            this.btnStartFocus.Name = "btnStartFocus";
            this.btnStartFocus.Size = new System.Drawing.Size(300, 42);
            this.btnStartFocus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStartFocus.TabIndex = 51;
            this.btnStartFocus.Text = "Start Focus";
            this.btnStartFocus.Click += new System.EventHandler(this.btnStartFocus_Click);
            // 
            // AutoFocusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 276);
            this.Controls.Add(this.btnStartFocus);
            this.Controls.Add(this.panelEx1);
            this.Name = "AutoFocusForm";
            this.Text = "AutoFocusForm";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnInitialize;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMotionMode;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelStatus;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IpAddressInput ipAddressInput;
        private DevComponents.Editors.IntegerInput inputSpeed;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStepUnit;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.IntegerInput inputStep;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnStartFocus;
    }
}