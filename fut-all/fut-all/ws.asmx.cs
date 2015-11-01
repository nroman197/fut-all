﻿using System;
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

    }

}
