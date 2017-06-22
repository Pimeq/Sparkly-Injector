namespace Injector
{
    partial class ProcessList
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Exit = new Custom_GUI.FlatButton();
            this.Title = new System.Windows.Forms.Label();
            this.ProcessDisplay = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopPanel.Controls.Add(this.Exit);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(448, 28);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Exit.Border = false;
            this.Exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Exit.BorderThickness = 2F;
            this.Exit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Exit.Location = new System.Drawing.Point(423, 0);
            this.Exit.MouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.Exit.Name = "Exit";
            this.Exit.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(25)))));
            this.Exit.Size = new System.Drawing.Size(26, 28);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, -4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(81, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "Processes";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // ProcessDisplay
            // 
            this.ProcessDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ProcessDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessDisplay.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ProcessDisplay.FormattingEnabled = true;
            this.ProcessDisplay.ItemHeight = 15;
            this.ProcessDisplay.Location = new System.Drawing.Point(12, 102);
            this.ProcessDisplay.Name = "ProcessDisplay";
            this.ProcessDisplay.Size = new System.Drawing.Size(426, 197);
            this.ProcessDisplay.TabIndex = 1;
            this.ProcessDisplay.DoubleClick += new System.EventHandler(this.ProcessDisplay_DoubleClick);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBar.Enabled = false;
            this.SearchBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SearchBar.Location = new System.Drawing.Point(12, 62);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(424, 20);
            this.SearchBar.TabIndex = 2;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search keyword:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broken because I can\'t code :(";
            // 
            // ProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(450, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.ProcessDisplay);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcessList";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProcessList_Paint);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox ProcessDisplay;
        private Custom_GUI.FlatButton Exit;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}