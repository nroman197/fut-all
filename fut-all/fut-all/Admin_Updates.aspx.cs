using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Admin_Updates : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.Data.DataTable tb = new System.Data.DataTable();

                // manage gridview
                tb.Columns.Add("Name");
                tb.Columns.Add("Last Name");
                tb.Columns.Add("Position");
                tb.Columns.Add("Country");
                tb.Columns.Add("#");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                grvPlayers.DataSource = tb;
                grvPlayers.DataBind();
                //load drop down list
                LoadContinents();
                LoadConfederations();
                LoadCountries();
                LoadStadiums();
                LoadPlayers();
                LoadTeams();


            }
        }
        //Load all the continents stored in the database
        private void LoadContinents()
        {
            ddlContinent.Items.Clear();
            ddlContinent.Items.Add("-Select Continent-");
            List<string> ListContinents = ws.Continents_Get();

            foreach (string g in ListContinents)
            {
                ddlContinent.Items.Add(g);
            }
        }
        //load all the confederation stored in the database
        private void LoadConfederations()
        {
            ddlConfederations.Items.Clear();
            ddlConfederations.Items.Add("-Select Confederation-");


            List<string> ListConfederations = ws.Confederations_Get();

            foreach (string g in ListConfederations)
            {
                ddlConfederations.Items.Add(g);
            }
        }

        //load all the countries to the drop down list
        private void LoadCountries()
        {
            ddlCountries.Items.Clear();
            ddlCountries.Items.Add("-Select Country-");


            List<string> ListCountries = ws.Countries_Get();
            foreach (string g in ListCountries)
            {
                ddlCountries.Items.Add(g);
            }
        }

        //load the player country
        
        private void LoadPlayerCountry()
        {
            ddlPlayerCountry.Items.Clear();
            ddlPlayerCountry.Items.Add("-Select Country-");


            List<string> ListPlayerCountries = ws.Countries_Get();
            foreach (string g in ListPlayerCountries)
            {
                ddlPlayerCountry.Items.Add(g);
            }
        }
        //load all the stadiums to the drop down list
        private void LoadStadiums()
        {
            ddlStadiums.Items.Clear();
            ddlStadiums.Items.Add("-Select Stadium-");


            List<string> ListStadiums = ws.Stadiums_Get();
            foreach (string g in ListStadiums)
            {
                ddlStadiums.Items.Add(g);
            }
        }
        
        //load all the players in the database to the drop down list
        private void LoadPlayers()
        {
            ddlPlayername.Items.Clear();
            ddlPlayername.Items.Add("-Select Player-");


            List<string> ListPlayers = ws.Players_Get();
            foreach (string g in ListPlayers)
            {
                ddlPlayername.Items.Add(g);
            }
        }

        private void LoadTeams()
        {
            ddlTeamname.Items.Clear();
            ddlTeamname.Items.Add("-Select Team-");


            List<string> ListTeams = ws.Teams_Get();
            foreach (string g in ListTeams)
            {
                ddlTeamname.Items.Add(g);
            }
        }

        //load all the positions of a player
        private void LoadPosition()
        {
            ddlPosition.Items.Clear();
            ddlPosition.Items.Add("-Select Position-");

            List<string> ListPositions = ws.Positions_Get();
            foreach (string g in ListPositions)
            {
                ddlPosition.Items.Add(g);
            }
        }

        //LoadCategory
        private void LoadTeamCategory()
        {
            ddlTeamCathegory.Items.Clear();
            ddlTeamCathegory.Items.Add("-Select Category-");

            //List<string> ListTeamCategories = ws.TeamCategory_Get();
            //foreach (string g in ListTeamCategories)
            //{
            //    ddlTeamCathegory.Items.Add(g);
            //}
        }

        //LoadTeamType
        private void LoadTeamType()
        {
            ddlTeamType.Items.Clear();
            ddlTeamType.Items.Add("-Select Type-");

            //List<string> ListTeamTypes = ws.TeamType_Get();
            //foreach (string g in ListTeamTypes)
            //{
            //    ddlTeamType.Items.Add(g);
            //}
        }

        //LoadTeamCountry
        private void LoadTeamCountry()
        {
            ddlTeamCountry.Items.Clear();
            ddlTeamCountry.Items.Add("-Select Country-");

            //List<string> ListTeamCountry = ws.Countries_Get();
            //foreach (string g in ListTeamCountry)
            //{
            //    ddlTeamCountry.Items.Add(g);
            //}
        }

        //LoadTeamStadium
        private void LoadTeamStadium()
        {
            ddlTeamStadium.Items.Clear();
            ddlTeamStadium.Items.Add("-Select Country-");

            //List<string> ListTeamStadiums = ws.Stadiums_Get();
            //foreach (string g in ListTeamStadiums)
            //{
            //    ddlTeamStadium.Items.Add(g);
            //}
        }
        //load the genres
        private void LoadGenres()
        {
            ddlGenrePlayer.Items.Clear();
            ddlGenrePlayer.Items.Add("-Select Genre-");
            ddlGenrePlayer.Items.Add("Male");  // id 0
            ddlGenrePlayer.Items.Add("Female"); // id 1
        }
        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnAddcontinent_Click(object sender, EventArgs e)
        {
            string newcontinent = "";
            newcontinent = txbContinent.Text;
            int continentid = ws.Continent_Id_Get(ddlContinent.SelectedItem.Text);
            if (newcontinent.Length != 0)
            {
                ws.Continent_Upd(newcontinent, continentid);
                txbContinent.Text = "";
                LoadContinents();
            }    
        }

        protected void btnAddConfederation_Click(object sender, EventArgs e)
        {
            string newconfederation = "";
            newconfederation = txbConfederation.Text;
            int confederationtid = ws.Confederation_Id_Get(ddlConfederations.SelectedItem.Text);
            int continentid = ws.Continent_Id_Get(ddlContinent.SelectedItem.Text);
            if (newconfederation.Length != 0)
            {
                ws.Confederation_Upd(newconfederation, Convert.ToInt32(confederationtid), Convert.ToInt32(continentid));
                txbConfederation.Text = "";
                ddlConfederations.SelectedIndex=0;
            }    
        }

        protected void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (ddlConfederations.SelectedIndex == 0)
            {
             
            }
            else
            {
                string newcountry = "";
                newcountry = txbCountry.Text;
                int confederationid = ws.Confederation_Id_Get(ddlConfederations.SelectedItem.Text);
                int countryid = ws.Country_Id_Get(ddlCountries.SelectedItem.Text);
                if (newcountry.Length != 0)
                {
                    ws.Country_Upd(newcountry, Convert.ToInt32(countryid), Convert.ToInt32(confederationid));
                    txbCountry.Text = "";
                    ddlCountries.SelectedIndex = 0;
                    ddlConfederations.SelectedIndex = 0;
                }
            }
        }

        protected void btnAddStadium_Click(object sender, EventArgs e)
        {
            string newstadium = "";
            newstadium = txbStadium.Text;
            int stadiumid = ws.Stadium_Id_Get(ddlStadiums.SelectedItem.Text);
            if (newstadium.Length != 0)
            {
                ws.Stadium_Upd(newstadium, stadiumid);
                txbStadium.Text = "";
                LoadStadiums();
            }  
        }

      

        protected void ddlContinents_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlConfederations_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPosition_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlContinent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlStadiums_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPlayername_TextChanged(object sender, EventArgs e)
        {
          int idPlayer = ws.Player_Id_Get(ddlPlayername.SelectedItem.Text);
          List<string> list_player = ws.PlayerInfo_Get(idPlayer); // returns list including 8 attributes (see in ws function)
           txbPName.Text = list_player[0]; //name
           txbPLastName.Text = list_player[1]; //last name
           txbPPassport.Text = list_player[2]; //passport
           txbShirtNumber.Text = list_player[3]; //shirt number
           ddlPosition.SelectedIndex = Convert.ToInt32(list_player[4]); //position name
           ddlGenrePlayer.SelectedIndex = Convert.ToInt32(list_player[5]);//genre
           //fuPicture.Fi = Convert.ToString(list_player[6]);
           ddlPlayerCountry.SelectedIndex = Convert.ToInt32(list_player[6]);//country name

              
              
           
         
        }

        protected void ddlTeamStadium_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addPlayer_Click(object sender, EventArgs e)
        {

        }

        protected void ddlContinent_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlGenrePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (ddlPlayername.SelectedIndex == 0)
            {

            }
            else
            {
              
                if (txbPName.Text.Length > 0 && txbPLastName.Text.Length > 0 && txbPPassport.Text.Length > 0 && txbShirtNumber.Text.Length > 0
                    && ddlPosition.SelectedIndex > 0 && fuPicture.HasFile && ddlGenrePlayer.SelectedIndex > 0 &&
                    ddlPlayerCountry.SelectedIndex > 0)
                {
                    if (fuPicture.PostedFile.ContentType == "image/jpeg" || fuPicture.PostedFile.ContentType == "image/png"
                    || fuPicture.PostedFile.ContentType == "image/bmp" || fuPicture.PostedFile.ContentType == "image/jpg")
                    {
                        string filename = Path.GetFileName(fuPicture.FileName);
                        fuPicture.SaveAs(@"C:\fut-all\players_pics\" + filename);

                        string pphoto = @"C:\fut-all\players_pics\" + filename;
                        int playercountry_id = ws.Country_Id_Get(ddlPlayerCountry.SelectedItem.Text);
                        int position_id = ws.Position_Id_Get(ddlPosition.SelectedItem.Text);
                       // int player_id = ws.Player_Id_Get(ddlPlayername.SelectedItem.Text);
                        int gen_id = 0;
                        if (ddlGenrePlayer.SelectedIndex == 2)
                        {
                            gen_id = 1;
                        }
                        // ws.Player_Upd(ConvertToInt32(player_id),txbPName.Text,txbPLastName.Text,Convert.ToInt32(txbPPassport.Text), Convert.ToInt32(txbShirtNumber.Text), ConvertToInt32(playercountry_id), pphoto , ConvertToInt32(position_id), ConvertToInt32(genreid));
                        txbPName.Text = "";
                        txbPLastName.Text = "";
                        txbPPassport.Text = "";
                        txbPPassport.Text = "";
                        ddlPosition.SelectedIndex = 0;
                        ddlGenrePlayer.SelectedIndex = 0;
                        ddlPlayername.SelectedIndex = 0;
                    }
                }
            } 
        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlConfederations_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btnAddTeam_Click(object sender, EventArgs e)
        {
            //update the team.
            if (ddlTeamname.SelectedIndex == 0)
            {

            }
            else
            {   
                //LoadTeamCategory
                LoadTeamCategory();
                //LoadTeamType
                LoadTeamType();
                //LoadTeamCountry
                LoadTeamCountry();
                //LoadStadium
                LoadTeamStadium();
                string newfullname = txbFullName.Text;
                string newshortname = txtShortName.Text;
               // int id_team = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
                //int id_teamcategory = ws.TeamCategory_Id_Get(ddlTeamCathegory.SelectedItem.Text);
               // int id_TeamType = ws.TeamType_Id_Get(ddlTeamType.SelectedItem.Text);
                //int id_teamcountry = ws.Country_Id_Get(ddlTeamCountry.Text);
              //  int id_teamStadium = ws.Stadium_Id_Get(ddlTeamStadium);

               // ws.Team_Upd(Convert.ToInt32(id_team), newfullname, newshortname, Convert.ToInt32(id_teamcategory), Convert.ToInt32(id_TeamType), Convert.ToInt32(id_teamcountry), Convert.ToInt32(id_teamStadium));
                newfullname = "";
                newshortname = "";
                ddlTeamname.SelectedIndex = 0;
                ddlTeamCathegory.SelectedIndex = 0;
                ddlTeamType.SelectedIndex = 0;
                ddlTeamCountry.SelectedIndex = 0;
                ddlTeamStadium.SelectedIndex = 0;
            }
        }

       
    }
}