using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoTpFedi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeAuteur frm = new Form_ListeAuteur();
            frm.Show();
        }
    }
}
