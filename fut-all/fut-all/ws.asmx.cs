using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace fut_all
{
    /// <summary>
    /// Descripción breve de WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {

        private string ConnectionString()
        {
            return "Data Source=LAPTOP-3Q31SCMK;Initial Catalog=FUTALL;User ID=adm;Password=adm";
        }

        [WebMethod]
        public void Continent_Ins(string pname)
        {
            string queryString = "spContinent_Ins  '" + pname +"'";

            
            string connection1 = ConnectionString();

            using ( SqlConnection connection2 = new SqlConnection(connection1))           
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }

        [WebMethod]
        public List<string> Continents_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Continent order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public List<string> Players_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name + ' ' + last_name from Player order by last_name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Continent_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select continent_id from continent where name = '" + pname + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    theId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public void Confederation_Ins(string pname, int pid)
        {
            string queryString = "spConfederation_Ins '" + pname + "' , " + Convert.ToString(pid);


            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }

        [WebMethod]
        public void Country_Ins(string pname, int pid)
        {
            string queryString = "spCountry_Ins '" + pname + "' , " + Convert.ToString(pid);


            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }

        [WebMethod]
        public List<string> Confederations_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Confederation order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public List<string> Stadiums_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Stadium order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public List<string> Teams_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Team order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Confederation_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select confederation_id from confederation where name = '" + pname + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    theId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public void Continent_Upd(string pname, int pid)
        {
            string queryString = "spContinent_Upd '" + pname + "' , " + Convert.ToString(pid);
            string connection1 = ConnectionString();
            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }
        }

        [WebMethod]
        public void Confederation_Upd(string pname, int pidconfe, int pidconti)
        {
            string queryString = "spConfederation_Upd '" + pname + "' , " + Convert.ToString(pidconfe) + "," + Convert.ToString(pidconti);
            string connection1 = ConnectionString();
            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }
        }

        [WebMethod]
        public void Country_Upd(string pname, int pidcountr, int pidconfe)
        {
            string queryString = "spCountry_Upd '" + pname + "' , " + Convert.ToString(pidcountr) + "," + Convert.ToString(pidconfe);
            string connection1 = ConnectionString();
            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }
        }

        [WebMethod]
        public void Stadium_Upd(string pname, int pidstadium)
        {
            string queryString = "spStadium_Upd '" + pname + "' , " + Convert.ToString(pidstadium);
            string connection1 = ConnectionString();
            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }
        }

        [WebMethod]
        public void Stadium_Ins(string pname)
        {
            string queryString = "spStadium_Ins '" + pname +"'";


            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }

        [WebMethod]
        public void Player_Ins(string pname, string plastname, int ppassport, int pshirt, int pcountryId, string pphoto, int ppositionId, int pgenre )
        {
            string queryString = "spPlayer_Ins '" + pname + "' , '" + plastname + "' , " + Convert.ToString(pshirt) + " , " 
                + Convert.ToString(ppassport) + ", " + Convert.ToString(pcountryId) + ", '" 
                + pphoto + "' , " + Convert.ToString(ppositionId) + ", " + Convert.ToString(pgenre);


            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }

        [WebMethod]
        public List<string> Positions_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Position order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Position_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select position_id from position where name = '" + pname + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    theId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public List<string> Countries_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select name from Country order by name asc";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Stadium_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select stadium_id from Stadium where name = '" + pname + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    theId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public int Country_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select country_id from country where name = '" + pname + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    theId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public List<string> Players_Get(int pgenre)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "Players_Get " + Convert.ToString(pgenre);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0]));
                theList.Add(Convert.ToString(reader[1]));
                theList.Add(Convert.ToString(reader[2]));
                theList.Add(Convert.ToString(reader[3]));
                theList.Add(Convert.ToString(reader[4]));
                theList.Add(Convert.ToString(reader[5]));
                theList.Add(Convert.ToString(reader[6]));

            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public void Team_Ins(string pfullname, string pshortname, int pcat, int ptype, int pcountryId, int pstadiumId, string pphoto)
        {
            string queryString = "spTeam_Ins '" + pshortname + "' , '" + pfullname + "' , "+ Convert.ToString(ptype) 
                +", " + Convert.ToString(pcat) + ", " + Convert.ToString(pstadiumId) + ", " + Convert.ToString(pcountryId) +
                ", '" + pphoto + "'";

            string connection1 = ConnectionString();

            using (SqlConnection connection2 = new SqlConnection(connection1))
            {
                SqlCommand command1 = connection2.CreateCommand();
                command1.CommandTimeout = 3600;
                command1.Connection = connection2;
                command1.CommandText = queryString;
                connection2.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                reader1.Close();
                connection2.Close();
            }

        }


    }

}
