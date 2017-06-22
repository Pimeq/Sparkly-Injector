namespace Injector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HideWin = new Custom_GUI.FlatButton();
            this.Exit = new Custom_GUI.FlatButton();
            this.Title = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayInject = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayInjectExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainTabs = new Custom_GUI.TabControl();
            this.Info = new System.Windows.Forms.TabPage();
            this.DiscordLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nVersion_label = new System.Windows.Forms.Label();
            this.cVersion_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Injector = new System.Windows.Forms.TabPage();
            this.ripLavi = new System.Windows.Forms.Label();
            this.SelectProc = new System.Windows.Forms.PictureBox();
            this.MsgAfterInject = new System.Windows.Forms.CheckBox();
            this.Inject = new Custom_GUI.FlatButton();
            this.CheckAll = new Custom_GUI.FlatButton();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.CloseAfterInject = new System.Windows.Forms.CheckBox();
            this.Uncheck = new Custom_GUI.FlatButton();
            this.RemoveFile = new System.Windows.Forms.PictureBox();
            this.AddFolder = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.PictureBox();
            this.FileList = new System.Windows.Forms.CheckedListBox();
            this.Cheats = new System.Windows.Forms.TabPage();
            this.OpenFolder = new Custom_GUI.FlatButton();
            this.QuickInject = new Custom_GUI.FlatButton();
            this.DownloadFile = new Custom_GUI.FlatButton();
            this.updateDlls = new Custom_GUI.FlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Downloads = new System.Windows.Forms.ListBox();
            this.Owned = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.Info.SuspendLayout();
            this.Injector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).BeginInit();
            this.Cheats.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopPanel.Controls.Add(this.HideWin);
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(497, 28);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // HideWin
            // 
            this.HideWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HideWin.Border = false;
            this.HideWin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HideWin.BorderThickness = 2F;
            this.HideWin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.HideWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.HideWin.Location = new System.Drawing.Point(445, 0);
            this.HideWin.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.HideWin.Name = "HideWin";
            this.HideWin.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.HideWin.Size = new System.Drawing.Size(26, 28);
            this.HideWin.TabIndex = 7;
            this.HideWin.Text = "_";
            this.HideWin.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Exit.Border = false;
            this.Exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Exit.BorderThickness = 2F;
            this.Exit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Exit.Location = new System.Drawing.Point(471, 0);
            this.Exit.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.Exit.Name = "Exit";
            this.Exit.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.Exit.Size = new System.Drawing.Size(26, 28);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, -4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(124, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sparkly Injector";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipText = "The injector has been minimized to the tray.\r\nRight click for a list of options.";
            this.NotifyIcon.BalloonTipTitle = "Cade\'s Sparkly injector";
            this.NotifyIcon.ContextMenuStrip = this.MenuStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Cade\'s Sparkly injector";
            this.NotifyIcon.Visible = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayInject,
            this.TrayInjectExit,
            this.TrayOpen,
            this.TrayClose});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(148, 92);
            // 
            // TrayInject
            // 
            this.TrayInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.TrayInject.Name = "TrayInject";
            this.TrayInject.Size = new System.Drawing.Size(147, 22);
            this.TrayInject.Text = "Inject";
            this.TrayInject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // TrayInjectExit
            // 
            this.TrayInjectExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.TrayInjectExit.Name = "TrayInjectExit";
            this.TrayInjectExit.Size = new System.Drawing.Size(147, 22);
            this.TrayInjectExit.Text = "Inject and exit";
            this.TrayInjectExit.Click += new System.EventHandler(this.TrayInjectExit_Click);
            // 
            // TrayOpen
            // 
            this.TrayOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.TrayOpen.Name = "TrayOpen";
            this.TrayOpen.Size = new System.Drawing.Size(147, 22);
            this.TrayOpen.Text = "Open";
            this.TrayOpen.Click += new System.EventHandler(this.TrayOpen_Click);
            // 
            // TrayClose
            // 
            this.TrayClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.TrayClose.Name = "TrayClose";
            this.TrayClose.Size = new System.Drawing.Size(147, 22);
            this.TrayClose.Text = "Exit";
            this.TrayClose.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 71);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainTabs
            // 
            this.MainTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainTabs.ClosedTab = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainTabs.Controls.Add(this.Info);
            this.MainTabs.Controls.Add(this.Injector);
            this.MainTabs.Controls.Add(this.Cheats);
            this.MainTabs.CurrentTab = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MainTabs.Location = new System.Drawing.Point(12, 35);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.PageBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainTabs.PageBorder = false;
            this.MainTabs.PageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(475, 253);
            this.MainTabs.TabBorder = false;
            this.MainTabs.TabBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.MainTabs.TabIndex = 14;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Info.Controls.Add(this.DiscordLink);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.label1);
            this.Info.Controls.Add(this.nVersion_label);
            this.Info.Controls.Add(this.cVersion_label);
            this.Info.Controls.Add(this.textBox1);
            this.Info.Location = new System.Drawing.Point(4, 25);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(467, 224);
            this.Info.TabIndex = 0;
            this.Info.Text = "Info";
            // 
            // DiscordLink
            // 
            this.DiscordLink.AutoSize = true;
            this.DiscordLink.LinkColor = System.Drawing.Color.Coral;
            this.DiscordLink.Location = new System.Drawing.Point(267, 94);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(185, 13);
            this.DiscordLink.TabIndex = 20;
            this.DiscordLink.TabStop = true;
            this.DiscordLink.Text = "https://www.Discord.io/SparklyCheat";
            this.DiscordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(267, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Official Discord\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(267, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 70);
            this.label1.TabIndex = 17;
            this.label1.Text = "If you minimize the injector, it\'ll\r\nappear in the tray just like a loader!\r\n\r\nYo" +
    "u can right-click on it\'s icon for\r\noptions while it\'s there";
            // 
            // nVersion_label
            // 
            this.nVersion_label.AutoSize = true;
            this.nVersion_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nVersion_label.Location = new System.Drawing.Point(267, 28);
            this.nVersion_label.Name = "nVersion_label";
            this.nVersion_label.Size = new System.Drawing.Size(129, 16);
            this.nVersion_label.TabIndex = 16;
            this.nVersion_label.Text = "Newest version: ";
            // 
            // cVersion_label
            // 
            this.cVersion_label.AutoSize = true;
            this.cVersion_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cVersion_label.Location = new System.Drawing.Point(267, 6);
            this.cVersion_label.Name = "cVersion_label";
            this.cVersion_label.Size = new System.Drawing.Size(130, 16);
            this.cVersion_label.TabIndex = 15;
            this.cVersion_label.Text = "Current version: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 212);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "\"Announcements\" could not be downloaded";
            // 
            // Injector
            // 
            this.Injector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Injector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Injector.Controls.Add(this.ripLavi);
            this.Injector.Controls.Add(this.SelectProc);
            this.Injector.Controls.Add(this.MsgAfterInject);
            this.Injector.Controls.Add(this.Inject);
            this.Injector.Controls.Add(this.CheckAll);
            this.Injector.Controls.Add(this.ProcessName);
            this.Injector.Controls.Add(this.CloseAfterInject);
            this.Injector.Controls.Add(this.Uncheck);
            this.Injector.Controls.Add(this.RemoveFile);
            this.Injector.Controls.Add(this.AddFolder);
            this.Injector.Controls.Add(this.OpenFile);
            this.Injector.Controls.Add(this.FileList);
            this.Injector.Location = new System.Drawing.Point(4, 25);
            this.Injector.Margin = new System.Windows.Forms.Padding(0);
            this.Injector.Name = "Injector";
            this.Injector.Size = new System.Drawing.Size(467, 224);
            this.Injector.TabIndex = 2;
            this.Injector.Text = "Injector";
            // 
            // ripLavi
            // 
            this.ripLavi.AutoSize = true;
            this.ripLavi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ripLavi.Location = new System.Drawing.Point(243, 30);
            this.ripLavi.Name = "ripLavi";
            this.ripLavi.Size = new System.Drawing.Size(167, 26);
            this.ripLavi.TabIndex = 17;
            this.ripLavi.Text = "R.I.P. Lavi development past 4.0\r\nBlank space to honor it";
            this.ripLavi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SelectProc
            // 
            this.SelectProc.BackgroundImage = global::Injector.Properties.Resources.Search;
            this.SelectProc.Location = new System.Drawing.Point(185, 92);
            this.SelectProc.Name = "SelectProc";
            this.SelectProc.Size = new System.Drawing.Size(30, 40);
            this.SelectProc.TabIndex = 16;
            this.SelectProc.TabStop = false;
            this.SelectProc.Click += new System.EventHandler(this.SelectProc_Click);
            // 
            // MsgAfterInject
            // 
            this.MsgAfterInject.AutoSize = true;
            this.MsgAfterInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MsgAfterInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MsgAfterInject.Location = new System.Drawing.Point(185, 193);
            this.MsgAfterInject.Name = "MsgAfterInject";
            this.MsgAfterInject.Padding = new System.Windows.Forms.Padding(5);
            this.MsgAfterInject.Size = new System.Drawing.Size(145, 27);
            this.MsgAfterInject.TabIndex = 15;
            this.MsgAfterInject.Text = "Message after injecting";
            this.MsgAfterInject.UseVisualStyleBackColor = false;
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Inject.Border = true;
            this.Inject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Inject.BorderThickness = 1F;
            this.Inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Inject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Inject.Location = new System.Drawing.Point(185, 138);
            this.Inject.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Inject.Name = "Inject";
            this.Inject.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Inject.Size = new System.Drawing.Size(271, 49);
            this.Inject.TabIndex = 15;
            this.Inject.Text = "Inject";
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CheckAll.Border = true;
            this.CheckAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.CheckAll.BorderThickness = 1F;
            this.CheckAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckAll.Location = new System.Drawing.Point(3, 197);
            this.CheckAll.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.CheckAll.Size = new System.Drawing.Size(85, 23);
            this.CheckAll.TabIndex = 7;
            this.CheckAll.Text = "Check all";
            this.CheckAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProcessName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ProcessName.Location = new System.Drawing.Point(221, 92);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(235, 20);
            this.ProcessName.TabIndex = 3;
            this.ProcessName.Text = "Find a processs or enter the name";
            this.ProcessName.WordWrap = false;
            this.ProcessName.DoubleClick += new System.EventHandler(this.ProcessName_DoubleClick);
            this.ProcessName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProcessName_KeyPress);
            // 
            // CloseAfterInject
            // 
            this.CloseAfterInject.AutoSize = true;
            this.CloseAfterInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseAfterInject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CloseAfterInject.Location = new System.Drawing.Point(336, 193);
            this.CloseAfterInject.Name = "CloseAfterInject";
            this.CloseAfterInject.Padding = new System.Windows.Forms.Padding(5);
            this.CloseAfterInject.Size = new System.Drawing.Size(128, 27);
            this.CloseAfterInject.TabIndex = 6;
            this.CloseAfterInject.Text = "Close after injecting";
            this.CloseAfterInject.UseVisualStyleBackColor = false;
            // 
            // Uncheck
            // 
            this.Uncheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Uncheck.Border = true;
            this.Uncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Uncheck.BorderThickness = 1F;
            this.Uncheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Uncheck.Location = new System.Drawing.Point(94, 197);
            this.Uncheck.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Uncheck.Name = "Uncheck";
            this.Uncheck.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Uncheck.Size = new System.Drawing.Size(85, 23);
            this.Uncheck.TabIndex = 6;
            this.Uncheck.Text = "Un-check all";
            this.Uncheck.Click += new System.EventHandler(this.Uncheck_Click);
            // 
            // RemoveFile
            // 
            this.RemoveFile.BackgroundImage = global::Injector.Properties.Resources.RemoveFile;
            this.RemoveFile.Location = new System.Drawing.Point(149, 3);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(30, 40);
            this.RemoveFile.TabIndex = 5;
            this.RemoveFile.TabStop = false;
            this.RemoveFile.Visible = false;
            this.RemoveFile.Click += new System.EventHandler(this.RemoveFile_Click);
            // 
            // AddFolder
            // 
            this.AddFolder.BackgroundImage = global::Injector.Properties.Resources.AddFolder;
            this.AddFolder.Location = new System.Drawing.Point(39, 3);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(30, 40);
            this.AddFolder.TabIndex = 4;
            this.AddFolder.TabStop = false;
            this.AddFolder.Click += new System.EventHandler(this.AddF_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenFile.BackgroundImage")));
            this.OpenFile.Location = new System.Drawing.Point(3, 3);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(30, 40);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.TabStop = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // FileList
            // 
            this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(3, 54);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(176, 137);
            this.FileList.TabIndex = 2;
            this.FileList.SelectedIndexChanged += new System.EventHandler(this.FileList_SelectedIndexChanged);
            // 
            // Cheats
            // 
            this.Cheats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Cheats.Controls.Add(this.OpenFolder);
            this.Cheats.Controls.Add(this.QuickInject);
            this.Cheats.Controls.Add(this.DownloadFile);
            this.Cheats.Controls.Add(this.updateDlls);
            this.Cheats.Controls.Add(this.label3);
            this.Cheats.Controls.Add(this.Downloads);
            this.Cheats.Controls.Add(this.Owned);
            this.Cheats.Controls.Add(this.label2);
            this.Cheats.Location = new System.Drawing.Point(4, 25);
            this.Cheats.Name = "Cheats";
            this.Cheats.Padding = new System.Windows.Forms.Padding(3);
            this.Cheats.Size = new System.Drawing.Size(467, 224);
            this.Cheats.TabIndex = 1;
            this.Cheats.Text = "Cheats/Downloads";
            // 
            // OpenFolder
            // 
            this.OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpenFolder.Border = true;
            this.OpenFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OpenFolder.BorderThickness = 1F;
            this.OpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.OpenFolder.Location = new System.Drawing.Point(6, 195);
            this.OpenFolder.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.OpenFolder.Size = new System.Drawing.Size(225, 23);
            this.OpenFolder.TabIndex = 7;
            this.OpenFolder.Text = "Open DLL folder";
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // QuickInject
            // 
            this.QuickInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.QuickInject.Border = true;
            this.QuickInject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.QuickInject.BorderThickness = 1F;
            this.QuickInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.QuickInject.Location = new System.Drawing.Point(6, 166);
            this.QuickInject.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.QuickInject.Name = "QuickInject";
            this.QuickInject.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.QuickInject.Size = new System.Drawing.Size(225, 23);
            this.QuickInject.TabIndex = 6;
            this.QuickInject.Text = "Add selection to injection list";
            this.QuickInject.Click += new System.EventHandler(this.QuickInject_Click);
            // 
            // DownloadFile
            // 
            this.DownloadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DownloadFile.Border = true;
            this.DownloadFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DownloadFile.BorderThickness = 1F;
            this.DownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DownloadFile.Location = new System.Drawing.Point(236, 166);
            this.DownloadFile.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.DownloadFile.Size = new System.Drawing.Size(225, 23);
            this.DownloadFile.TabIndex = 5;
            this.DownloadFile.Text = "Download selected file";
            this.DownloadFile.Click += new System.EventHandler(this.DownloadFile_Click);
            // 
            // updateDlls
            // 
            this.updateDlls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.updateDlls.Border = true;
            this.updateDlls.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.updateDlls.BorderThickness = 1F;
            this.updateDlls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.updateDlls.Location = new System.Drawing.Point(236, 195);
            this.updateDlls.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.updateDlls.Name = "updateDlls";
            this.updateDlls.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.updateDlls.Size = new System.Drawing.Size(225, 23);
            this.updateDlls.TabIndex = 4;
            this.updateDlls.Text = "Update list";
            this.updateDlls.Click += new System.EventHandler(this.updateDlls_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Downloads";
            // 
            // Downloads
            // 
            this.Downloads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Downloads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Downloads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Downloads.FormattingEnabled = true;
            this.Downloads.Location = new System.Drawing.Point(236, 21);
            this.Downloads.Name = "Downloads";
            this.Downloads.Size = new System.Drawing.Size(225, 145);
            this.Downloads.TabIndex = 2;
            this.Downloads.DoubleClick += new System.EventHandler(this.DownloadFile_Click);
            // 
            // Owned
            // 
            this.Owned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Owned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Owned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Owned.FormattingEnabled = true;
            this.Owned.Location = new System.Drawing.Point(6, 21);
            this.Owned.Name = "Owned";
            this.Owned.Size = new System.Drawing.Size(225, 145);
            this.Owned.TabIndex = 1;
            this.Owned.DoubleClick += new System.EventHandler(this.QuickInject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DLLs found";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(499, 300);
            this.ControlBox = false;
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.TopPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Injector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.Injector.ResumeLayout(false);
            this.Injector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenFile)).EndInit();
            this.Cheats.ResumeLayout(false);
            this.Cheats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Title;
        public System.Windows.Forms.TextBox ProcessName;
        private Custom_GUI.FlatButton Exit;
        private System.Windows.Forms.CheckBox CloseAfterInject;
        private Custom_GUI.FlatButton HideWin;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TrayInject;
        private System.Windows.Forms.ToolStripMenuItem TrayInjectExit;
        private System.Windows.Forms.ToolStripMenuItem TrayOpen;
        private System.Windows.Forms.ToolStripMenuItem TrayClose;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Custom_GUI.TabControl MainTabs;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.TabPage Cheats;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Owned;
        private System.Windows.Forms.ListBox Downloads;
        private System.Windows.Forms.Label label3;
        private Custom_GUI.FlatButton updateDlls;
        private System.Windows.Forms.CheckBox MsgAfterInject;
        private Custom_GUI.FlatButton DownloadFile;
        private Custom_GUI.FlatButton QuickInject;
        private Custom_GUI.FlatButton OpenFolder;
        private System.Windows.Forms.TabPage Injector;
        private System.Windows.Forms.CheckedListBox FileList;
        private System.Windows.Forms.PictureBox OpenFile;
        private System.Windows.Forms.PictureBox AddFolder;
        private System.Windows.Forms.PictureBox RemoveFile;
        private Custom_GUI.FlatButton CheckAll;
        private Custom_GUI.FlatButton Uncheck;
        private Custom_GUI.FlatButton Inject;
        private System.Windows.Forms.Label nVersion_label;
        private System.Windows.Forms.Label cVersion_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel DiscordLink;
        private System.Windows.Forms.PictureBox SelectProc;
        private System.Windows.Forms.Label ripLavi;
    }
}

