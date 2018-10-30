using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Tesina
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            uid = "root";
            password = "";
            database = "basketapp";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        //Insert statement
        public void InsertPunteggio(string user, int punteggio, string data)
        {
            string query = "INSERT INTO punteggio VALUES('"+ user + "', '" + punteggio + "', '" + data + "', NULL)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public bool Login(string user, string psw)
        {
            bool result = false;
            string query = "SELECT * FROM login WHERE FK_Username = '" + user + "' AND Psw = '" + psw + "' ";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataTable UtentiDT = new DataTable();
                UtentiDT.Load(dataReader);
                if (UtentiDT.Rows.Count > 0)
                {
                    result = true;
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            return result;
        }

        public int PunteggioMondiale()
        {
            int punteggio = 0;
            string query = "SELECT MAX(Punti) AS PunteggioMax FROM punteggio";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataTable UtentiDT = new DataTable();
                UtentiDT.Load(dataReader);
                if (UtentiDT.Rows.Count > 0)
                {
                    DataRow dr = UtentiDT.Rows[0];
                    if (dr["PunteggioMax"].ToString() != "")
                        punteggio = Convert.ToInt32(dr["PunteggioMax"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            return punteggio;
        }

        public int PunteggioUtente(string user)
        {
            int punteggio = 0;
            string query = "SELECT MAX(Punti) AS PunteggioMax FROM punteggio WHERE FK_Username = '" + user + "'";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                DataTable UtentiDT = new DataTable();
                UtentiDT.Load(dataReader);
                if (UtentiDT.Rows.Count > 0)
                {
                    DataRow dr = UtentiDT.Rows[0];
                    if(dr["PunteggioMax"].ToString() != "")
                        punteggio = Convert.ToInt32(dr["PunteggioMax"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            return punteggio;
        }
    }
}
