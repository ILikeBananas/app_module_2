using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2___Gestion_flexible_du_chariot
{
    
    public partial class EditionRecette : Form
    {
        private List<Recette> ListeRecettes = new List<Recette>();


        public EditionRecette()
        {
            InitializeComponent();
        }

        private void EditionRecette_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("cell clicked : column :" + e.ColumnIndex + " row : " + e.RowIndex);
            
            Debug.WriteLine("cell " + ListeRecettes.ElementAt(e.RowIndex).Nom);
            
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);
            
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Name = "Recette selection";
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Size = new Size(250, 400);
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nom";


            ListeRecettes = Program.manager.GetAllRecette();
            Recette[] recettes = ListeRecettes.ToArray();
            
            for(int i = 0; i < recettes.Length; i++)
            {
                string[] row = { recettes[i].ID.ToString(), recettes[i].Nom };
                dataGridView1.Rows.Add(row);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
