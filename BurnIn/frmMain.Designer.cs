namespace BurnIn
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.设为桌面背景ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiEXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetupPara = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetupTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetupAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiInstrumentConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiPause = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tmsiLocationDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiManuallyCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystemOptionSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLockScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindowSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWizard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDate,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(929, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslDate
            // 
            this.tsslDate.BackColor = System.Drawing.Color.Transparent;
            this.tsslDate.Name = "tsslDate";
            this.tsslDate.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel8.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(161, 20);
            this.toolStripStatusLabel6.Text = "ManLink BurnIn System";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.toolStripSeparator1,
            this.重命名ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.toolStripSeparator3,
            this.设为桌面背景ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 198);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.打印ToolStripMenuItem.Text = "打印";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(140, 6);
            // 
            // 设为桌面背景ToolStripMenuItem
            // 
            this.设为桌面背景ToolStripMenuItem.Name = "设为桌面背景ToolStripMenuItem";
            this.设为桌面背景ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.设为桌面背景ToolStripMenuItem.Text = "设为桌面背景";
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.另存为ToolStripMenuItem.Text = "另存为...";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSetup,
            this.tsmiMonitor,
            this.tsmiSystem,
            this.tsmiWindow,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(929, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrint,
            this.tsmiPrintSetup,
            this.toolStripSeparator4,
            this.tsmiExport,
            this.toolStripSeparator6,
            this.tsmiEXIT});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.tsmiFile.Size = new System.Drawing.Size(64, 24);
            this.tsmiFile.Text = "File(&F)";
            this.tsmiFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.ShowShortcutKeys = false;
            this.tsmiPrint.Size = new System.Drawing.Size(200, 26);
            this.tsmiPrint.Text = "Print";
            this.tsmiPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // tsmiPrintSetup
            // 
            this.tsmiPrintSetup.Name = "tsmiPrintSetup";
            this.tsmiPrintSetup.ShowShortcutKeys = false;
            this.tsmiPrintSetup.Size = new System.Drawing.Size(200, 26);
            this.tsmiPrintSetup.Text = "Print Setup";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(200, 26);
            this.tsmiExport.Text = "Export to EXCEL";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(197, 6);
            // 
            // tsmiEXIT
            // 
            this.tsmiEXIT.Name = "tsmiEXIT";
            this.tsmiEXIT.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiEXIT.Size = new System.Drawing.Size(200, 26);
            this.tsmiEXIT.Text = "EXIT";
            this.tsmiEXIT.Click += new System.EventHandler(this.tsmiEXIT_Click);
            // 
            // tsmiSetup
            // 
            this.tsmiSetup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetupPara,
            this.tsmiSetupTime,
            this.tsmiSetupAlarm,
            this.toolStripSeparator,
            this.tsmiInstrumentConfig});
            this.tsmiSetup.Name = "tsmiSetup";
            this.tsmiSetup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmiSetup.Size = new System.Drawing.Size(83, 24);
            this.tsmiSetup.Text = "Setup(&S)";
            // 
            // tsmiSetupPara
            // 
            this.tsmiSetupPara.Name = "tsmiSetupPara";
            this.tsmiSetupPara.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmiSetupPara.Size = new System.Drawing.Size(232, 26);
            this.tsmiSetupPara.Text = "Setup Parameter";
            // 
            // tsmiSetupTime
            // 
            this.tsmiSetupTime.Name = "tsmiSetupTime";
            this.tsmiSetupTime.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmiSetupTime.Size = new System.Drawing.Size(232, 26);
            this.tsmiSetupTime.Text = "Setup TIme";
            // 
            // tsmiSetupAlarm
            // 
            this.tsmiSetupAlarm.Name = "tsmiSetupAlarm";
            this.tsmiSetupAlarm.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmiSetupAlarm.Size = new System.Drawing.Size(232, 26);
            this.tsmiSetupAlarm.Text = "Setup Alarm";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiInstrumentConfig
            // 
            this.tsmiInstrumentConfig.Name = "tsmiInstrumentConfig";
            this.tsmiInstrumentConfig.Size = new System.Drawing.Size(232, 26);
            this.tsmiInstrumentConfig.Text = "Instrument Config";
            // 
            // tsmiMonitor
            // 
            this.tsmiMonitor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tmsiPause,
            this.tsmiContinue,
            this.tmsiStop,
            this.toolStripSeparator2,
            this.tmsiLocationDetect,
            this.tmsiManuallyCheck});
            this.tsmiMonitor.Name = "tsmiMonitor";
            this.tsmiMonitor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.tsmiMonitor.Size = new System.Drawing.Size(106, 24);
            this.tsmiMonitor.Text = "Monitor(&M)";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(200, 26);
            this.tsmiStart.Text = "Start Burn In";
            // 
            // tmsiPause
            // 
            this.tmsiPause.Name = "tmsiPause";
            this.tmsiPause.Size = new System.Drawing.Size(200, 26);
            this.tmsiPause.Text = "Pause";
            // 
            // tsmiContinue
            // 
            this.tsmiContinue.Name = "tsmiContinue";
            this.tsmiContinue.Size = new System.Drawing.Size(200, 26);
            this.tsmiContinue.Text = "Continue";
            // 
            // tmsiStop
            // 
            this.tmsiStop.Name = "tmsiStop";
            this.tmsiStop.Size = new System.Drawing.Size(200, 26);
            this.tmsiStop.Text = "Stop";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // tmsiLocationDetect
            // 
            this.tmsiLocationDetect.Name = "tmsiLocationDetect";
            this.tmsiLocationDetect.Size = new System.Drawing.Size(200, 26);
            this.tmsiLocationDetect.Text = "Location Detect";
            // 
            // tmsiManuallyCheck
            // 
            this.tmsiManuallyCheck.Name = "tmsiManuallyCheck";
            this.tmsiManuallyCheck.Size = new System.Drawing.Size(200, 26);
            this.tmsiManuallyCheck.Text = "Manually Check";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetPassword,
            this.tsmiSystemOptionSet,
            this.tsmiLockScreen});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.tsmiSystem.Size = new System.Drawing.Size(74, 24);
            this.tsmiSystem.Text = "System";
            // 
            // tsmiSetPassword
            // 
            this.tsmiSetPassword.Name = "tsmiSetPassword";
            this.tsmiSetPassword.Size = new System.Drawing.Size(220, 26);
            this.tsmiSetPassword.Text = "Set Password";
            // 
            // tsmiSystemOptionSet
            // 
            this.tsmiSystemOptionSet.Name = "tsmiSystemOptionSet";
            this.tsmiSystemOptionSet.Size = new System.Drawing.Size(220, 26);
            this.tsmiSystemOptionSet.Text = "System Option Set";
            // 
            // tsmiLockScreen
            // 
            this.tsmiLockScreen.Name = "tsmiLockScreen";
            this.tsmiLockScreen.Size = new System.Drawing.Size(220, 26);
            this.tsmiLockScreen.Text = "LockScreen";
            // 
            // tsmiWindow
            // 
            this.tsmiWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWindowSwitch});
            this.tsmiWindow.Name = "tsmiWindow";
            this.tsmiWindow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.tsmiWindow.Size = new System.Drawing.Size(106, 24);
            this.tsmiWindow.Text = "Window(&W)";
            // 
            // tsmiWindowSwitch
            // 
            this.tsmiWindowSwitch.Name = "tsmiWindowSwitch";
            this.tsmiWindowSwitch.Size = new System.Drawing.Size(196, 26);
            this.tsmiWindowSwitch.Text = "Window Switch";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDebug,
            this.tsmiWizard,
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsmiHelp.Size = new System.Drawing.Size(78, 24);
            this.tsmiHelp.Text = "Help(&H)";
            // 
            // tsmiDebug
            // 
            this.tsmiDebug.Name = "tsmiDebug";
            this.tsmiDebug.Size = new System.Drawing.Size(134, 26);
            this.tsmiDebug.Text = "Debug";
            this.tsmiDebug.Click += new System.EventHandler(this.tsmiDebug_Click);
            // 
            // tsmiWizard
            // 
            this.tsmiWizard.Name = "tsmiWizard";
            this.tsmiWizard.Size = new System.Drawing.Size(134, 26);
            this.tsmiWizard.Text = "Wizard";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(134, 26);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbRefresh,
            this.tsbPrint,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(929, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(73, 24);
            this.tsbOpen.Text = "Open";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(88, 24);
            this.tsbRefresh.Text = "Refresh";
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(67, 24);
            this.tsbPrint.Text = "Print";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(81, 24);
            this.tsbDelete.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 521);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Slot No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Instrument Status";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Device Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PS1(V)";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "PS2(V)";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PS3(V)";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PS4(V)";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "PSIG(V)";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Burn In Progress";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Alarm Status";
            this.Column10.Name = "Column10";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BURN IN SYSTEM";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 设为桌面背景ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrintSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmiEXIT;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetup;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetupPara;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetupTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetupAlarm;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonitor;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiContinue;
        private System.Windows.Forms.ToolStripMenuItem tmsiPause;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiInstrumentConfig;
        private System.Windows.Forms.ToolStripMenuItem tmsiStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tmsiLocationDetect;
        private System.Windows.Forms.ToolStripMenuItem tmsiManuallyCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetPassword;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemOptionSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiLockScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindowSwitch;
        private System.Windows.Forms.ToolStripMenuItem tsmiWizard;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ToolStripMenuItem tsmiDebug;
    }
}

