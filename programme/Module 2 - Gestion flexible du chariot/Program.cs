using System;
using System.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Module_2___Gestion_flexible_du_chariot
{
    static class Program
    {
        static public DBManager manager;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string host = "localhost";
            string databaseName = "johrbil_chariot";
            string userName = "root";
            string password = "";

            // Testes BD
            manager = new DBManager(host, databaseName, userName, password);
            Lot lot = manager.GetLotByID(2);
            Operation operation = manager.GetOperationByID(1);
            Evenement evenement = manager.GetEvenementByID(1);
            Status status = manager.GetStatusByID(1);
            Recette recette = manager.GetRecetteByID(1);

            Debug.WriteLine(lot.Nom + "" + operation.Description + " " + evenement.Nom + " " + status.Etat + " " + recette.Nom);


            Debug.WriteLine(lot.Nom, "DBManager");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());


            //OdbcConnection odb = new OdbcConnection( return { MySQL ODBC 5.1 Driver }; Server = "localost"; Database = "test"; uid = root; pwd = ""; Option = 3;);
                
        }

    }
}
