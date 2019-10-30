using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2___Gestion_flexible_du_chariot {
    public partial class Tracabilite : Form {
        public Tracabilite()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load of the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tracabilite_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            // Loads the lots with no filters at the pages first load
            LotFilterParameters lotFilterParameters = new LotFilterParameters();
            lotFilterParameters.UseDateFilter = false;
            lotFilterParameters.StateFilter = StateFilterOptions.all;
            UpdateDataGrid(lotFilterParameters);
        }
        
        /// <summary>
        /// Updates the datagrid with the given filters 
        /// </summary>
        /// <param name="filterParameters"></param>
        private void UpdateDataGrid(LotFilterParameters filterParameters)
        {
            List<Lot> lots = Program.manager.GetFilteredLots(filterParameters);
            lotDataGrid.Rows.Clear();

            Recette recette = new Recette();
            for(int i = 0; i < lots.Count(); i++)
            {
                recette = Program.manager.GetRecetteByID(lots[i].RecetteID);
                string status = "";
                switch(lots[i].StatusID) {
                    case 1:
                        status = "Terminé";
                        break;

                    case 2:
                        status = "En Production";
                        break;

                    case 3:
                        status = "En attente";
                        break;

                    case 4:
                        status = "Ouvert";
                        break;
                }

                string[] row = { lots[i].Nom, lots[i].DateCreation.ToString(), lots[i].DateButoir.ToString(), lots[i].Quantite.ToString(), lots[i].QuantiteAtteinte.ToString(), recette.Nom, status };
                lotDataGrid.Rows.Add(row);
            }

        }

        /// <summary>
        /// Sets up the columns, columnn names and width for the data grid
        /// </summary>
        public void SetupDataGrid()
        {
            lotDataGrid.ColumnCount = 7;
            lotDataGrid.Name = "Affichage lots";

            // Columns
            lotDataGrid.Columns[0].Name = "Nom";
            lotDataGrid.Columns[0].Width = 100;

            lotDataGrid.Columns[1].Name = "Date création";
            lotDataGrid.Columns[1].Width = 120;

            lotDataGrid.Columns[2].Name = "Date butoir";
            lotDataGrid.Columns[2].Width = 120;

            lotDataGrid.Columns[3].Name = "Quantité";
            lotDataGrid.Columns[3].Width = 50;

            lotDataGrid.Columns[4].Name = "Quantité atteinte";
            lotDataGrid.Columns[4].Width = 50;

            lotDataGrid.Columns[5].Name = "Recette";
            lotDataGrid.Columns[5].Width = 120;

            lotDataGrid.Columns[6].Name = "Status";
            lotDataGrid.Columns[6].Width = 95;

            lotDataGrid.ReadOnly = true;

        }

        private void update_Click(object sender, EventArgs e)
        {
            LotFilterParameters lotFilterParameters = new LotFilterParameters();

            // Date filter
            lotFilterParameters.UseDateFilter = useDateFilters.Checked;
            lotFilterParameters.Start = timePickerDebut.Value;
            lotFilterParameters.End = timePickerFin.Value;

            if(radioDateButoir.Checked)
            {
                lotFilterParameters.DateFilterOptions = DateFilterOptions.dateButoir;
            } else
            {
                lotFilterParameters.DateFilterOptions = DateFilterOptions.dateCreation;
            }

            // State filter
            if(radioTermine.Checked)
            {
                lotFilterParameters.StateFilter = StateFilterOptions.finished;
            } else if(radioProduction.Checked)
            {
                lotFilterParameters.StateFilter = StateFilterOptions.inProduction;
            } else if(radioTous.Checked)
            {
                lotFilterParameters.StateFilter = StateFilterOptions.all;
            } else if(radioAttente.Checked)
            {
                lotFilterParameters.StateFilter = StateFilterOptions.waiting;
            }

            UpdateDataGrid(lotFilterParameters);

        }
    }
}
