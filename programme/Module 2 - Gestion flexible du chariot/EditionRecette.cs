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
        private List<Operation> ChangedValues = new List<Operation>();
        private int ActiveRecette = 0;


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

            dataGridView1.Columns[0].ReadOnly = true;


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

            ChangeActiveRecette(-1);
        }

        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifiy it's not the read only cell
            if(e.ColumnIndex == 1)
            {
                UnSavedChanges = true;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// Click of the "Charger" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Verify that only one cell is selected
            if(dataGridView1.SelectedCells.Count > 1)
            {
                string message = "Veuillez selectionner seulement une case";
                string caption = "Multiples cellules selectionnées";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = ListRecette[rowIndex].ID;
                bool save = false;
                bool cancel = false;

                // if unsaved changes exist, asks the user if he wants to save them
                if (UnSavedChanges)
                {
                    string message = "Il existe des changements non sauvegardés, voulez-vous les sauvegarder?";
                    string caption = "Sauvegarder?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result = MessageBox.Show(message, caption, buttons);
                    save = result == DialogResult.Yes;
                    cancel = result == DialogResult.Cancel;
                }
                
                // When saving is needed
                if(save) {
                    SaveChanges();
                }

                // Charging everything
                if(!cancel)
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

                    ChangeActiveRecette(id);
                }
            }
        }

        private void Sauvegarder_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("saving....");
            SaveChanges();
        }

        /// <summary>
        /// Called when a cell in the operation datagridview changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("values changed");
            UnSavedChanges = true;
            Operation changedValue;
            if(e.RowIndex < ListOperation.Count)
            {
                changedValue = ListOperation[e.RowIndex];
            } else
            {
                changedValue = new Operation();
            }
            
            string value = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            
            switch(e.ColumnIndex)
            {
                case 0:
                    changedValue.Numero = int.Parse(value);
                    break;

                case 1:
                    changedValue.Position = int.Parse(value);
                    break;

                case 2:
                    changedValue.Temps = int.Parse(value);
                    break;

                case 3:
                    changedValue.Description = value;
                    break;

                case 4:
                    changedValue.Quittance = value == "Avec";
                    break;
                
            }

            
            ChangedValues.Add(changedValue);
        }

        /// <summary>
        /// Saves all changes made to the operation datagridview
        /// </summary>
        private void SaveChanges()
        {
            if(UnSavedChanges)
            {
                for(int i = 0; i < ChangedValues.Count; i++)
                {
                    Program.manager.UpdateOperation(ChangedValues[i]);
                }

                DataGridViewRow dgvRow;
                for (int row = 0; row < ListRecette.Count; row++)
                {
                    dgvRow = dataGridView1.Rows[row];
                    if (int.Parse(dgvRow.Cells[0].Value.ToString()) == ActiveRecette && dgvRow.Cells[1].Value.ToString() != ListRecette[ActiveRecette - 1].Nom)
                    {
                        Debug.WriteLine("Updating recette name");
                        Program.manager.UpdateRecetteName(ListRecette[ActiveRecette - 1], dgvRow.Cells[1].Value.ToString());
                    }
                }
                

                UnSavedChanges = false;
                ChangedValues.Clear();
            }
        }

        /// <summary>
        /// Changes the active recette and sets all other recettes to read only
        /// </summary>
        /// <param name="id"></param>
        private void ChangeActiveRecette(int id)
        {
            for(int row = 0; row < ListRecette.Count; row++)
            {
                if(int.Parse(dataGridView1.Rows[row].Cells[0].Value.ToString()) != id)
                {
                    dataGridView1.Rows[row].Cells[1].ReadOnly = true;
                } else
                {
                    dataGridView1.Rows[row].Cells[1].ReadOnly = false;
                }
            }
            ActiveRecette = id;
        }

    }
}
