using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2___Gestion_flexible_du_chariot
{
    public partial class EditionLots : Form
    {
        List<Recette> ListeRecette;

        public EditionLots()
        {
            InitializeComponent();
        }

        private void EditionLots_Load(object sender, EventArgs e)
        {
            ListeRecette = Program.manager.GetAllRecette();

            for(int i = 0; i < ListeRecette.Count(); i++)
            {
                RecetteBox.Items.Add(ListeRecette[i].Nom);
            }  
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Verify if the form is correctly filled
            bool filledCorrectly = true;
            string errorMessage = "";
            if(LotName.Text == "")
            {
                filledCorrectly = false;
                errorMessage += "Pas de nom du lot.\n";
            }

            int nbrePiece = 0;
            if (NbrePieces.Text == "")
            {
                filledCorrectly = false;
                errorMessage += "Pas de nombre de pièces.\n";
            } else if (!Int32.TryParse(NbrePieces.Text, out nbrePiece))
            {
                filledCorrectly = false;
                errorMessage += "Nombre de pièces invalide. (pas un nombre) \n";
            } else if (nbrePiece < 1)
            {
                filledCorrectly = false;
                errorMessage += "Nombre de pièces invalide ( < 0) \n";
            }


            if(RecetteBox.SelectedIndex == -1)
            {
                filledCorrectly = false;
                errorMessage += "Pas de recette séléctionnée. " + RecetteBox.SelectedIndex + " \n";
            }

            // Show the error messages
            ErrorMessage.Text = errorMessage;

            // If everything is correct, put it in the database
            if(filledCorrectly)
            {
                Lot lot = new Lot();

                lot.Nom = LotName.Text;
                lot.Quantite = Int32.Parse(NbrePieces.Text);
                lot.RecetteID = ListeRecette[RecetteBox.SelectedIndex].ID;
                lot.DateButoir = DateButoir.Value;

                Program.manager.CreateLot(lot);
            }
        }   
    }
}
