namespace hotelli3
{
    partial class AsiakkaidenHallintaForm
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
            this.EnimiLB = new System.Windows.Forms.Label();
            this.SnimiLB = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostiNLB = new System.Windows.Forms.Label();
            this.PostiTpLB = new System.Windows.Forms.Label();
            this.KtunnusLB = new System.Windows.Forms.Label();
            this.SalaLB = new System.Windows.Forms.Label();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.OsoiteTB = new System.Windows.Forms.TextBox();
            this.PostiNTB = new System.Windows.Forms.TextBox();
            this.PostitoimiTB = new System.Windows.Forms.TextBox();
            this.KtunnusTB = new System.Windows.Forms.TextBox();
            this.SalaTB = new System.Windows.Forms.TextBox();
            this.asiakasBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakkaiden hallinta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 330);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EnimiLB
            // 
            this.EnimiLB.AutoSize = true;
            this.EnimiLB.Location = new System.Drawing.Point(22, 108);
            this.EnimiLB.Name = "EnimiLB";
            this.EnimiLB.Size = new System.Drawing.Size(44, 13);
            this.EnimiLB.TabIndex = 2;
            this.EnimiLB.Text = "Etunimi:";
            // 
            // SnimiLB
            // 
            this.SnimiLB.AutoSize = true;
            this.SnimiLB.Location = new System.Drawing.Point(22, 150);
            this.SnimiLB.Name = "SnimiLB";
            this.SnimiLB.Size = new System.Drawing.Size(53, 13);
            this.SnimiLB.TabIndex = 3;
            this.SnimiLB.Text = "Sukunimi:";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(22, 192);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(58, 13);
            this.OsoiteLB.TabIndex = 4;
            this.OsoiteLB.Text = "Lähiosoite:";
            // 
            // PostiNLB
            // 
            this.PostiNLB.AutoSize = true;
            this.PostiNLB.Location = new System.Drawing.Point(22, 234);
            this.PostiNLB.Name = "PostiNLB";
            this.PostiNLB.Size = new System.Drawing.Size(68, 13);
            this.PostiNLB.TabIndex = 5;
            this.PostiNLB.Text = "Postinumero:";
            // 
            // PostiTpLB
            // 
            this.PostiTpLB.AutoSize = true;
            this.PostiTpLB.Location = new System.Drawing.Point(22, 276);
            this.PostiTpLB.Name = "PostiTpLB";
            this.PostiTpLB.Size = new System.Drawing.Size(86, 13);
            this.PostiTpLB.TabIndex = 6;
            this.PostiTpLB.Text = "Postitoimipaikka:";
            // 
            // KtunnusLB
            // 
            this.KtunnusLB.AutoSize = true;
            this.KtunnusLB.Location = new System.Drawing.Point(22, 318);
            this.KtunnusLB.Name = "KtunnusLB";
            this.KtunnusLB.Size = new System.Drawing.Size(80, 13);
            this.KtunnusLB.TabIndex = 7;
            this.KtunnusLB.Text = "Käyttäjätunnus:";
            // 
            // SalaLB
            // 
            this.SalaLB.AutoSize = true;
            this.SalaLB.Location = new System.Drawing.Point(22, 360);
            this.SalaLB.Name = "SalaLB";
            this.SalaLB.Size = new System.Drawing.Size(54, 13);
            this.SalaLB.TabIndex = 8;
            this.SalaLB.Text = "Salasana:";
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(182, 101);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(100, 20);
            this.EnimiTB.TabIndex = 9;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(182, 143);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(100, 20);
            this.SnimiTB.TabIndex = 10;
            // 
            // OsoiteTB
            // 
            this.OsoiteTB.Location = new System.Drawing.Point(182, 185);
            this.OsoiteTB.Name = "OsoiteTB";
            this.OsoiteTB.Size = new System.Drawing.Size(100, 20);
            this.OsoiteTB.TabIndex = 11;
            // 
            // PostiNTB
            // 
            this.PostiNTB.Location = new System.Drawing.Point(182, 227);
            this.PostiNTB.Name = "PostiNTB";
            this.PostiNTB.Size = new System.Drawing.Size(100, 20);
            this.PostiNTB.TabIndex = 12;
            // 
            // PostitoimiTB
            // 
            this.PostitoimiTB.Location = new System.Drawing.Point(182, 269);
            this.PostitoimiTB.Name = "PostitoimiTB";
            this.PostitoimiTB.Size = new System.Drawing.Size(100, 20);
            this.PostitoimiTB.TabIndex = 13;
            // 
            // KtunnusTB
            // 
            this.KtunnusTB.Location = new System.Drawing.Point(182, 311);
            this.KtunnusTB.Name = "KtunnusTB";
            this.KtunnusTB.Size = new System.Drawing.Size(100, 20);
            this.KtunnusTB.TabIndex = 14;
            // 
            // SalaTB
            // 
            this.SalaTB.Location = new System.Drawing.Point(182, 353);
            this.SalaTB.Name = "SalaTB";
            this.SalaTB.Size = new System.Drawing.Size(100, 20);
            this.SalaTB.TabIndex = 15;
            // 
            // asiakasBT
            // 
            this.asiakasBT.Location = new System.Drawing.Point(78, 409);
            this.asiakasBT.Name = "asiakasBT";
            this.asiakasBT.Size = new System.Drawing.Size(75, 37);
            this.asiakasBT.TabIndex = 16;
            this.asiakasBT.Text = "Lisää uusi \r\nasiakas";
            this.asiakasBT.UseVisualStyleBackColor = true;
            this.asiakasBT.Click += new System.EventHandler(this.asiakasBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.Location = new System.Drawing.Point(170, 409);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(75, 23);
            this.MuokkaaBT.TabIndex = 17;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = true;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.Location = new System.Drawing.Point(270, 409);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(75, 23);
            this.PoistaBT.TabIndex = 18;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = true;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(351, 409);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(85, 37);
            this.TyhjennaBT.TabIndex = 19;
            this.TyhjennaBT.Text = "Tyhjennä\r\nkentät";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // AsiakkaidenHallintaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.asiakasBT);
            this.Controls.Add(this.SalaTB);
            this.Controls.Add(this.KtunnusTB);
            this.Controls.Add(this.PostitoimiTB);
            this.Controls.Add(this.PostiNTB);
            this.Controls.Add(this.OsoiteTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.SalaLB);
            this.Controls.Add(this.KtunnusLB);
            this.Controls.Add(this.PostiTpLB);
            this.Controls.Add(this.PostiNLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.SnimiLB);
            this.Controls.Add(this.EnimiLB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "AsiakkaidenHallintaForm";
            this.Text = "AsiakkaidenHallinta";
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
        private System.Windows.Forms.Label EnimiLB;
        private System.Windows.Forms.Label SnimiLB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostiNLB;
        private System.Windows.Forms.Label PostiTpLB;
        private System.Windows.Forms.Label KtunnusLB;
        private System.Windows.Forms.Label SalaLB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox OsoiteTB;
        private System.Windows.Forms.TextBox PostiNTB;
        private System.Windows.Forms.TextBox PostitoimiTB;
        private System.Windows.Forms.TextBox KtunnusTB;
        private System.Windows.Forms.TextBox SalaTB;
        private System.Windows.Forms.Button asiakasBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
    }
}