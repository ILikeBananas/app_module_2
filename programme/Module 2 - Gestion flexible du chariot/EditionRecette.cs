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
        private List<Recette> ListRecette = new List<Recette>();
        private List<Operation> ListOperation = new List<Operation>();
        private bool UnSavedChanges = false;


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
            
            Debug.WriteLine("cell " + ListRecette.ElementAt(e.RowIndex).Nom);

            
        }

        private void SetupLayout()
        {
            this.Size = new Size(600, 500);
            
        }

        private void SetupDataGridView()
        {
            //For the recette selection (left datagridview)
            dataGridView1.ColumnCount = 2;
            dataGridView1.Name = "Recette selection";
            dataGridView1.Location = new Point(8, 8);
            dataGridView1.Size = new Size(250, 400);
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nom";

            dataGridView1.ReadOnly = true;

            ListRecette = Program.manager.GetAllRecette();
            Recette[] recettes = ListRecette.ToArray();

            for (int i = 0; i < recettes.Length; i++)
            {
                string[] row = { recettes[i].ID.ToString(), recettes[i].Nom };
                dataGridView1.Rows.Add(row);
            }

            // for the right one
            dataGridView2.ColumnCount = 4;
            dataGridView2.Name = "Edition recette";
            dataGridView2.Location = new Point(dataGridView1.Location.X + dataGridView1.Size.Width + 8, dataGridView1.Location.Y);
            dataGridView2.Size = new Size(525, 400);

            dataGridView2.Columns[0].Name = "Numero";
            dataGridView2.Columns[0].Width = 50;

            dataGridView2.Columns[1].Name = "Position";
            dataGridView2.Columns[1].Width = 50;

            dataGridView2.Columns[2].Name = "Temps en secondes";
            dataGridView2.Columns[2].Width = 70;

            dataGridView2.Columns[3].Name = "Description";
            dataGridView2.Columns[3].Width = 250;

            List<string> AvecSans = new List<string>();
            AvecSans.Add("Avec");
            AvecSans.Add("Sans");
            dataGridView2.Columns.Add(new DataGridViewComboBoxColumn
            {
                DataSource = AvecSans,
                HeaderText = "Quittance",
            });

            dataGridView2.Columns[4].Name = "Quittance";
            dataGridView2.Columns[4].Width = 60;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 1)
            {
                Debug.Write("to long selection");
                string message = "Veuillez selectionner seulement une case";
                string caption = "Multiples cellules selectionnées";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = ListRecette[rowIndex].ID;

                if (UnSavedChanges)
                {
                    // to do popup asking to save
                }
                else
                {
                    ListOperation = Program.manager.GetAllOperByRecID(id);
                    Operation[] operations = ListOperation.ToArray();
                    dataGridView2.Rows.Clear();

                    for (int i = 0; i < operations.Length; i++)
                    {
                        string description = "";
                        if (operations[i].Description != null)
                        {
                            description = operations[i].Description.ToString();
                        }

                        string[] row = { operations[i].Numero.ToString(),
                                     operations[i].Position.ToString(),
                                     operations[i].Temps.ToString(),
                                     description,
                                     operations[i].Quittance ? "Avec" : "Sans",
                                     };

                        dataGridView2.Rows.Add(row);
                    }
                }
            }
        }
    }
}
