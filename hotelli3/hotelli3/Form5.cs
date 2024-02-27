using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotelli3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        HUONE huone = new HUONE();

        private void Form5_Load(object sender, EventArgs e) 
        {
            HuoneTCB.DataSource = huone.huonetyyppilista();
            HuoneTCB.DisplayMember = "Huonetyyppi";
            HuoneTCB.ValueMember = "KategoriaId";

            HuoneDG.DataSource = huone.haeHuoneet();
        }

        private void LisaaUBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HuoneNTB.Text);
            int tyyppi = Convert.ToInt32(HuoneTCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            
            if(huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneDG.DataSource = huone.haeHuoneet();
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HuoneTCB.SelectedValue.ToString());
            String puhelin = PuhelinTB.Text;
            String vapaa = "";

            try 
            {
                int numero = Convert.ToInt32(HuoneNTB.Text);
                if (KyllaRB.Checked) 
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if(huone.muokkaaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, " Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneDG.DataSource = huone.haeHuoneet();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HuoneNTB.Text;
                if(huone.poistaHuone(huonenro))
                {
                    HuoneDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaBT.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            HuoneNTB.Text = "";
            HuoneTCB.SelectedIndex = 0;
            PuhelinTB.Text = "";
        }

        private void HuoneDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HuoneNTB.Text = HuoneDG.CurrentRow.Cells[0].Value.ToString();
            HuoneTCB.SelectedValue = HuoneDG.CurrentRow.Cells[1].Value.ToString();
            PuhelinTB.Text = HuoneDG.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
