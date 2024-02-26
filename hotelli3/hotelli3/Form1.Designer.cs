namespace hotelli3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalaTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 154);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 67);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KirjauduBT);
            this.groupBox1.Controls.Add(this.SalaTB);
            this.groupBox1.Controls.Add(this.KayttajaTB);
            this.groupBox1.Controls.Add(this.SalasanaLB);
            this.groupBox1.Controls.Add(this.KayttajaLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Location = new System.Drawing.Point(24, 36);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(48, 13);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjä:";
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(30, 102);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(54, 13);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(199, 41);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(100, 20);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalaTB
            // 
            this.SalaTB.Location = new System.Drawing.Point(211, 102);
            this.SalaTB.Name = "SalaTB";
            this.SalaTB.Size = new System.Drawing.Size(100, 20);
            this.SalaTB.TabIndex = 3;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Location = new System.Drawing.Point(133, 145);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(75, 23);
            this.KirjauduBT.TabIndex = 4;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjaudu sisään";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "KirjautumisIkkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.TextBox SalaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
    }
}

