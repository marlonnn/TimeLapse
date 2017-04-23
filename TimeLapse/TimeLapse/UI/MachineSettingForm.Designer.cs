namespace TimeLapse.UI
{
    partial class MachineSettingForm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.inputStep = new DevComponents.Editors.IntegerInput();
            this.cbxStepUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.inputSpeed = new DevComponents.Editors.IntegerInput();
            this.ipAddressInput = new DevComponents.Editors.IpAddressInput();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelStatus = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.cbxMotionMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 89);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Motion Step:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 128);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Motion Speed:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(22, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "IP Address:";
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
            this.inputStep.Location = new System.Drawing.Point(103, 89);
            this.inputStep.MinValue = 1;
            this.inputStep.Name = "inputStep";
            this.inputStep.ShowUpDown = true;
            this.inputStep.Size = new System.Drawing.Size(101, 23);
            this.inputStep.TabIndex = 8;
            this.inputStep.Value = 1;
            this.inputStep.ValueChanged += new System.EventHandler(this.inputStep_ValueChanged);
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
            this.cbxStepUnit.Location = new System.Drawing.Point(261, 89);
            this.cbxStepUnit.Name = "cbxStepUnit";
            this.cbxStepUnit.Size = new System.Drawing.Size(79, 23);
            this.cbxStepUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStepUnit.TabIndex = 20;
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
            // inputSpeed
            // 
            // 
            // 
            // 
            this.inputSpeed.BackgroundStyle.Class = "DateTimeInputBackground";
            this.inputSpeed.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inputSpeed.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.inputSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputSpeed.Location = new System.Drawing.Point(103, 128);
            this.inputSpeed.MinValue = 1;
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.ShowUpDown = true;
            this.inputSpeed.Size = new System.Drawing.Size(101, 23);
            this.inputSpeed.TabIndex = 21;
            this.inputSpeed.Value = 1;
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
            this.ipAddressInput.Location = new System.Drawing.Point(103, 43);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(101, 23);
            this.ipAddressInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ipAddressInput.TabIndex = 22;
            this.ipAddressInput.Value = "10.0.0.100";
            this.ipAddressInput.Click += new System.EventHandler(this.ipAddressInput_Click);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(22, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(103, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(184, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Stop";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(227, 43);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(41, 23);
            this.labelX4.TabIndex = 26;
            this.labelX4.Text = "Status:";
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // labelStatus
            // 
            // 
            // 
            // 
            this.labelStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStatus.Location = new System.Drawing.Point(273, 43);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(75, 23);
            this.labelStatus.TabIndex = 27;
            this.labelStatus.Text = "OFF";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(265, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(226, 89);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(29, 23);
            this.labelX7.TabIndex = 31;
            this.labelX7.Text = "Unit:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(226, 128);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 32;
            this.labelX5.Text = "um/s";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(22, 171);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 33;
            this.labelX6.Text = "Motion Mode:";
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
            this.cbxMotionMode.Location = new System.Drawing.Point(103, 171);
            this.cbxMotionMode.Name = "cbxMotionMode";
            this.cbxMotionMode.Size = new System.Drawing.Size(101, 23);
            this.cbxMotionMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMotionMode.TabIndex = 34;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Fixed Length";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Fixed Speed";
            // 
            // MachineSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 277);
            this.Controls.Add(this.cbxMotionMode);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ipAddressInput);
            this.Controls.Add(this.inputSpeed);
            this.Controls.Add(this.cbxStepUnit);
            this.Controls.Add(this.inputStep);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "MachineSettingForm";
            this.Text = "MachineSettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.IntegerInput inputStep;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxStepUnit;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.IntegerInput inputSpeed;
        private DevComponents.Editors.IpAddressInput ipAddressInput;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelStatus;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxMotionMode;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
    }
}