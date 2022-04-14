
namespace projekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MusicFiles = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.Previous = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.timeRemaining = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.Repeat = new System.Windows.Forms.Button();
            this.LRepeat = new System.Windows.Forms.Label();
            this.visuali = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visuali)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicFiles
            // 
            this.MusicFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MusicFiles.BackColor = System.Drawing.Color.LightCyan;
            this.MusicFiles.FormattingEnabled = true;
            this.MusicFiles.Location = new System.Drawing.Point(11, 38);
            this.MusicFiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MusicFiles.Name = "MusicFiles";
            this.MusicFiles.Size = new System.Drawing.Size(150, 511);
            this.MusicFiles.TabIndex = 0;
            this.MusicFiles.SelectedIndexChanged += new System.EventHandler(this.MusicFiles_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openToolStripMenuItem.Text = "Open folder with music";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrackBar.Location = new System.Drawing.Point(295, 504);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(506, 45);
            this.TrackBar.TabIndex = 2;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // Previous
            // 
            this.Previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Previous.Location = new System.Drawing.Point(328, 462);
            this.Previous.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(74, 23);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start.Location = new System.Drawing.Point(409, 463);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(74, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "Resume";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stop.Location = new System.Drawing.Point(490, 463);
            this.Stop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(74, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Pause";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Next
            // 
            this.Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Next.Location = new System.Drawing.Point(571, 463);
            this.Next.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(74, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // timeRemaining
            // 
            this.timeRemaining.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Location = new System.Drawing.Point(808, 504);
            this.timeRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(28, 13);
            this.timeRemaining.TabIndex = 7;
            this.timeRemaining.Text = "0:00";
            // 
            // currentTime
            // 
            this.currentTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(254, 504);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(22, 13);
            this.currentTime.TabIndex = 8;
            this.currentTime.Text = "0:0";
            // 
            // Repeat
            // 
            this.Repeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Repeat.Location = new System.Drawing.Point(652, 463);
            this.Repeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(74, 23);
            this.Repeat.TabIndex = 9;
            this.Repeat.Text = "Repeat";
            this.Repeat.UseVisualStyleBackColor = true;
            this.Repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // LRepeat
            // 
            this.LRepeat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LRepeat.AutoSize = true;
            this.LRepeat.Location = new System.Drawing.Point(733, 468);
            this.LRepeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LRepeat.Name = "LRepeat";
            this.LRepeat.Size = new System.Drawing.Size(72, 13);
            this.LRepeat.TabIndex = 10;
            this.LRepeat.Text = "Repeat is: Off";
            // 
            // visuali
            // 
            this.visuali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visuali.Enabled = true;
            this.visuali.Location = new System.Drawing.Point(257, 39);
            this.visuali.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.visuali.Name = "visuali";
            this.visuali.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("visuali.OcxState")));
            this.visuali.Size = new System.Drawing.Size(579, 405);
            this.visuali.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.visuali);
            this.Controls.Add(this.LRepeat);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.timeRemaining);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.MusicFiles);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Media Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visuali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MusicFiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Button Repeat;
        private System.Windows.Forms.Label LRepeat;
        private AxWMPLib.AxWindowsMediaPlayer visuali;
    }
}

