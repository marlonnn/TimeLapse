namespace TimeLapse.UI
{
    partial class ControlForm
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
            Exit();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItemMachine = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCamera = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItemStart = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemPause = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemStop = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSnapShot = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemAutoFocus = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItemAbout = new DevComponents.DotNetBar.ButtonItem();
            this.machineControl = new TimeLapse.UI.MachineControl();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.Size = new System.Drawing.Size(687, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(687, 98);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 3;
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemMachine,
            this.buttonItemCamera});
            this.ribbonBar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar3.Location = new System.Drawing.Point(255, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(100, 95);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Text = "Setting";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemMachine
            // 
            this.buttonItemMachine.Image = global::TimeLapse.Properties.Resources.Machine_Setting;
            this.buttonItemMachine.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemMachine.Name = "buttonItemMachine";
            this.buttonItemMachine.Text = "Machine";
            this.buttonItemMachine.Click += new System.EventHandler(this.buttonItemMachine_Click);
            // 
            // buttonItemCamera
            // 
            this.buttonItemCamera.Image = global::TimeLapse.Properties.Resources.Camera_Setting;
            this.buttonItemCamera.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCamera.Name = "buttonItemCamera";
            this.buttonItemCamera.SubItemsExpandWidth = 14;
            this.buttonItemCamera.Text = "Camera";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemStart,
            this.buttonItemPause,
            this.buttonItemStop,
            this.buttonItemSnapShot,
            this.buttonItemAutoFocus});
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(252, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Camera Control";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemStart
            // 
            this.buttonItemStart.Image = global::TimeLapse.Properties.Resources.Camera_Start;
            this.buttonItemStart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemStart.Name = "buttonItemStart";
            this.buttonItemStart.SubItemsExpandWidth = 14;
            this.buttonItemStart.Text = "Start ";
            this.buttonItemStart.Click += new System.EventHandler(this.buttonItemStart_Click);
            // 
            // buttonItemPause
            // 
            this.buttonItemPause.Image = global::TimeLapse.Properties.Resources.Camera_Pause;
            this.buttonItemPause.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemPause.Name = "buttonItemPause";
            this.buttonItemPause.Text = "Pause";
            this.buttonItemPause.Click += new System.EventHandler(this.buttonItemPause_Click);
            // 
            // buttonItemStop
            // 
            this.buttonItemStop.Image = global::TimeLapse.Properties.Resources.Camera_Stop;
            this.buttonItemStop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemStop.Name = "buttonItemStop";
            this.buttonItemStop.Text = "Stop";
            this.buttonItemStop.Click += new System.EventHandler(this.buttonItemStop_Click);
            // 
            // buttonItemSnapShot
            // 
            this.buttonItemSnapShot.Image = global::TimeLapse.Properties.Resources.Camera_Snapshot;
            this.buttonItemSnapShot.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSnapShot.Name = "buttonItemSnapShot";
            this.buttonItemSnapShot.Text = "Snapshot";
            this.buttonItemSnapShot.Click += new System.EventHandler(this.buttonItemSnapShot_Click);
            // 
            // buttonItemAutoFocus
            // 
            this.buttonItemAutoFocus.Image = global::TimeLapse.Properties.Resources.Camera_Focus;
            this.buttonItemAutoFocus.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAutoFocus.Name = "buttonItemAutoFocus";
            this.buttonItemAutoFocus.Text = "AutoFocus";
            this.buttonItemAutoFocus.Click += new System.EventHandler(this.buttonItemAutoFocus_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Home";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(266, 158);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(414, 462);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAbout});
            this.ribbonBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar2.Location = new System.Drawing.Point(355, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(49, 95);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 2;
            this.ribbonBar2.Text = "About";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItemAbout
            // 
            this.buttonItemAbout.Image = global::TimeLapse.Properties.Resources.Help;
            this.buttonItemAbout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAbout.Name = "buttonItemAbout";
            this.buttonItemAbout.SubItemsExpandWidth = 14;
            this.buttonItemAbout.Text = "About";
            this.buttonItemAbout.Click += new System.EventHandler(this.buttonItemAbout_Click);
            // 
            // machineControl
            // 
            this.machineControl.BackColor = System.Drawing.Color.Transparent;
            this.machineControl.Location = new System.Drawing.Point(8, 155);
            this.machineControl.Name = "machineControl";
            this.machineControl.Size = new System.Drawing.Size(252, 470);
            this.machineControl.TabIndex = 1;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 681);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.machineControl);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItemStart;
        private DevComponents.DotNetBar.ButtonItem buttonItemPause;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItemStop;
        private DevComponents.DotNetBar.ButtonItem buttonItemSnapShot;
        private DevComponents.DotNetBar.ButtonItem buttonItemAutoFocus;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem buttonItemMachine;
        private DevComponents.DotNetBar.ButtonItem buttonItemCamera;
        private MachineControl machineControl;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItemAbout;
    }
}