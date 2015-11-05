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

        //Load team country
        private void LoadTeamCountries()
        {
            ddlTeamCountry.Items.Clear();
            ddlTeamCountry.Items.Add("-Select Country-");


            List<string> ListCountries = ws.Countries_Get();
            foreach (string g in ListCountries)
            {
                ddlTeamCountry.Items.Add(g);
            }
        }
        //load team stadium
        private void LoadTeamStadiums()
        {
            ddlTeamStadium.Items.Clear();
            ddlTeamStadium.Items.Add("-Select Team-");


            List<string> ListStadiums = ws.Stadiums_Get();
            foreach (string g in ListStadiums)
            {
                ddlTeamStadium.Items.Add(g);
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

        //load all the teams stored in the database
        //private void LoadAllPlayersGrid(int teamid, int pgenre, int isnationalteam, int countryid)
        //{
        //    int counter = 0;
        //    List<string> theList = ws.AllPlayers_Get(teamid, pgenre,isnationalteam,countryid);
        //    string nameplayer = string.Empty;
        //    string lastnameplayer = string.Empty;
        //    string tshirt = string.Empty;
        //    string positionplayer = string.Empty;
        //    string countryplayer = string.Empty;

        //    System.Data.DataTable tb = new System.Data.DataTable();

        //    // manage gridview
        //    tb.Columns.Add("Name");
        //    tb.Columns.Add("Last Name");
        //    tb.Columns.Add("Position");
        //    tb.Columns.Add("Country");
        //    tb.Columns.Add("#");

        //    foreach (string g in theList)
        //    {
        //        if (counter == 0)
        //        {
        //            nameplayer = g;
        //        }
        //        else if (counter == 1)
        //        {
        //            lastnameplayer = g;
        //        }
        //        else if (counter == 2)
        //        {
        //            tshirt = g;
        //        }
        //        else if (counter == 4)
        //        {
        //            countryplayer = g;
        //        }
        //        else if (counter == 6)
        //        {
        //            positionplayer = g;
        //            tb.Rows.Add(nameplayer, lastnameplayer, positionplayer, countryplayer, tshirt);
        //            counter = -1;
        //        }

        //        counter++;
        //    }


        //    grvAllPlayers.DataSource = tb;
        //    grvAllPlayers.DataBind();
        //}

        private void LoadAllNotTeamPlayersGrid(int teamid, int pgenre, int isnationalteam, int countryid)
        {
            int counter = 0;
            List<string> theList = ws.NotTeamPlayer_Get(teamid, pgenre, isnationalteam, countryid);
            List<string> theList1 = ws.AllPlayers_Get(teamid, pgenre, isnationalteam, countryid);
            string nameplayer = string.Empty;
            string lastnameplayer = string.Empty;
            string tshirt = string.Empty;
            string positionplayer = string.Empty;
            string countryplayer = string.Empty;

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");
            tb.Columns.Add("Last Name");
            tb.Columns.Add("Position");
            tb.Columns.Add("Country");
            tb.Columns.Add("#");

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;
                }
                else if (counter == 1)
                {
                    lastnameplayer = g;
                }
                else if (counter == 2)
                {
                    tshirt = g;
                }
                else if (counter == 4)
                {
                    countryplayer = g;
                }
                else if (counter == 6)
                {
                    positionplayer = g;
                    tb.Rows.Add(nameplayer, lastnameplayer, positionplayer, countryplayer, tshirt);
                    counter = -1;
                }

                counter++;
            }

            foreach (string g in theList1)
            {
                if (counter == 0)
                {
                    nameplayer = g;
                }
                else if (counter == 1)
                {
                    lastnameplayer = g;
                }
                else if (counter == 2)
                {
                    tshirt = g;
                }
                else if (counter == 4)
                {
                    countryplayer = g;
                }
                else if (counter == 6)
                {
                    positionplayer = g;
                    tb.Rows.Add(nameplayer, lastnameplayer, positionplayer, countryplayer, tshirt);
                    counter = -1;
                }

                counter++;
            }


            grvAllPlayers.DataSource = tb;
            grvAllPlayers.DataBind();
        }
        //load all the teams stored in the database
        private void LoadTeamPlayersGrid(int idteam,int pgenre, int isnationalteam, int countryid)
        {
            int counter = 0;
            List<string> theList = ws.TeamPlayers_Get(idteam, pgenre,isnationalteam,countryid);
            string nameplayer = string.Empty;
            string lastnameplayer = string.Empty;
            string tshirt = string.Empty;
            string countryplayer = string.Empty;
            string positionplayer = string.Empty;

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");
            tb.Columns.Add("Last Name");
            tb.Columns.Add("Position");
            tb.Columns.Add("Country");
            tb.Columns.Add("#");

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;
                }
                else if (counter == 1)
                {
                    lastnameplayer = g;
                }
                else if (counter == 2)
                {
                    tshirt = g;
                }
                else if (counter == 4)
                {
                    countryplayer = g;
                }
                else if (counter == 6)
                {
                    positionplayer = g;
                    tb.Rows.Add(nameplayer, lastnameplayer, positionplayer, countryplayer, tshirt);
                    counter = -1;
                }

                counter++;
            }


            grvPlayers.DataSource = tb;
            grvPlayers.DataBind();
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
        //load the team cathegory
        private void LoadCathegories()
        {

            ddlTeamCathegory.Items.Clear();
            ddlTeamCathegory.Items.Add("-Select Cathegory-");
            ddlTeamCathegory.Items.Add("Male");  // id 0
            ddlTeamCathegory.Items.Add("Female"); // id 1
        }

        //load the team type
        private void LoadTeamTypes()
        {

            ddlTeamType.Items.Clear();
            ddlTeamType.Items.Add("-Select Type-");
            ddlTeamType.Items.Add("National Team");  // id 0
            ddlTeamType.Items.Add("Club"); // id 1
        }
        //Load the player genre
        private void LoadPlayerGenre()
        {
            ddlGenrePlayer.Items.Clear();
            ddlGenrePlayer.Items.Add("-Select Genre-");
            ddlGenrePlayer.Items.Add("Male");  // id 0
            ddlGenrePlayer.Items.Add("Female"); // id 1
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
                ddlConfederations.SelectedIndex = 0;
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


        protected void ddlPlayername_TextChanged(object sender, EventArgs e)
        {
            LoadPosition();
            LoadPlayerCountry();
            LoadPlayerGenre();
            int idPlayer = ws.Player_Id_Get(ddlPlayername.SelectedItem.Text);
            List<string> list_player = ws.PlayerInfo_Get(idPlayer); // returns list including 8 attributes (see in ws function)
            string name = list_player[0];
            string lastname = list_player[1];
            string passport = list_player[2];
            string shirtnumber = list_player[3];
            string nameposition = list_player[4];
            string genre = list_player[5];
            string photo = list_player[6];
            string namecountry = list_player[7];
            txbPName.Text = list_player[0]; //name
            txbPLastName.Text = list_player[1]; //last name
            txbPPassport.Text = list_player[2]; //passport
            txbShirtNumber.Text = list_player[3]; //shirt number

            int country_id = ws.Country_Id_Get(namecountry);
            int position_id = ws.Position_Id_Get(nameposition);

            if (Convert.ToBoolean(genre) == false)
            {
                ddlGenrePlayer.SelectedIndex = 1;
            }
            else
            {
                ddlGenrePlayer.SelectedIndex = 2;
            }

            int minvalue = 0;
            int maxvalue = ddlPlayerCountry.Items.Count;
            int indexvalue = 0;

            while (minvalue < maxvalue)
            {
                if (namecountry == ddlPlayerCountry.Items[minvalue].Text)
                {
                    indexvalue = minvalue;
                }

                minvalue++;
            }

            ddlPlayerCountry.SelectedIndex = indexvalue;

            int minvalue1 = 0;
            int maxvalue1 = ddlPosition.Items.Count;
            int indexvalue1 = 0;

            while (minvalue1 < maxvalue1)
            {
                if (nameposition == ddlPosition.Items[minvalue1].Text)
                {
                    indexvalue1 = minvalue1;
                }

                minvalue1++;
            }

            ddlPosition.SelectedIndex = indexvalue1;



        }



        protected void ddlTeamName_TextChanged(object sender, EventArgs e)
        {
            int idTeam = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
            LoadCathegories();
            LoadTeamTypes();
            LoadTeamCountries();
            LoadTeamStadiums(); 
            List<string> list_team = ws.TeamInfo_Get(idTeam); // returns list including 8 attributes (see in ws function)
            string shortname = list_team[0];
            string fullname = list_team[1];
            string cathegory = list_team[2];
            string type = list_team[3];
            string countryname = list_team[4];
            string stadiumname = list_team[5];
            string flag = list_team[6];
            txbFullName.Text = list_team[0]; //fullname
            txtShortName.Text = list_team[1]; //short

            int country_id = ws.Country_Id_Get(countryname);
            int stadium_id = ws.Stadium_Id_Get(stadiumname);

            if (Convert.ToBoolean(cathegory) == false)
            {
                ddlTeamCathegory.SelectedIndex = 1;
            }
            else
            {
                ddlTeamCathegory.SelectedIndex = 2;
            }

            if (Convert.ToBoolean(type) == false)
            {
                ddlTeamType.SelectedIndex = 1;
            }
            else
            {
                ddlTeamType.SelectedIndex = 2;
            }

            int minvalue = 0;
            int maxvalue = ddlTeamCountry.Items.Count;
            int indexvalue = 0;

            while (minvalue < maxvalue)
            {
                if (countryname == ddlTeamCountry.Items[minvalue].Text)
                {
                    indexvalue = minvalue;
                }

                minvalue++;
            }

            ddlTeamCountry.SelectedIndex = indexvalue;

            int minvalue1 = 0;
            int maxvalue1 = ddlTeamStadium.Items.Count;
            int indexvalue1 = 0;

            while (minvalue1 < maxvalue1)
            {
                if (stadiumname == ddlTeamStadium.Items[minvalue1].Text)
                {
                    indexvalue1 = minvalue1;
                }

                minvalue1++;
            }

            ddlTeamStadium.SelectedIndex = indexvalue1;

            //load players in the grid
            int countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
            int teamid = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
            if (ddlTeamCathegory.SelectedIndex == 1 && ddlTeamType.SelectedIndex == 1)
            {
                // LoadAllPlayersGrid(teamid,0,0,countryid); //male and national team
                LoadTeamPlayersGrid(teamid, 0, 1, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 0, 1, countryid);
            }
            else if (ddlTeamCathegory.SelectedIndex == 1 && ddlTeamType.SelectedIndex == 2)
            {
                // LoadAllPlayersGrid(teamid, 0, 1, countryid); ////male and Club
                LoadTeamPlayersGrid(teamid, 0, 0, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 0, 0, countryid);

            }
            else if (ddlTeamCathegory.SelectedIndex == 2 && ddlTeamType.SelectedIndex == 1)
            {
                // LoadAllPlayersGrid(teamid, 1, 0, countryid); //female and national team
                LoadTeamPlayersGrid(teamid, 1, 1, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 1, 1, countryid);
            }
            else if (ddlTeamCathegory.SelectedIndex == 2 && ddlTeamType.SelectedIndex == 2)
            {
                // LoadAllPlayersGrid(teamid, 1, 1, countryid); //female and club
                LoadTeamPlayersGrid(teamid, 1, 0, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 1, 0, countryid);
            }
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
                        int player_id = ws.Player_Id_Get(ddlPlayername.SelectedItem.Text);
                        int gen_id = 0;
                        if (ddlGenrePlayer.SelectedIndex == 2)
                        {
                            gen_id = 1;
                        }
                        ws.Player_Upd(Convert.ToInt32(player_id), txbPName.Text, txbPLastName.Text, Convert.ToInt32(txbPPassport.Text), Convert.ToInt32(txbShirtNumber.Text), Convert.ToInt32(playercountry_id), pphoto, Convert.ToInt32(position_id), Convert.ToInt32(gen_id));
                        txbPName.Text = "";
                        txbPLastName.Text = "";
                        txbPPassport.Text = "";
                        txbPPassport.Text = "";
                        ddlPosition.SelectedIndex = 0;
                        ddlGenrePlayer.SelectedIndex = 0;
                        ddlPlayername.SelectedIndex = 0;

                        LoadPlayers();
                    }
                }
            }
        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {
            //clear the grid to change the other players 
            grvAllPlayers.DataSource = null;
            grvAllPlayers.DataBind();
            grvPlayers.DataSource = null;
            grvPlayers.DataBind();
            int countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
            int teamid = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
            if (ddlTeamCathegory.SelectedIndex == 1 && ddlTeamType.SelectedIndex == 1)
            {
               // LoadAllPlayersGrid(teamid,0,0,countryid); //male and national team
                LoadTeamPlayersGrid(teamid,0,1,countryid);
                LoadAllNotTeamPlayersGrid(teamid,0,1,countryid);
            }
            else if (ddlTeamCathegory.SelectedIndex == 1 && ddlTeamType.SelectedIndex == 2)
            {
               // LoadAllPlayersGrid(teamid, 0, 1, countryid); ////male and Club
                LoadTeamPlayersGrid(teamid, 0, 0, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 0, 0, countryid);

            }
            else if (ddlTeamCathegory.SelectedIndex == 2 && ddlTeamType.SelectedIndex == 1)
            {
               // LoadAllPlayersGrid(teamid, 1, 0, countryid); //female and national team
                LoadTeamPlayersGrid(teamid, 1, 1, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 1, 1, countryid);
            }
            else if (ddlTeamCathegory.SelectedIndex == 2 && ddlTeamType.SelectedIndex == 2)
            {
               // LoadAllPlayersGrid(teamid, 1, 1, countryid); //female and club
                LoadTeamPlayersGrid(teamid, 1, 0, countryid);
                LoadAllNotTeamPlayersGrid(teamid, 1, 0, countryid);
            }
        }

        protected void ddlContinent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlConfederations_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCountries_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlStadiums_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPosition_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlGenrePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpdateTeam_Click(object sender, EventArgs e)
        {
            //update the team.
            if (ddlTeamname.SelectedIndex == 0)
            {

            }
            else
            {
                if (txbFullName.Text.Length > 0 && txtShortName.Text.Length > 0 && ddlTeamCathegory.SelectedIndex > 0
                    && ddlTeamType.SelectedIndex > 0 && ddlTeamCountry.SelectedIndex > 0 && ddlTeamStadium.SelectedIndex > 0)
                {

                    if (fuFlag.PostedFile.ContentType == "image/jpeg" || fuFlag.PostedFile.ContentType == "image/png"
                    || fuFlag.PostedFile.ContentType == "image/bmp" || fuFlag.PostedFile.ContentType == "image/jpg")
                    {
                        string filename = Path.GetFileName(fuFlag.FileName);
                        fuFlag.SaveAs(@"C:\fut-all\players_pics\" + filename);

                        string pflag = @"C:\fut-all\players_pics\" + filename;
                        int teamcountry_id = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
                        int teamstadium_id = ws.Stadium_Id_Get(ddlTeamStadium.SelectedItem.Text);
                        int teamid = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
                        int category_id = 0;
                        int type_id = 0;

                        if (ddlTeamType.SelectedIndex == 2)
                        {
                            type_id = 1; // club team
                        }
                        if (ddlTeamCathegory.SelectedIndex == 2)
                        {
                            category_id = 1; // women team
                        }

                        ws.Team_Upd(Convert.ToInt32(teamid), txbFullName.Text.Trim(), txtShortName.Text.Trim(), category_id, type_id, teamcountry_id, teamstadium_id, pflag);

                        txbFullName.Text = "";
                        txtShortName.Text = "";
                        ddlTeamCathegory.SelectedIndex = 0;
                        ddlTeamType.SelectedIndex = 0;
                        ddlTeamCountry.SelectedIndex = 0;
                        ddlTeamStadium.SelectedIndex = 0;
                        LoadTeams();

                    }
                }
            }
        }


        protected void btnInsertPlayer_Click(object sender, EventArgs e)
        {
            
            int teamid = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
            foreach (GridViewRow row in grvAllPlayers.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkAll") as CheckBox);//the check cell of the gridview

                    //if the checkbox is checked means that the player will be insert in the team
                    if (chkRow.Checked)
                    {
                        //h
                        string nameplayergrid = row.Cells[1].Text;
                        string lastnameplayergrid = row.Cells[2].Text;
                        int idplayergrid = ws.Player_Id_Get(nameplayergrid, lastnameplayergrid);
                        ws.PlayerxTeam_Ins(idplayergrid, teamid);
                    }
                }
            }

            grvAllPlayers.DataSource = null;
            grvAllPlayers.DataBind();
        }

        protected void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            int teamid = ws.Team_Id_Get(ddlTeamname.SelectedItem.Text);
            foreach (GridViewRow row in grvPlayers.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkplayer") as CheckBox);//the check cell of the gridview
                   
                    //if the checkbox is checked means that the player will be delete from the team
                    if (chkRow.Checked)
                    {
                        //h
                        string nameplayergrid = row.Cells[1].Text;
                        string lastnameplayergrid = row.Cells[2].Text;
                        int idplayergrid = ws.Player_Id_Get(nameplayergrid, lastnameplayergrid);
                        ws.PlayerxTeam_Del(idplayergrid, teamid);
                    }
                }
            }

            grvPlayers.DataSource = null;
            grvPlayers.DataBind();
            LoadPlayers();
        }
    }
}

    