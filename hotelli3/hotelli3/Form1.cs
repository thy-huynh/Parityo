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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KirjauduBT_Click(object sender, EventArgs e)
        {
            Yhdista tietokantaan = new Yhdista();

            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            String kysely = "SELECT kayttajanimi, salasana FROM asiakkaat WHERE kayttajanimi = @kn AND Salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = tietokantaan.OtaYhteys();

            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = KayttajaTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = SalaTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if(taulu.Rows.Count > 0 ) 
            {
                this.Hide();
                Form2 plomake = new Form2();
                plomake.Show();
            }
            else 
            {
                if(KayttajaTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Syötä käyttäjänimi kirjautuaksesi");
                }
                else if (SalaTB.Text.Trim().Equals("")) 
                {
                    MessageBox.Show("Syötä salasana kirjautuaksesi");
                }
                else 
                {
                    MessageBox.Show("Käyttäjänimeä tai salasanaa ei löydy");

                }
            }
        }
    }
}
