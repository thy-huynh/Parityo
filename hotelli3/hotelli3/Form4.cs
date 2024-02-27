using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelli3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        VARAUS varaus = new VARAUS();

        private void Form4_Load(object sender, EventArgs e)
        {
            HuoneCB.DataSource = huone.huonetyyppilista();
            HuoneCB.DisplayMember = "Huonetyyppi";
            HuoneCB.ValueMember = "KategotiaId";

            AsiakasNCB.DataSource = asiakas.asiakaslista();
            AsiakasNCB.DisplayMember = "Kokonimi";
            AsiakasNCB.ValueMember = "AsiakasID";
            VarauksetDG.DataSource = varaus.haeVaraukset();
        } 

        private void VarausUBT_Click(object sender, EventArgs e)
        {
            int asiakas = Convert.ToInt32(AsiakasNCB.SelectedValue.ToString());
            int huonenro = Convert.ToInt32(HuoneNCB.SelectedValue.ToString());
            DateTime sisaankirjautuminen = Convert.ToDateTime(SisaanDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(UlosDTP.Value);

            if(varaus.lisaaVaraus(huonenro, asiakas, sisaankirjautuminen, uloskirjautuminen))
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(huonenro.vaihdaHuoneenVapaus("Kyllä", huonenro))
                {
                    MessageBox.Show("Huoneen varaustila vaihdettu onnistuneesti");
                }
                else
                {
                    MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                }
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisäämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset;
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(HuoneNCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(AsiakasNCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(SisaanDTP.Value);
            DateTime ulos = Convert.ToDateTime(UlosDTP.Value);
            try
            {
                int vara = Convert.ToInt32(VarausTB.Text);

                if(varaus.muokkaaVarausta(huonenro, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Varaus muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(huonenro.vaihdaHuoneenVapaus("Ei", huonenro))
                    {
                        MessageBox.Show("Huoneen varaustilanne vaihdettu onnistuneesti");
                    }
                    else
                    {
                        MessageBox.Show("Huoneen varaustilannetta ei pystytty vaihtamaan");
                    }
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VarauksetDG.DataSource = varaus.haeVaraukset();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String varausnro = VarausTB.Text;
                int huonenro = HuoneNCB.SelectedIndex;

                if (varaus.poistaVaraus(varausnro))
                {
                    VarauksetDG.DataSource = varaus.haeVaraukset();
                    MessageBox.Show("Varaus poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    huonenro.vaihdaHuoneenVapaus("Ei", huonenro);
                }
                else 
                {
                    MessageBox.Show("Varaus ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                TyhjennaBT.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HuoneCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetype = HuoneCB.SelectedIndex + 1;

            HuoneNCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            HuoneNCB.DisplayMember = "HuoneenNro";
            HuoneNCB.ValueMember = "HuoneenNro";
        }

        private void VarauksetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VarausTB.Text = VarauksetDG.CurrentRow.Cells[0].Value.ToString();
            AsiakasNCB.SelectedValue = VarauksetDG.CurrentRow.Cells[2].Value.ToString();
            HuoneNCB.SelectedValue = VarauksetDG.CurrentRow.Cells[1].Value.ToString();
            SisaanDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[3].Value);
            UlosDTP.Value = Convert.ToDateTime(VarauksetDG.CurrentRow.Cells[4].Value);
        }
    }
}
