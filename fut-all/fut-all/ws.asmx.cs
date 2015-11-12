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
            string queryString = "spContinent_Ins  '" + pname + "'";


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
        public List<string> Users_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select user_email from [User] where user_role = 0";

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
        public int User_Id_Get(string pemail)
        {
            int theId = 0;
            string queryString = "select user_id from [User] where user_email = '" + pemail + "'";

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
        public void Create_Admin(int pid)
        {
            string queryString = "spCreate_Admin " + Convert.ToString(pid);
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
            string queryString = "spStadium_Ins '" + pname + "'";


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
        public void Player_Ins(string pname, string plastname, int ppassport, int pshirt, int pcountryId, string pphoto, int ppositionId, int pgenre)
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
        public int Player_Id_Get(string pname)
        {
            int theId = 0;
            string[] text = pname.Split(' ');
            string name = text[0];
            string lastname = text[1];
            string queryString = "select player_id from player where name = '" + name + "'and last_name = '" + lastname + "'";

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
        public void Player_Upd(int idplayer, string pname, string plastname, int ppassport, int pshirt, int pcountryId, string pphoto, int ppositionId, int pgenre)
        {
            string queryString = "spPlayer_Upd " + idplayer + "," + "'" + pname + "' , '" + plastname + "' , " + Convert.ToString(pshirt) + " , "
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
        public List<string> PlayerInfo_Get(int pplayer_id)
        {
            List<string> list_playerinfo = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();

            string queryString = "fnGetPlayerInfo" + " " + Convert.ToString(pplayer_id);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list_playerinfo.Add(Convert.ToString(reader[0])); // name
                list_playerinfo.Add(Convert.ToString(reader[1])); // last name
                list_playerinfo.Add(Convert.ToString(reader[2])); // passport
                list_playerinfo.Add(Convert.ToString(reader[3])); // shirtnumber
                list_playerinfo.Add(Convert.ToString(reader[4])); // position
                list_playerinfo.Add(Convert.ToString(reader[5])); // genre
                list_playerinfo.Add(Convert.ToString(reader[6])); // photo
                list_playerinfo.Add(Convert.ToString(reader[7])); // countryname

            }

            reader.Close();
            connection.Close();

            return list_playerinfo;
        }


        [WebMethod]
        public List<string> TeamInfo_Get(int pteam_id)
        {
            List<string> list_pteaminfo = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();

            string queryString = "fnGetTeamInfo" + " " + Convert.ToString(pteam_id);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list_pteaminfo.Add(Convert.ToString(reader[0])); // full name
                list_pteaminfo.Add(Convert.ToString(reader[1])); // short name
                list_pteaminfo.Add(Convert.ToString(reader[2])); // cathegory(isWomen)
                list_pteaminfo.Add(Convert.ToString(reader[3])); // type(isClub)
                list_pteaminfo.Add(Convert.ToString(reader[4])); // countryname
                list_pteaminfo.Add(Convert.ToString(reader[5])); // stadiumname
                list_pteaminfo.Add(Convert.ToString(reader[6])); // flag
            }

            reader.Close();
            connection.Close();

            return list_pteaminfo;
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
        public List<string> TeamPlayers_Get(int idteam, int pgenre, int isnationalteam, int countryid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "GetTeamPlayers " + Convert.ToString(idteam) + " ," + Convert.ToString(pgenre) + "," + Convert.ToString(isnationalteam) + "," + Convert.ToString(countryid);

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
        public List<string> AllPlayers_Get(int idteam, int pgenre, int pisnationalteam, int countryid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "GetAllPlayers " + Convert.ToString(idteam) + ", " + Convert.ToString(pgenre) + "," + Convert.ToString(pisnationalteam) + "," + Convert.ToString(countryid);

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
        public List<string> NotTeamPlayer_Get(int idteam, int pgenre, int pisnationalteam, int countryid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "GetNotTeamPlayer " + Convert.ToString(idteam) + ", " + Convert.ToString(pgenre) + "," + Convert.ToString(pisnationalteam) + "," + Convert.ToString(countryid);

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
        public List<string> Players_Get(int pgenre, int isnationalteam, int countryid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "Players_Get " + Convert.ToString(pgenre) + "," + Convert.ToString(isnationalteam) + "," + Convert.ToString(countryid);

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
        public int Team_Ins(string pfullname, string pshortname, int pcat, int ptype, int pcountryId, int pstadiumId, string pphoto)
        {
            string queryString = "spTeam_Ins '" + pshortname + "' , '" + pfullname + "' , " + Convert.ToString(ptype)
                + ", " + Convert.ToString(pcat) + ", " + Convert.ToString(pstadiumId) + ", " + Convert.ToString(pcountryId) +
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

            queryString = "select max(team_id) from team";
            int teamid = 0;

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
                    teamid = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return teamid;
        }

        [WebMethod]
        public int Team_Upd(int pteamid, string pfullname, string pshortname, int pcat, int ptype, int pcountryId, int pstadiumId, string pphoto)
        {
            string queryString = "spTeam_Upd " + pteamid + "," + "'" + pshortname + "' , '" + pfullname + "' , " + Convert.ToString(ptype)
                + ", " + Convert.ToString(pcat) + ", " + Convert.ToString(pstadiumId) + ", " + Convert.ToString(pcountryId) +
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

            queryString = "select max(team_id) from team";
            int teamid = 0;

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
                    teamid = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return teamid;
        }

        [WebMethod]
        public int Player_Id_Get(string pname, string plname)
        {
            int plaId = 0;
            string queryString = "select player_id from player where name = '" + pname + "' and last_name = '" + plname + "'";

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
                    plaId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return plaId;
        }

        [WebMethod]
        public int Team_Id_Get(string pname)
        {
            int plaId = 0;
            string queryString = "select team_id from team where name = '" + pname + "'";

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
                    plaId = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return plaId;
        }

        [WebMethod]
        public void PlayerxTeam_Ins(int idplayer, int idteam)
        {
            string queryString = "spPlayerxTeam_Ins " + Convert.ToString(idplayer) + ", " + Convert.ToString(idteam);

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
        public void PlayerxTeam_Del(int idplayer, int idteam)
        {
            string queryString = "spPlayerxTeam_Del " + Convert.ToString(idplayer) + ", " + Convert.ToString(idteam);

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
        public void PlayerxTeam_Upd(int idplayer, int idteam)
        {
            string queryString = "spPlayerxTeam_Upd " + Convert.ToString(idplayer) + ", " + Convert.ToString(idteam);

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
        public void User_Ins(string pemail, string ppassword)
        {
            string queryString = "spUser_Ins '" + pemail + "' , '" + ppassword + "'";

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
        public int EmailExists_Get(string pemail)
        {
            int theId = 0;
            string queryString = "select count(1) from [User] where user_email = '" + pemail + "'";

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
        public int LoginValidation_Get(string pemail, string ppassword)
        {
            int theId = 0;
            string queryString = "select count(1) from [User] where user_email = '" + pemail + "' and password = '" + ppassword + "'";

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
        public int User_Id_Get(string pemail, string ppassword)
        {
            int theId = 0;
            string queryString = "select [user_id] from [User] where user_email = '" + pemail + "' and password = '" + ppassword + "'";

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
        public int User_Role_Get(int theId)
        {
            int role = 0;
            string queryString = "select [user_role] from [User] where [user_id] = " + Convert.ToString(theId);

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
                    role = Convert.ToInt32(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return role;
        }

        [WebMethod]
        public List<string> StadiumxCountry_Get(int pcou)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select * from fncStadiumxCountry_Get(" + pcou + ")";

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
        public List<string> TeamxTypexCategory_Get(int ptype, int pcat)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select [name] from team where isClub = "+ Convert.ToString(ptype) +
                " and isWomenTeam = " +Convert.ToString(pcat)+ " order by [name] asc";

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
        public void Match_Ins(int team1_id, int team2_id, int pphaseid)
        {
            string queryString = "spMatch_Ins " + Convert.ToString(team1_id) + " , " + Convert.ToString(team2_id) 
                + ", "+Convert.ToString(pphaseid);

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
        public void Phase_Ins(string pha_name, int pha_id, int pevent_id)
        {
            string queryString = "spPhase_Ins '" + pha_name + "' , " + Convert.ToString(pha_id) + ","+Convert.ToString(pevent_id);

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
        public int PhaseType_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select phase_type_id from phase_type where name = '" + pname + "'";

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
        public int PhaseType_Id_Get(int phaseid)
        {
            int theId = 0;
            string queryString = "select pt.phase_type_id from Phase_Type pt inner join phase p on pt.phase_type_id = p.phase_type_id where phase_id =" + Convert.ToString(phaseid) ;

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
        public int PhaseType_Id_GetxQuant(int pquant)
        {
            int theId = 0;
            string queryString = "select phase_type_id from phase_type where matches_quant = " + pquant ;

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
        public string PhaseType_Name_GetxQuant(int pquant)
        {
            string theId = "";
            string queryString = "select name from phase_type where matches_quant = " + pquant;

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
                    theId = Convert.ToString(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theId;
        }

        [WebMethod]
        public void NoTeam_Match_Ins(int pphase)
        {
            string queryString = "spNoTeam_Match_Ins " + Convert.ToString(pphase) ;

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
        public int LastPhase_Id_Get()
        {
            int theId = 0;
            string queryString = "select max(phase_id) from phase";

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
        public void Event_Ins(string pname,int pteam_type, int pisWomen, int team_quant,
            int pevent_type_id, string pstart_date, string pend_date, string logo)
        {
            string queryString = "spEvent_Ins '" + pname + "', " + Convert.ToString(pteam_type) + ","
                + Convert.ToString(pisWomen) + "," + Convert.ToString(team_quant) + ","
                + Convert.ToString(pevent_type_id) + ",'" + pstart_date + "', '" + pend_date + "', '"+logo+"'";

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
        public int LastEvent_Id_Get()
        {
            int theId = 0;
            string queryString = "select max(event_id) from [event]";

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
        public int EventType_Id_Get(string pname)
        {
            int theId = 0;
            string queryString = "select event_type_id from Event_Type where [name] = '" +pname+ "'";

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
        public int Events_Count()
        {
            int theId = 0;
            string queryString = "select count(1) from [event]";

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
        public List<string> Events_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "Events_Get" ;

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // logo
                theList.Add(Convert.ToString(reader[1])); // name
                theList.Add(Convert.ToString(reader[2])); // start date
                theList.Add(Convert.ToString(reader[3])); // end date
                theList.Add(Convert.ToString(reader[4])); // team type 0 national team, 1 club
                theList.Add(Convert.ToString(reader[5])); // is women  0 men, 1 women

            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Event_Id_Get(string name)
        {
            int theId = 0;
            string queryString = "select event_id from [event] where [name] = '"+ name +"'";

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
        public List<string> Phases_Get(int eventid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "Phases_Get " + Convert.ToString(eventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // phase name
                theList.Add(Convert.ToString(reader[1])); // country name
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public string Team_Flag_Get(string name)
        {
            string theflag = "";
            string queryString = "select flag from team where name = '" + name + "'";

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
                    theflag = Convert.ToString(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return theflag;
        }

        [WebMethod]
        public int Phases_Count(int eventid)
        {
            int theId = 0;
            string queryString = "select count(1) from phase where event_id = " +Convert.ToString(eventid);

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
        public int Matches_Count(int phaseid)
        {
            int theId = 0;
            string queryString = "select count(1) from Match where phase_id = " + Convert.ToString(phaseid);

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
        public List<string> Matches_Get(int eventid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "Matches_Get " + Convert.ToString(eventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // team 1 name
                theList.Add(Convert.ToString(reader[1])); // team 2 name
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int Phase_Id_Get(int eventid, string name)
        {
            int theId = 0;
            string queryString = "select phase_id from phase where event_id = "+Convert.ToString(eventid)+" and [name] = '" + name +"'";

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
        public string Phase_Name_Get(int phaid)
        {
            string thename = "";
            string queryString = "select [name] from phase where phase_id = " + Convert.ToString(phaid);

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
                    thename = Convert.ToString(reader1[0]);
                }

                reader1.Close();
                connection2.Close();
            }

            return thename;
        }

        [WebMethod]
        public void CountryxEvent_Ins(int cou_id, int pevent_id)
        {
            string queryString = "spCountryxEvent_Ins " + Convert.ToString(cou_id) + "," + Convert.ToString(pevent_id);

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
        public void StadiumxEvent_Ins(int event_id, int stadium_id)
        {
            string queryString = "spStadiumxEvent_Ins " + Convert.ToString(event_id) + "," + Convert.ToString(stadium_id);

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
        public List<string> UserRole_Get()
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select user_role from [User]";
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
        public List<string> GroupTeams_Get(int phaseid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "GroupTeams_Get " + Convert.ToString(phaseid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // phase name
                theList.Add(Convert.ToString(reader[1])); // country name
            }

            reader.Close();
            connection.Close();

            return theList;
        }
    
        [WebMethod]
        public int PhaseId_Get(string name)
        {
            int theId = 0;
            string queryString = "select phase_id from phase where [name] = '"+ name +"'";

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
        public List<string> CountryxEvent_Get(int peventid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select * from fnCountryxEvent_Get(" + Convert.ToString(peventid) + ")";

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
        public List<string> StadiumxEvent_Get(int peventid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select * from fnStadiumxEvent_Get(" + Convert.ToString(peventid) + ")";

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
        public List<string> StatsxGroup_Get(int phaseid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec StatsxGroup " + Convert.ToString(phaseid);

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
                theList.Add(Convert.ToString(reader[7]));
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int MatchesPlayed_Get(int peventid)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec MatchesPlayed_Get " + Convert.ToString(peventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0]);
            }

            reader.Close();
            connection.Close();

            return count;
        }

        [WebMethod]
        public int TotalMatches_Get(int peventid)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec TotalMatches_Get " + Convert.ToString(peventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0]);
            }

            reader.Close();
            connection.Close();

            return count;
        }

        [WebMethod]
        public double GoalsxMatch_Get(int peventid)
        {
            double count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec GoalsxMatch_Get " + Convert.ToString(peventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToDouble(reader[0]);
            }

            reader.Close();
            connection.Close();

            return count;
        }

        [WebMethod]
        public double CardsxMatch_Get(int peventid, int color)
        {
            double count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec CardsxMatch_Get " + Convert.ToString(peventid) + "," + Convert.ToString(color);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToDouble(reader[0]);
            }

            reader.Close();
            connection.Close();

            return count;
        }

        [WebMethod]
        public double ShotsxTeam_Get(int peventid)
        {
            double count = 0;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec ShotsxTeam_Get " + Convert.ToString(peventid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                count = Convert.ToDouble(reader[0]);
            }

            reader.Close();
            connection.Close();

            return count;
        }

        [WebMethod]
        public List<string> TeamsxPhase_Get(int peventid, int phasetypeid)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "exec teamsxphase_get " + Convert.ToString(peventid) + ", " + Convert.ToString(phasetypeid);

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
        public List<string> FnTeamPlayers_Get(int idteam)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select * from fnTeamPlayers_Get(" + Convert.ToString(idteam) + ")";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // name
                theList.Add(Convert.ToString(reader[1])); // lastname
                theList.Add(Convert.ToString(reader[2])); //position
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public int TournMatch_Id_Get(int teamid1, int teamid2)
        {
            int theId = 0;
            string queryString = "select m.match_id from Match m where m.team1_id = " + Convert.ToString(teamid1) + " and m.team2_id = " +  Convert.ToString(teamid2);

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
        public string MatchDateTime_Get(int matchid)
        {
            string date = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select m.[date_time] from Match m where m.match_id =" + Convert.ToString(matchid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                date = Convert.ToString(reader[0]);
            }

            reader.Close();
            connection.Close();

            return date;
        }

        [WebMethod]
        public string MatchStadium_Get(int matchid)
        {
            string date = "";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select m.stadium_id from Match m where m.match_id = " + Convert.ToString(matchid);

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                date = Convert.ToString(reader[0]);
            }

            reader.Close();
            connection.Close();

            return date;
        }

        [WebMethod]
        public List<string> fnTournTeamPlayers_Get(int idteam)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select * from fnTournTeamPlayers_Get(" + Convert.ToString(idteam) + ")";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); // full name
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public void TournMatch_Upd(int match_id, string datetime, int id_stadium)
        {
            string queryString = "Match_Upd  " + Convert.ToString(match_id) + ",'" +  datetime + "'," + Convert.ToString(id_stadium);


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
        public void Aligment_Ins(int player_id, int id_match, int isCaptain, int id_replace,int replace_time)
        {
            string queryString = "spAlignment_Ins  " + Convert.ToString(player_id) + ", " +  Convert.ToString(id_match) +  "," + Convert.ToString(isCaptain) + ", " + Convert.ToString(id_replace) + "," + Convert.ToString(replace_time);


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
        public List<string> match_idsxPhase_Get(int idphase)
        {
            List<string> theList = new List<string>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString();
            string queryString = "select m.match_id from match m inner join Phase p on m.phase_id = p.phase_id where p.phase_id =" + Convert.ToString(idphase) + "and m.team1_id is null ";

            SqlCommand command = connection.CreateCommand();
            command.CommandTimeout = 3600;
            command.Connection = connection;
            command.CommandText = queryString;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                theList.Add(Convert.ToString(reader[0])); //
            }

            reader.Close();
            connection.Close();

            return theList;
        }

        [WebMethod]
        public void spMatchQualifs_Upd(int pid, int team1, int team2)
        {
            string queryString = "exec spMatchQualifs_Upd " + Convert.ToString(pid) + " , " + Convert.ToString(team1) + " , " + Convert.ToString(team2);
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
