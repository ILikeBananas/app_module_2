using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Module_2___Gestion_flexible_du_chariot
{
    /// <summary>
    /// Structure containing all infos about lots from the database
    /// </summary>
    public struct Lot
    {
        public int ID;
        public string Nom;
        public int NumeroRecette;
        public DateTime DateCreation;
        public DateTime DateButoir;
        public int Quantite;
        public int QuantiteAtteinte;
        public int RecetteID;
        public int StatusID;
    }

    public struct Evenement
    {
        public int ID;
        public string Nom;
        public DateTime DateTime;
    }

    public struct Operation
    {
        public int ID;
        public int Numero;
        public int Position;
        public int Temps;
        public string Description;
        public bool Quittance;
        public int RecetteID;
    }

    public struct Status
    {
        public int ID;
        public string Etat;
    }

    public struct Recette
    {
        public int ID;
        public string Nom;
    }


        
    class DBManager
    {
        static private MySqlConnection Conn;
        static private string Caller = "DBManager";

        private string Host = "";
        private string DatabaseName = "";
        private string UserName = "";
        private string Password = "";

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="host">host on wich the database is hosted</param>
        /// <param name="databaseName">name of the used database</param>
        /// <param name="userName">user name to access the database</param>
        /// <param name="password">password for the given user</param>
        public DBManager(string host,
                         string databaseName,
                         string userName,
                         string password)
        {
            Host = host;
            DatabaseName = databaseName;
            UserName = userName;
            Password = password;
        }

        public void CloseConnection()
        {
            Conn.Close();
            Debug.WriteLine(Caller, "Connection closed");
        }


        /// <summary>
        /// Connects to the database
        /// </summary>
        public void OpenConnection()
        {
            Debug.WriteLine(Caller, "Connecting to database");
            string connectionString = $"server={Host};" +
                                      $"database={DatabaseName};" +
                                      $"Uid={UserName};" +
                                      $"Pws={Password};";

            Conn = new MySqlConnection(connectionString);

            try
            {
                Conn.Open();
            } catch(MySqlException ex)
            {
                Debug.WriteLine(Caller, ex.Message);
            }

            Debug.WriteLine("Database connected");
        }

        /// <summary>
        /// Gets and returns the lot by the given id from the database
        /// </summary>
        /// <param name="id"></param>
        public Lot GetLotByID(int id)
        {
            string SQLString = string.Format("SELECT * FROM lot WHERE Lot_Numero = {0}", id);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            // Inserts the data in the structure
            Lot lot = new Lot();
            lot.ID = int.Parse(reader["Lot_Numero"].ToString());
            lot.Nom = reader["Lot_Nom"].ToString();
            lot.NumeroRecette = int.Parse(reader["Lot_NumeroRecette"].ToString());
            lot.DateCreation = DateTime.Parse(reader["Lot_DateCreation"].ToString());
            DateTime.TryParse(reader["Lot_DateButoir"].ToString(), out lot.DateButoir); // This one is by TryParse() because it can be empty
            lot.Quantite = int.Parse(reader["Lot_Quantite"].ToString());
            lot.QuantiteAtteinte = int.Parse(reader["Lot_QuantiteAtteinte"].ToString());
            lot.RecetteID = int.Parse(reader["Rct_Numero"].ToString());
            lot.StatusID = int.Parse(reader["Stu_ID"].ToString());

            CloseConnection();
            return lot;
        }
        
        /// <summary>
        /// Gets and returns the evenement by the given id from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Evenement GetEvenementByID(int ID)
        {

            string SQLString = string.Format("SELECT * FROM Evenement WHERE Eve_ID = {0}", ID);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Evenement evenement = new Evenement();

            evenement.ID = int.Parse(reader["Eve_ID"].ToString());
            evenement.Nom = reader["Eve_Message"].ToString();

            CloseConnection();

            return evenement;
        }

        /// <summary>
        /// Gets and returns the status by the given id from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Status GetStatusByID(int ID)
        {
            string SQLString = string.Format("SELECT * FROM Status WHERE Stu_ID = {0}", ID);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Status status = new Status();
            status.ID = int.Parse(reader["Stu_ID"].ToString());
            status.Etat = reader["Stu_Etat"].ToString();

            CloseConnection();
            return status;
        }

        /// <summary>
        /// Gets and returns the operation by the given id from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Operation GetOperationByID(int ID)
        {
            string SQLString = string.Format("SELECT * FROM Operation WHERE Opr_ID = {0}", ID);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Operation operation = new Operation();

            operation.ID = int.Parse(reader["Opr_ID"].ToString());
            operation.Numero = int.Parse(reader["Opr_Numero"].ToString());
            operation.Position = int.Parse(reader["Opr_Position"].ToString());
            operation.Quittance = bool.Parse(reader["Opr_Quittance"].ToString());
            operation.Description = reader["Opr_Description"].ToString();
            operation.Temps = int.Parse(reader["Opr_Temps"].ToString());
            operation.RecetteID = int.Parse(reader["Rct_Numero"].ToString());

            CloseConnection();

            return operation;
        }

        /// <summary>
        ///  Gets and returns the Recette by the given id from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Recette GetRecetteByID(int ID)
        {
            string SQLString = string.Format("SELECT * FROM Recette WHERE Rct_Numero = {0}", ID);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Recette recette = new Recette();

            recette.ID = int.Parse(reader["Rct_Numero"].ToString());
            recette.Nom = reader["Rct_Nom"].ToString();

            CloseConnection();

            return recette;
        }

        /// <summary>
        /// Returns the amount of lots
        /// </summary>
        /// <returns>Lots count as INT</returns>
        public int GetLotCount()
        {
            string SQLString = "SELECT COUNT(*) FROM lot";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int lotCount = int.Parse(reader["COUNT(*)"].ToString());

            CloseConnection();

            return lotCount;
        }

        /// <summary>
        /// Returns the amount of evenements
        /// </summary>
        /// <returns>evenemets count as int</returns>
        public int GetEvenementCount()
        {
            string SQLString = "SELECT COUNT(*) FROM evenement";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = int.Parse(reader["COUNT(*)"].ToString());

            CloseConnection();

            return count;
        }

        /// <summary>
        /// Returns the amount of status
        /// </summary>
        /// <returns>status count as int</returns>
        public int GetStatusCount()
        {
            string SQLString = "SELECT COUNT(*) FROM status";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = int.Parse(reader["COUNT(*)"].ToString());

            CloseConnection();

            return count;
        }

        /// <summary>
        /// Returns the amount of operation
        /// </summary>
        /// <returns>operation count as int</returns>
        public int GetOperationCount()
        {
            string SQLString = "SELECT COUNT(*) FROM operation";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = int.Parse(reader["COUNT(*)"].ToString());

            CloseConnection();

            return count;
        }

        /// <summary>
        /// Returns the amount of recette
        /// </summary>
        /// <returns>recette count as int</returns>
        public int GetRecetteCount()
        {
            string SQLString = "SELECT COUNT(*) FROM recette";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int count = int.Parse(reader["COUNT(*)"].ToString());

            CloseConnection();

            return count;
        }

        /// <summary>
        /// Returns all recettes
        /// </summary>
        /// <returns>List of recettes</returns>
        public List<Recette> GetAllRecette()
        {
            string SQLString = "SELECT * FROM recette";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();

            Recette recette;
            List<Recette> recettes = new List<Recette>();
            while (reader.Read())
            {
                recette.ID = int.Parse(reader["Rct_Numero"].ToString());
                recette.Nom = reader["Rct_Nom"].ToString();
                recettes.Add(recette);
            }

            CloseConnection();

            return recettes;
        }

        public List<Operation> GetAllOperByRecID(int recID)
        {
            string SQLString = string.Format("SELECT * FROM operation WHERE Rct_Numero = {0}", recID);

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();

            Operation operation = new Operation();
            List<Operation> operations = new List<Operation>();

            while (reader.Read())
            {
                operation.ID = int.Parse(reader["Opr_ID"].ToString());
                operation.Numero = int.Parse(reader["Opr_Numero"].ToString());
                operation.Position = int.Parse(reader["Opr_Position"].ToString());
                operation.Quittance = bool.Parse(reader["Opr_Quittance"].ToString());
                operation.Description = reader["Opr_Description"].ToString();
                operation.Temps = int.Parse(reader["Opr_Temps"].ToString());
                operation.RecetteID = int.Parse(reader["Rct_Numero"].ToString());

                operations.Add(operation);
            }

            CloseConnection();

            return operations;

        }

    }
}
