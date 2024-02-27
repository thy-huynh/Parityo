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
    public partial class AsiakkaidenHallintaForm : System.Windows.Forms.Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public AsiakkaidenHallintaForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) 
        {
            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }

        private void asiakasBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String osoite = OsoiteTB.Text;
            String pnro = PostiNTB.Text;
            String ppaikka = PostitoimiTB.Text;
            String ktunnus = KtunnusTB.Text;

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Täytä vaaditut kentät", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, ppaikka, ktunnus);
                if (muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MuokkaaBT_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String osoite = OsoiteTB.Text;
            String pnro = PostiNTB.Text;
            String ppaikka = PostitoimiTB.Text;
            String ktunnus = KtunnusTB.Text;

            if(enimi.Trim().Equals("") || snimi.Trim().Equals("") || osoite.Trim().Equals("") || pnro.Trim().Equals("") || ppaikka.Trim().Equals("")) 
            {
                MessageBox.Show("VIRHE - Täytä vaaditut kentät", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                Boolean muokkaaAsiakas = asiakas.muokkaaAsiakasta(enimi, snimi, osoite, ppaikka, ktunnus);
                if(muokkaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas päivitetty onnistuneesti", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty päivittämään", "Asiakkaan muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = KtunnusTB.Text;
            if (asiakasBT.poistaAsiakas(ktunnus)) 
            {
                dataGridView1.DataSource = asiakasBT.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu, onnistui", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Asiakas poistaminen epäonnistui", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            OsoiteTB.Text = "";
            PostiNTB.Text = "";
            PostitoimiTB.Text = "";
            KtunnusTB.Text = "";
            SalaTB.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnimiTB.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SnimiTB.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            OsoiteTB.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PostiNTB.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            PostitoimiTB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            KtunnusTB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
