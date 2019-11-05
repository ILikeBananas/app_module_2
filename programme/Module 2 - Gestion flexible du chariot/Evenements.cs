using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Module_2___Gestion_flexible_du_chariot {
    public partial class Evenements : Form {

        List<Lot> ListeLots;

        public Evenements()
        {
            InitializeComponent();
        }

        /// <summary>
        /// After the loading, start ui setup 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Evenements_Load(object sender, EventArgs e)
        {
            SetupEventGrid();
            SetupComboBox();
            
        }

        /// <summary>
        /// Updates the grid containing the events 
        /// </summary>
        public void UpdateEventGrid()
        {
            // Before adding the events, clear the data grid view
            EventGrid.Rows.Clear();

            // Setting up the filter parameters for the database query
            EventFilterParameters filterParameters = new EventFilterParameters();
            filterParameters.UseDateFilter = useDateFilters.Checked;
            filterParameters.UseLotFilter = useLotFilters.Checked;

            if(filterParameters.UseDateFilter)
            {
                filterParameters.Start = timePickerDebut.Value;
                filterParameters.End = timePickerFin.Value;
            }

            if(filterParameters.UseLotFilter)
            {
                // If no lot is selected, continue without it
                if(comboLots.SelectedIndex == -1)
                {
                    filterParameters.UseLotFilter = false;
                } else
                {
                    filterParameters.LotID = ListeLots[comboLots.SelectedIndex].ID;
                }
            }

            // Use the filter parameters to only get the events we want to show
            List<Evenement> evenements = Program.manager.GetFilteredEvenements(filterParameters);
            for(int index = 0; index < evenements.Count; index++)
            {
                Lot lot = Program.manager.GetLotByID(evenements[index].LotID);
                EventGrid.Rows.Add(evenements[index].DateTime.ToString(),
                                   lot.Nom,
                                   evenements[index].Message
                                   );
            }
            

        }

        /// <summary>
        /// Setups all the 
        /// </summary>
        public void SetupEventGrid()
        {
            EventGrid.ColumnCount = 3;
            EventGrid.Name = "Affichage des événements";

            EventGrid.Columns[0].Name = "Date";
            EventGrid.Columns[0].Width = 120;

            EventGrid.Columns[1].Name = "Nom du lot";
            EventGrid.Columns[1].Width = 130;

            EventGrid.Columns[2].Name = "Message";
            EventGrid.Columns[2].Width = 205;

            UpdateEventGrid();

        }

        /// <summary>
        /// Fills the combobox with the lots
        /// </summary>
        public void SetupComboBox()
        {
            ListeLots = Program.manager.GetAllLots();
            for(int index = 0; index < ListeLots.Count; index++)
            {
                comboLots.Items.Add(ListeLots[index].Nom);
            }
        }

        /// <summary>
        /// Calls everything that has to be called when the update button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void update_Click(object sender, EventArgs e)
        {
            UpdateEventGrid();
        }
    }
}
