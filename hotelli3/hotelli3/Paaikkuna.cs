using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelli3
{
    public partial class PaaikkunaForm : System.Windows.Forms.Form
    {
        public PaaikkunaForm()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ahlomake = new Form3();
            ahlomake.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 vhlomake = new Form4();
            vhlomake.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 hhlomake = new Form5();
            hhlomake.ShowDialog();
        }
    }
}
