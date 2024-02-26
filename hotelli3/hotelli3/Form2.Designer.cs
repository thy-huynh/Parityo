namespace hotelli3
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hallitseAsiakkaitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseVarauksiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hallitseHuoneitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 365);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tervetuloa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hallitseAsiakkaitaToolStripMenuItem,
            this.hallitseVarauksiaToolStripMenuItem,
            this.hallitseHuoneitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hallitseAsiakkaitaToolStripMenuItem
            // 
            this.hallitseAsiakkaitaToolStripMenuItem.Name = "hallitseAsiakkaitaToolStripMenuItem";
            this.hallitseAsiakkaitaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.hallitseAsiakkaitaToolStripMenuItem.Text = "Hallitse asiakkaita";
            this.hallitseAsiakkaitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseAsiakkaitaToolStripMenuItem_Click);
            // 
            // hallitseVarauksiaToolStripMenuItem
            // 
            this.hallitseVarauksiaToolStripMenuItem.Name = "hallitseVarauksiaToolStripMenuItem";
            this.hallitseVarauksiaToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.hallitseVarauksiaToolStripMenuItem.Text = "Hallitse varauksia";
            this.hallitseVarauksiaToolStripMenuItem.Click += new System.EventHandler(this.hallitseVarauksiaToolStripMenuItem_Click);
            // 
            // hallitseHuoneitaToolStripMenuItem
            // 
            this.hallitseHuoneitaToolStripMenuItem.Name = "hallitseHuoneitaToolStripMenuItem";
            this.hallitseHuoneitaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.hallitseHuoneitaToolStripMenuItem.Text = "Hallitse huoneita";
            this.hallitseHuoneitaToolStripMenuItem.Click += new System.EventHandler(this.hallitseHuoneitaToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Pääikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hallitseAsiakkaitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseVarauksiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallitseHuoneitaToolStripMenuItem;
    }
}