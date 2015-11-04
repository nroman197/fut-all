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
            return "Data Source=KIM;Initial Catalog=FUTALL;User ID=adm;Password=adm";
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
            string queryString = "select count(1) from [User] where user_email = '" + pemail + "' and password = '"+ ppassword +"'";

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
    }
}
