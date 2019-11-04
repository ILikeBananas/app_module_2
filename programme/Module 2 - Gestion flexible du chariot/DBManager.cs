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
        public string Message;
        public DateTime DateTime;
        public int LotID;
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

    public enum StateFilterOptions {
        all,
        finished,
        waiting,
        inProduction,
        open
    }

    public enum DateFilterOptions {
        dateCreation,
        dateButoir
    }
    public struct LotFilterParameters {
        public bool UseDateFilter;
        public DateTime Start;
        public DateTime End;
        public DateFilterOptions DateFilterOptions;
        public StateFilterOptions StateFilter;
    }

    public struct EventFilterParameters {
        public bool UseDateFilter;
        public DateTime Start;
        public DateTime End;
        public bool UseLotFilter;
        public int LotID;
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
                                      $"Password={Password};";

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
            evenement.Message = reader["Eve_Message"].ToString();
            evenement.DateTime = DateTime.Parse(reader["Eve_Date"].ToString());
            evenement.LotID = int.Parse(reader["Lot_Numero"].ToString());

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

        /// <summary>
        /// Returns a List of Operations by the given recette ID
        /// </summary>
        /// <param name="recID"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all the lots from the database
        /// </summary>
        /// <returns>List with all the lots from the database</returns>
        public List<Lot> GetAllLots()
        {
            string SQLString = "SELECT * FROM lot";

            OpenConnection();
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            MySqlDataReader reader = cmd.ExecuteReader();

            Lot lot = new Lot();
            List<Lot> lots = new List<Lot>();

            while(reader.Read())
            {
                lot.ID = int.Parse(reader["Lot_Numero"].ToString());
                lot.Nom = reader["Lot_Nom"].ToString();
                lot.DateCreation = DateTime.Parse(reader["Lot_DateCreation"].ToString());
                lot.DateButoir = DateTime.Parse(reader["Lot_DateButoir"].ToString());
                lot.Quantite = int.Parse(reader["Lot_Quantite"].ToString());
                lot.QuantiteAtteinte = int.Parse(reader["Lot_QuantiteAtteinte"].ToString());
                lot.RecetteID = int.Parse(reader["Rct_Numero"].ToString());
                lot.StatusID = int.Parse(reader["Stu_ID"].ToString());

                lots.Add(lot);
            }

            return lots;
        }

        /// <summary>
        /// Update in the database the operation
        /// </summary>
        /// <param name="operation">Operation to update</param>
        /// <param name="ListOperation">Old operation list</param>
        public void UpdateOperation(Operation operation)
        {
            
            bool operationExists = operation.ID != 0;

            OpenConnection();
            // Preparing the statement
            string SQLString = "";

            if (operationExists)
            {
                SQLString = "UPDATE operation SET Opr_Numero = @val1, Opr_Position = @val2, Opr_Temps = @val3, Opr_Description = @val4, Opr_Quittance = @val5 WHERE Opr_ID = @val6";
            } else
            {
                SQLString = "INSERT INTO operation (Opr_Numero, Opr_Position, Opr_Temps, Opr_Description, Opr_Quittance, RCT_Numero) VALUES (@val1, @val2, @val3, @val4, @val5, @val7)";
            }
            
            
            
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;
            cmd.Parameters.AddWithValue("@val1", operation.Numero);
            cmd.Parameters.AddWithValue("@val2", operation.Position);
            cmd.Parameters.AddWithValue("@val3", operation.Temps);
            cmd.Parameters.AddWithValue("@val4", operation.Description);
            cmd.Parameters.AddWithValue("@val5", operation.Quittance);

            // This value only exists if it's not a new operation
            if (operationExists)
            {
                cmd.Parameters.AddWithValue("@val6", operation.ID);
            } else
            {
                // if the operation doesnt exist, @val7 contains the RCT_Numero
                cmd.Parameters.AddWithValue("@val7", operation.RecetteID);
            }
            
            cmd.Prepare();

            cmd.ExecuteReader();

            CloseConnection();

        }

        /// <summary>
        /// Updates the name of the recette
        /// </summary>
        /// <param name="recette">The recette to change</param>
        /// <param name="name">New name for the recette</param>
        public void UpdateRecetteName(Recette recette, string name)
        {
            OpenConnection();

            // Preparing the statement
            string SQLString = "UPDATE recette SET Rct_Nom = @val1 WHERE Rct_Numero = @val2";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;
            cmd.Parameters.AddWithValue("@val1", name);
            cmd.Parameters.AddWithValue("@val2", recette.ID);
            cmd.Prepare();

            cmd.ExecuteReader();

            CloseConnection();
        }

        /// <summary>
        /// Creates a new lot in the database
        /// </summary>
        /// <param name="lot">The lot to add</param>
        public void CreateLot(Lot lot)
        {
            OpenConnection();

            // Preparing the statement
            string SQLString = "INSERT INTO lot (Lot_Nom, Lot_DateCreation, Lot_DateButoir, Lot_Quantite, Lot_QuantiteAtteinte, Rct_Numero, Stu_ID) " +
                               "VALUES (@Lot_Nom, @Lot_DateCreation, @Lot_DateButoir, @Lot_Quantite, @Lot_QuantiteAtteinte, @Rct_Numero, @Stu_ID)";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            // Transform the dates into a mysql DateTime compatible string
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string dateButoir = lot.DateButoir.ToString("yyyy-MM-dd HH:mm:ss");

            cmd.Parameters.AddWithValue("@Lot_Nom", lot.Nom);
            cmd.Parameters.AddWithValue("@Lot_DateCreation", dateNow);
            cmd.Parameters.AddWithValue("@Lot_DateButoir", dateButoir);
            cmd.Parameters.AddWithValue("@Lot_Quantite", lot.Quantite);
            cmd.Parameters.AddWithValue("@Lot_QuantiteAtteinte", 0);
            cmd.Parameters.AddWithValue("@Rct_Numero", lot.RecetteID);
            cmd.Parameters.AddWithValue("@Stu_ID", 3); // ID en attente

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Creates a new recette in the database
        /// </summary>
        /// <param name="recette">Recette to add</param>
        public void CreateRecette(Recette recette)
        {
            OpenConnection();

            // Preparing the statement
            string SQLString = "INSERT INTO recette (Rct_Nom) VALUES (@Rct_Nom)";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            cmd.Parameters.AddWithValue("@Rct_Nom", recette.Nom);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        /// <summary>
        /// Verifies in the database if the given Recette is in use in an already started lot
        /// </summary>
        /// <param name="recette"></param>
        /// <returns></returns>
        public bool IsRecetteInUse(Recette recette)
        {
            bool isInUse = false;
            OpenConnection();

            string SQLString = "SELECT Count(*) FROM `lot` WHERE Stu_ID = 1 AND Rct_Numero = @Rct_Numero OR Stu_ID = 2 AND Rct_Numero = @Rct_Numero";
            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            cmd.Parameters.AddWithValue("@Rct_Numero", recette.ID);

            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            if(reader.Read()) {
                string test = reader["Count(*)"].ToString();
                isInUse = reader["Count(*)"].ToString() != "0";
            }

            return isInUse;
        }

        /// <summary>
        /// Get all lots with the given filters
        /// </summary>
        /// <param name="filterParameters">(see struct) all parameters to apply on the query</param>
        public List<Lot> GetFilteredLots(LotFilterParameters filterParameters)
        {
            OpenConnection();

            string SQLString = "SELECT * FROM lot WHERE "; // String used to compose the SQL command
            string dateStart = "";
            string dateEnd = "";

            // If date filters are used, add them to the command
            if(filterParameters.UseDateFilter) {
                string column = "";
                if(filterParameters.DateFilterOptions == DateFilterOptions.dateButoir)
                {
                    column = "Lot_DateButoir";
                } else
                {
                    column = "Lot_DateCreation";
                }
                SQLString += column + " > STR_TO_DATE(@DateStart, '%Y-%m-%d %H:%i:%s') AND " + column + " < STR_TO_DATE(@DateEnd, '%Y-%m-%d %H:%i:%s') AND ";

                dateStart = filterParameters.Start.ToString("yyyy-MM-dd HH:mm:ss");
                dateEnd = filterParameters.End.ToString("yyyy-MM-dd HH:mm:ss");
            }

            // Add the state filters to the command
            switch(filterParameters.StateFilter) {
                case StateFilterOptions.all:
                    SQLString += "1 = 1";
                    break;

                case StateFilterOptions.finished:
                    SQLString += "Stu_ID = 1";
                    break;

                case StateFilterOptions.inProduction:
                    SQLString += "Stu_ID = 2";
                    break;

                case StateFilterOptions.waiting:
                    SQLString += "Stu_ID = 3";
                    break;

                case StateFilterOptions.open:
                    SQLString += "Stu_ID = 4";
                    break;

            }

            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;
            Debug.WriteLine(SQLString);
            Debug.WriteLine(dateStart + " " + dateEnd);
            // If date filters are used, add the parameters with values
            if(filterParameters.UseDateFilter)
            {
                cmd.Parameters.AddWithValue("@DateStart", dateStart);
                cmd.Parameters.AddWithValue("@DateEnd", dateEnd);
            }
            Debug.WriteLine(cmd.CommandText);
            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Lot> lots = new List<Lot>();
            Lot lot = new Lot();
            while(reader.Read())
            {
                lot.ID = int.Parse(reader["Lot_Numero"].ToString());
                lot.Nom = reader["Lot_Nom"].ToString();
                lot.DateCreation = DateTime.Parse(reader["Lot_DateCreation"].ToString());
                DateTime.TryParse(reader["Lot_DateButoir"].ToString(), out lot.DateButoir); // This one is by TryParse() because it can be empty
                lot.Quantite = int.Parse(reader["Lot_Quantite"].ToString());
                lot.QuantiteAtteinte = int.Parse(reader["Lot_QuantiteAtteinte"].ToString());
                lot.RecetteID = int.Parse(reader["Rct_Numero"].ToString());
                lot.StatusID = int.Parse(reader["Stu_ID"].ToString());

                lots.Add(lot);
            }

            CloseConnection();
            return lots;
        }

        

    public List<Evenement> GetFilteredEvenements(EventFilterParameters filterParameters)
        {
            Debug.WriteLine(filterParameters.LotID);
            OpenConnection();

            string SQLString = "SELECT * FROM evenement WHERE ";

            string dateStart = "";
            string dateEnd = "";
            // If the user wants the date filters, add them to the request
            if (filterParameters.UseDateFilter)
            {
                SQLString += " Eve_Date > STR_TO_DATE(@DateStart, '%Y-%m-%d %H:%i:%s') AND Eve_Date < STR_TO_DATE(@DateEnd, '%Y-%m-%d %H:%i:%s') AND";
                dateStart = filterParameters.Start.ToString("yyyy - MM - dd HH: mm:ss");
                dateEnd = filterParameters.End.ToString("yyyy - MM - dd HH: mm:ss");
            }

            // If the users wants to use lot filters, add them to the request
            if(filterParameters.UseLotFilter)
            {
                SQLString += " Lot_Numero = @LotNumero AND";
            }

            SQLString += " 1 = 1";

            MySqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = SQLString;

            if(filterParameters.UseDateFilter)
            {
                cmd.Parameters.AddWithValue("@DateStart", dateStart);
                cmd.Parameters.AddWithValue("@DateEnd", dateEnd);
            }

            if(filterParameters.UseLotFilter)
            {
                cmd.Parameters.AddWithValue("@LotNumero", filterParameters.LotID);
            }

            cmd.Prepare();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Evenement> evenements = new List<Evenement>();
            Evenement evenement = new Evenement();

            while (reader.Read())
            {
                evenement.ID = int.Parse(reader["Lot_Numero"].ToString());
                evenement.Message = reader["Eve_Message"].ToString();
                evenement.DateTime = DateTime.Parse(reader["Eve_Date"].ToString());
                evenement.LotID = int.Parse(reader["Lot_Numero"].ToString());
                
                evenements.Add(evenement);
            }

            CloseConnection();
            return evenements;
        }

    }
}
