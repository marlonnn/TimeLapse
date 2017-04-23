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
            this.inputAbsoluteX = new DevComponents.Editors.IntegerInput();
            this.btnAbsulate = new DevComponents.DotNetBar.ButtonX();
            this.inputAbsoluteZ = new DevComponents.Editors.IntegerInput();
            this.inputAbsoluteY = new DevComponents.Editors.IntegerInput();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
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
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteY)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(300, 146);
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
            this.btnZRight.Location = new System.Drawing.Point(162, 100);
            this.btnZRight.Name = "btnZRight";
            this.btnZRight.Size = new System.Drawing.Size(75, 21);
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
            this.btnZLeft.Location = new System.Drawing.Point(59, 100);
            this.btnZLeft.Name = "btnZLeft";
            this.btnZLeft.Size = new System.Drawing.Size(75, 21);
            this.btnZLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnZLeft.TabIndex = 5;
            this.btnZLeft.Text = "&Left";
            this.btnZLeft.Click += new System.EventHandler(this.btnZLeft_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "Z Axis:";
            // 
            // btnYRight
            // 
            this.btnYRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYRight.Enabled = false;
            this.btnYRight.Location = new System.Drawing.Point(162, 62);
            this.btnYRight.Name = "btnYRight";
            this.btnYRight.Size = new System.Drawing.Size(75, 21);
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
            this.btnYLeft.Location = new System.Drawing.Point(59, 62);
            this.btnYLeft.Name = "btnYLeft";
            this.btnYLeft.Size = new System.Drawing.Size(75, 21);
            this.btnYLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYLeft.TabIndex = 3;
            this.btnYLeft.Text = "&Left";
            this.btnYLeft.Click += new System.EventHandler(this.btnYLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "Y Axis:";
            // 
            // btnXRight
            // 
            this.btnXRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXRight.Enabled = false;
            this.btnXRight.Location = new System.Drawing.Point(162, 23);
            this.btnXRight.Name = "btnXRight";
            this.btnXRight.Size = new System.Drawing.Size(75, 21);
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
            this.btnXLeft.Location = new System.Drawing.Point(59, 23);
            this.btnXLeft.Name = "btnXLeft";
            this.btnXLeft.Size = new System.Drawing.Size(75, 21);
            this.btnXLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXLeft.TabIndex = 1;
            this.btnXLeft.Text = "&Left";
            this.btnXLeft.Click += new System.EventHandler(this.btnXLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(15, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
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
            this.expandablePanel1.Location = new System.Drawing.Point(0, 146);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(300, 143);
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.expandablePanel1.TabIndex = 34;
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
            this.inputAbsoluteX.Location = new System.Drawing.Point(60, 27);
            this.inputAbsoluteX.Name = "inputAbsoluteX";
            this.inputAbsoluteX.ShowUpDown = true;
            this.inputAbsoluteX.Size = new System.Drawing.Size(75, 23);
            this.inputAbsoluteX.TabIndex = 7;
            this.inputAbsoluteX.Value = 1;
            // 
            // btnAbsulate
            // 
            this.btnAbsulate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAbsulate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAbsulate.Enabled = false;
            this.btnAbsulate.Location = new System.Drawing.Point(162, 61);
            this.btnAbsulate.Name = "btnAbsulate";
            this.btnAbsulate.Size = new System.Drawing.Size(75, 21);
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
            this.inputAbsoluteZ.Location = new System.Drawing.Point(59, 102);
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
            this.inputAbsoluteY.Location = new System.Drawing.Point(59, 66);
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
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "Z Axis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(15, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Y Axis:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "X Axis:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.Color.Transparent;
            this.panelEx1.Controls.Add(this.btnClose);
            this.panelEx1.Controls.Add(this.btnReset);
            this.panelEx1.Controls.Add(this.btnStart);
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
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 289);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(300, 177);
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.Color.CadetBlue;
            this.panelEx1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelEx1.TabIndex = 36;
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
            this.cbxMotionMode.Location = new System.Drawing.Point(94, 96);
            this.cbxMotionMode.Name = "cbxMotionMode";
            this.cbxMotionMode.Size = new System.Drawing.Size(117, 23);
            this.cbxMotionMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxMotionMode.TabIndex = 47;
            this.cbxMotionMode.SelectedIndexChanged += new System.EventHandler(this.MotionMode_SelectedIndexChanged);
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
            this.labelX6.Location = new System.Drawing.Point(15, 96);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(85, 23);
            this.labelX6.TabIndex = 46;
            this.labelX6.Text = "Motion Mode:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(213, 67);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 45;
            this.labelX5.Text = "um/s";
            // 
            // labelStatus
            // 
            // 
            // 
            // 
            this.labelStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelStatus.Location = new System.Drawing.Point(259, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Size = new System.Drawing.Size(33, 23);
            this.labelStatus.TabIndex = 43;
            this.labelStatus.Text = "OFF";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(213, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 23);
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
            this.ipAddressInput.Location = new System.Drawing.Point(94, 9);
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
            this.inputSpeed.Location = new System.Drawing.Point(94, 67);
            this.inputSpeed.MinValue = 1;
            this.inputSpeed.Name = "inputSpeed";
            this.inputSpeed.ShowUpDown = true;
            this.inputSpeed.Size = new System.Drawing.Size(117, 23);
            this.inputSpeed.TabIndex = 40;
            this.inputSpeed.Value = 1;
            this.inputSpeed.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
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
            this.cbxStepUnit.Location = new System.Drawing.Point(213, 38);
            this.cbxStepUnit.Name = "cbxStepUnit";
            this.cbxStepUnit.Size = new System.Drawing.Size(79, 23);
            this.cbxStepUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxStepUnit.TabIndex = 39;
            this.cbxStepUnit.SelectedIndexChanged += new System.EventHandler(this.MotionStep_SelectedIndexChanged);
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
            this.inputStep.Location = new System.Drawing.Point(94, 38);
            this.inputStep.MinValue = 1;
            this.inputStep.Name = "inputStep";
            this.inputStep.ShowUpDown = true;
            this.inputStep.Size = new System.Drawing.Size(117, 23);
            this.inputStep.TabIndex = 38;
            this.inputStep.Value = 1;
            this.inputStep.ValueChanged += new System.EventHandler(this.Step_ValueChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(15, 9);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(83, 23);
            this.labelX3.TabIndex = 37;
            this.labelX3.Text = "IP Address:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(15, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "Motion Speed:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(15, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(85, 23);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "Motion Step:";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(213, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
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
            this.btnReset.Location = new System.Drawing.Point(110, 141);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 49;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(13, 141);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MachineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MachineControl";
            this.Size = new System.Drawing.Size(300, 468);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAbsoluteY)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipAddressInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputStep)).EndInit();
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
        private DevComponents.Editors.IntegerInput inputAbsoluteZ;
        private DevComponents.Editors.IntegerInput inputAbsoluteY;
        private DevComponents.DotNetBar.ButtonX btnAbsulate;
        private DevComponents.Editors.IntegerInput inputAbsoluteX;
        private DevComponents.DotNetBar.PanelEx panelEx1;
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
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.ButtonX btnStart;
    }
}
