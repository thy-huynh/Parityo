namespace hotelli3
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VarausUBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.VarausTB = new System.Windows.Forms.TextBox();
            this.AsiakasNCB = new System.Windows.Forms.ComboBox();
            this.HuoneCB = new System.Windows.Forms.ComboBox();
            this.HuoneNCB = new System.Windows.Forms.ComboBox();
            this.SisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varaus nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asiakas nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huone tyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Huone nro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sisään:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ulos:";
            // 
            // VarausUBT
            // 
            this.VarausUBT.Location = new System.Drawing.Point(62, 373);
            this.VarausUBT.Name = "VarausUBT";
            this.VarausUBT.Size = new System.Drawing.Size(75, 38);
            this.VarausUBT.TabIndex = 8;
            this.VarausUBT.Text = "Lisää uusi \r\nvaraus";
            this.VarausUBT.UseVisualStyleBackColor = true;
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.Location = new System.Drawing.Point(166, 373);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.MuokkaaBT.TabIndex = 9;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = true;
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(280, 373);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(75, 23);
            this.PoistaBT.TabIndex = 10;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(386, 373);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(75, 38);
            this.TyhjennaBT.TabIndex = 11;
            this.TyhjennaBT.Text = "Tyhjennä \r\nkentät";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            // 
            // VarausTB
            // 
            this.VarausTB.Location = new System.Drawing.Point(223, 129);
            this.VarausTB.Name = "VarausTB";
            this.VarausTB.Size = new System.Drawing.Size(100, 20);
            this.VarausTB.TabIndex = 12;
            // 
            // AsiakasNCB
            // 
            this.AsiakasNCB.FormattingEnabled = true;
            this.AsiakasNCB.Location = new System.Drawing.Point(223, 164);
            this.AsiakasNCB.Name = "AsiakasNCB";
            this.AsiakasNCB.Size = new System.Drawing.Size(121, 21);
            this.AsiakasNCB.TabIndex = 13;
            // 
            // HuoneCB
            // 
            this.HuoneCB.FormattingEnabled = true;
            this.HuoneCB.Location = new System.Drawing.Point(223, 200);
            this.HuoneCB.Name = "HuoneCB";
            this.HuoneCB.Size = new System.Drawing.Size(121, 21);
            this.HuoneCB.TabIndex = 14;
            // 
            // HuoneNCB
            // 
            this.HuoneNCB.FormattingEnabled = true;
            this.HuoneNCB.Location = new System.Drawing.Point(223, 235);
            this.HuoneNCB.Name = "HuoneNCB";
            this.HuoneNCB.Size = new System.Drawing.Size(121, 21);
            this.HuoneNCB.TabIndex = 15;
            // 
            // SisaanDTP
            // 
            this.SisaanDTP.Location = new System.Drawing.Point(223, 274);
            this.SisaanDTP.Name = "SisaanDTP";
            this.SisaanDTP.Size = new System.Drawing.Size(200, 20);
            this.SisaanDTP.TabIndex = 16;
            // 
            // UlosDTP
            // 
            this.UlosDTP.Location = new System.Drawing.Point(223, 307);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(200, 20);
            this.UlosDTP.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisaanDTP);
            this.Controls.Add(this.HuoneNCB);
            this.Controls.Add(this.HuoneCB);
            this.Controls.Add(this.AsiakasNCB);
            this.Controls.Add(this.VarausTB);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.VarausUBT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button VarausUBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.TextBox VarausTB;
        private System.Windows.Forms.ComboBox AsiakasNCB;
        private System.Windows.Forms.ComboBox HuoneCB;
        private System.Windows.Forms.ComboBox HuoneNCB;
        private System.Windows.Forms.DateTimePicker SisaanDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
    }
}