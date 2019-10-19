using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2___Gestion_flexible_du_chariot
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void AllerEditionRecettes_Click(object sender, EventArgs e)
        {
            Form frm = new EditionRecette();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();

        }

        private void AllerEditionLots_Click(object sender, EventArgs e)
        {
            Form frm = new EditionLots();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void AllerTracabiliteLots_Click(object sender, EventArgs e)
        {

        }

        private void AllerEvenements_Click(object sender, EventArgs e)
        {

        }
    }
}
