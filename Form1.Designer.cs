namespace CAROGAME
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playername = new System.Windows.Forms.TextBox();
            this.countdown = new System.Windows.Forms.ProgressBar();
            this.picturematch = new System.Windows.Forms.PictureBox();
            this.logocarogame = new System.Windows.Forms.Panel();
            this.panelchessboard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playername
            // 
            this.playername.BackColor = System.Drawing.SystemColors.Window;
            this.playername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playername.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playername.Location = new System.Drawing.Point(680, 209);
            this.playername.Name = "playername";
            this.playername.ReadOnly = true;
            this.playername.Size = new System.Drawing.Size(167, 46);
            this.playername.TabIndex = 0;
            this.playername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.SystemColors.Control;
            this.countdown.Location = new System.Drawing.Point(390, 34);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(156, 55);
            this.countdown.TabIndex = 0;
            // 
            // picturematch
            // 
            this.picturematch.BackColor = System.Drawing.Color.Transparent;
            this.picturematch.BackgroundImage = global::CAROGAME.Properties.Resources.mark_background;
            this.picturematch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturematch.ErrorImage = null;
            this.picturematch.InitialImage = null;
            this.picturematch.Location = new System.Drawing.Point(680, 40);
            this.picturematch.Name = "picturematch";
            this.picturematch.Size = new System.Drawing.Size(167, 153);
            this.picturematch.TabIndex = 0;
            this.picturematch.TabStop = false;
            // 
            // logocarogame
            // 
            this.logocarogame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logocarogame.BackColor = System.Drawing.Color.Transparent;
            this.logocarogame.BackgroundImage = global::CAROGAME.Properties.Resources.caro_game_logo;
            this.logocarogame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logocarogame.Location = new System.Drawing.Point(87, 95);
            this.logocarogame.Name = "logocarogame";
            this.logocarogame.Size = new System.Drawing.Size(134, 143);
            this.logocarogame.TabIndex = 1;
            // 
            // panelchessboard
            // 
            this.panelchessboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelchessboard.BackColor = System.Drawing.Color.Transparent;
            this.panelchessboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelchessboard.Location = new System.Drawing.Point(316, 95);
            this.panelchessboard.Name = "panelchessboard";
            this.panelchessboard.Size = new System.Drawing.Size(295, 289);
            this.panelchessboard.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGAMEToolStripMenuItem,
            this.uNDOToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.mENUToolStripMenuItem.Text = "Setting";
            // 
            // nEWGAMEToolStripMenuItem
            // 
            this.nEWGAMEToolStripMenuItem.Name = "nEWGAMEToolStripMenuItem";
            this.nEWGAMEToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.nEWGAMEToolStripMenuItem.Text = "NEW GAME";
            this.nEWGAMEToolStripMenuItem.Click += new System.EventHandler(this.nEWGAMEToolStripMenuItem_Click);
            // 
            // uNDOToolStripMenuItem
            // 
            this.uNDOToolStripMenuItem.Name = "uNDOToolStripMenuItem";
            this.uNDOToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.uNDOToolStripMenuItem.Text = "UNDO";
            this.uNDOToolStripMenuItem.Click += new System.EventHandler(this.uNDOToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CAROGAME.Properties.Resources.background_board1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 476);
            this.Controls.Add(this.panelchessboard);
            this.Controls.Add(this.playername);
            this.Controls.Add(this.picturematch);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.logocarogame);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CARO GAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picturematch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel logocarogame;
        private System.Windows.Forms.TextBox playername;
        private System.Windows.Forms.ProgressBar countdown;
        private System.Windows.Forms.PictureBox picturematch;
        private System.Windows.Forms.Panel panelchessboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.Timer tmCountDown;
    }
}

