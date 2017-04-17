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
            this.labelX1.Location = new System.Drawing.Point(22, 107);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Motion Step:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(22, 175);
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
            this.inputStep.Location = new System.Drawing.Point(103, 107);
            this.inputStep.MinValue = 1;
            this.inputStep.Name = "inputStep";
            this.inputStep.ShowUpDown = true;
            this.inputStep.Size = new System.Drawing.Size(101, 23);
            this.inputStep.TabIndex = 8;
            this.inputStep.Value = 1;
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
            this.cbxStepUnit.Location = new System.Drawing.Point(245, 107);
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
            this.inputSpeed.Location = new System.Drawing.Point(103, 175);
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
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(22, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(132, 255);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Location = new System.Drawing.Point(245, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            // 
            // MachineSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 303);
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
    }
}