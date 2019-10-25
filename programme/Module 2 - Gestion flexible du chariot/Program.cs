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
            // Database connection infos
            string host = "localhost";
            string databaseName = "johrbil_chariot";
            string userName = "root";
            string password = "";

            // Creates the manager
            manager = new DBManager(host, databaseName, userName, password);

            // Interface
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());   
        }
    }
}
