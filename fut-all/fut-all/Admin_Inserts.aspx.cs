using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContinents();
                LoadConfederations();
                LoadPositions();
                LoadGenres();
                LoadCountries();
                LoadCathegories();
                LoadTeamTypes();
                LoadStadiums();                
            }
        }

        protected void btnAddcontinent_Click(object sender, EventArgs e)
        {
            if(txbContinent.Text.Length > 0){
                ws.Continent_Ins(txbContinent.Text);
                txbContinent.Text = "";
                LoadContinents();
            } 
        }

        protected void ddlContinents_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddConfederation_Click(object sender, EventArgs e)
        {
            if (ddlContinents.SelectedIndex > 0)
            {
                if (txbConfederation.Text.Length > 0)
                {
                    int theId = ws.Continent_Id_Get(ddlContinents.SelectedItem.Text);
                    ws.Confederation_Ins(txbConfederation.Text, theId);
                    txbConfederation.Text = "";
                    LoadConfederations();
                }
            }
        }

        protected void ddlConfederations_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddCountry_Click(object sender, EventArgs e)
        {
            if (ddlConfederations.SelectedIndex > 0)
            {
                if (txbCountry.Text.Length > 0)
                {
                    int theId = ws.Confederation_Id_Get(ddlConfederations.SelectedItem.Text);
                    ws.Country_Ins(txbCountry.Text, theId);
                    txbCountry.Text = "";
                    LoadCountries();
                }
            }
        }

        protected void btnAddStadium_Click(object sender, EventArgs e)
        {
            if (txbStadium.Text.Length > 0)
            {
                ws.Stadium_Ins(txbStadium.Text);
                txbStadium.Text = "";
                LoadStadiums();
            }
        }

        protected void ddlPosition_TextChanged(object sender, EventArgs e)
        {

        }


        protected void ddlType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlGenrePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged1(object sender, EventArgs e)
        {
            int countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
            if (ddlTeamType.SelectedIndex == 1 && ddlTeamCathegory.SelectedIndex == 1)
            {
                LoadPlayers(0, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 2)
            {
                LoadPlayers(1, 0, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 1 && ddlTeamCathegory.SelectedIndex == 2)
            {

                LoadPlayers(1, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 1)
            {

                LoadPlayers(0, 0, countryid);
            }
        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {
            int countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
           if (ddlTeamCathegory.SelectedIndex == 1 && ddlTeamType.SelectedIndex == 1)
            {
                LoadPlayers(0, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 2)
            {
                LoadPlayers(1, 0, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 1 && ddlTeamCathegory.SelectedIndex == 2)
            {

                LoadPlayers(1, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 1)
            {

                LoadPlayers(0, 0, countryid);
            }
        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

            int countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
            if (ddlTeamType.SelectedIndex == 1 && ddlTeamCathegory.SelectedIndex == 1)
            {
                LoadPlayers(0, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 2)
            {
                LoadPlayers(1, 0, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 1 && ddlTeamCathegory.SelectedIndex == 2)
            {

                LoadPlayers(1, 1, countryid);
            }
            else if (ddlTeamType.SelectedIndex == 2 && ddlTeamCathegory.SelectedIndex == 1)
            {

                LoadPlayers(0, 0, countryid);
            }
            
            
               
          
        }

        protected void btnAddPlayer_Click1(object sender, EventArgs e)
        {
            if (txbPName.Text.Length > 0 && txbPLastName.Text.Length > 0 && txbPPassport.Text.Length > 0
                && txbShirtNumber.Text.Length > 0 && ddlPosition.SelectedIndex > 0 && 
                ddlGenrePlayer.SelectedIndex > 0 && fuPicture.HasFile && ddlPlayerCountry.SelectedIndex>0)
            {
                if (fuPicture.PostedFile.ContentType == "image/jpeg" || fuPicture.PostedFile.ContentType == "image/png"
                    || fuPicture.PostedFile.ContentType == "image/bmp" || fuPicture.PostedFile.ContentType == "image/jpg")
                {
                    string filename = Path.GetFileName(fuPicture.FileName);
                    fuPicture.SaveAs(@"C:\fut-all\players_pics\" + filename);

                    string  pphoto =  @"C:\fut-all\players_pics\" + filename;
                    int cou_id = ws.Country_Id_Get(ddlPlayerCountry.SelectedItem.Text);
                    int pos_id = ws.Position_Id_Get(ddlPosition.SelectedItem.Text);
                    int gen_id = 0;
                    if(ddlGenrePlayer.SelectedIndex == 2){
                        gen_id = 1;
                    }                
                    ws.Player_Ins(txbPName.Text, txbPLastName.Text, Convert.ToInt32(txbPPassport.Text), Convert.ToInt32(txbShirtNumber.Text), Convert.ToInt32(cou_id), pphoto, Convert.ToInt32(pos_id), Convert.ToInt32(gen_id));
                    txbPName.Text = "";
                    txbPLastName.Text = "";
                    txbPPassport.Text = "";
                    txbShirtNumber.Text = "";
                    ddlPosition.SelectedIndex = 0;
                    ddlGenrePlayer.SelectedIndex = 0;
                    ddlPlayerCountry.SelectedIndex = 0;
                    LoadPlayers(ddlTeamCathegory.SelectedIndex, ddlTeamType.SelectedIndex, ddlTeamCountry.SelectedIndex);
                }
             
            }
            else
            {
                string script = "alert(\"Please complete and select all the fields. Try again!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        protected void btnAddTeam_Click(object sender, EventArgs e)
        {
            if(txbFullName.Text.Length > 0 && txtShortName.Text.Length > 0 && ddlTeamCathegory.SelectedIndex > 0
                && ddlTeamType.Text.Length > 0 && ddlTeamCountry.Text.Length > 0 && ddlTeamStadium.SelectedIndex > 0 && fuFlag.HasFile)
            {

                if (fuFlag.PostedFile.ContentType == "image/jpeg" || fuFlag.PostedFile.ContentType == "image/png"
                    || fuFlag.PostedFile.ContentType == "image/bmp" || fuFlag.PostedFile.ContentType == "image/jpg")
                {
                    string filename = Path.GetFileName(fuFlag.FileName);
                    fuFlag.SaveAs(@"C:\fut-all\teams_flags\" + filename);

                    string pphoto = @"C:\fut-all\teams_flags\" + filename;

                    int counId = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
                    int staId = ws.Stadium_Id_Get(ddlTeamStadium.SelectedItem.Text);
                    int cat = 0;
                    int type = 0;

                    if(ddlTeamCathegory.SelectedIndex == 2){
                        cat = 1;
                    }
                    if(ddlTeamType.SelectedIndex == 2){
                        type = 1;
                    }
                    int playersquant = 0;

                    foreach (GridViewRow row in grvPlayers.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkplayer") as CheckBox);

                            if (chkRow.Checked)
                            {
                                playersquant = playersquant + 1;
                            }
                        }
                    }
                    if (playersquant >= 1) ///// 14 players are needed
                    {
                        int teamid = ws.Team_Ins(txbFullName.Text.Trim(), txtShortName.Text.Trim(), cat, type, counId, staId, pphoto);

                        foreach (GridViewRow row in grvPlayers.Rows)
                        {
                            if (row.RowType == DataControlRowType.DataRow)
                            {
                                CheckBox chkRow = (row.Cells[0].FindControl("chkplayer") as CheckBox);

                                if (chkRow.Checked)
                                {
                                    string nameplayer = row.Cells[1].Text;
                                    string lastnameplayer = row.Cells[2].Text;
                                    int idplayer = ws.Player_Id_Get(nameplayer, lastnameplayer);
                                    ws.PlayerxTeam_Ins(idplayer, teamid);

                                }
                            }
                        }  
                    }
                    else
                    {

                        string script = "alert(\"The team needs at least 14 players. Try again!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                }

                txbFullName.Text = "";
                txtShortName.Text = "";
                ddlTeamCathegory.SelectedIndex = 0;
                ddlTeamCountry.SelectedIndex = 0;
                ddlTeamStadium.SelectedIndex = 0;
                ddlTeamType.SelectedIndex = 0;
                grvPlayers.DataSource = null;
                grvPlayers.DataBind();
                
            }
            else
            {
                string script = "alert(\"Please complete and select all the fields. Try again!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        private void LoadContinents()
        {
            ddlContinents.Items.Clear();
            ddlContinents.Items.Add("-Select Continent-");

            List<string> theList = ws.Continents_Get();

            foreach (string g in theList)
            {
                ddlContinents.Items.Add(g);
            }
        }

        private void LoadConfederations()
        {
            ddlConfederations.Items.Clear();
            ddlConfederations.Items.Add("-Select Confederation-");

            List<string> theList = ws.Confederations_Get();

            foreach (string g in theList)
            {
                ddlConfederations.Items.Add(g);
            }
        }

        private void LoadPositions()
        {
            ddlPosition.Items.Clear();
            ddlPosition.Items.Add("-Select Position-");

            List<string> theList = ws.Positions_Get();

            foreach (string g in theList)
            {
                ddlPosition.Items.Add(g);
            }
        }

        private void LoadGenres()
        {
            ddlGenrePlayer.Items.Clear();
            ddlGenrePlayer.Items.Add("-Select Genre-");
            ddlGenrePlayer.Items.Add("Male");  // id 0
            ddlGenrePlayer.Items.Add("Female"); // id 1
        }

        private void LoadCountries()
        {
            ddlPlayerCountry.Items.Clear();
            ddlPlayerCountry.Items.Add("-Select Country-");

            ddlTeamCountry.Items.Clear();
            ddlTeamCountry.Items.Add("-Select Country-");

            List<string> theList = ws.Countries_Get();

            foreach (string g in theList)
            {
                ddlPlayerCountry.Items.Add(g);
                ddlTeamCountry.Items.Add(g);
            }
        }

        private void LoadCathegories()
        {

            ddlTeamCathegory.Items.Clear();
            ddlTeamCathegory.Items.Add("-Select Category-");
            ddlTeamCathegory.Items.Add("Male");  // id 0
            ddlTeamCathegory.Items.Add("Female"); // id 1
        }

        private void LoadTeamTypes()
        {

            ddlTeamType.Items.Clear();
            ddlTeamType.Items.Add("-Select Type-");
            ddlTeamType.Items.Add("National Team");  // id 0
            ddlTeamType.Items.Add("Club"); // id 1
        }

        private void LoadStadiums()
        {
            ddlTeamStadium.Items.Clear();
            ddlTeamStadium.Items.Add("-Select Stadium-");

            List<string> theList = ws.Stadiums_Get();

            foreach (string g in theList)
            {
                ddlTeamStadium.Items.Add(g);
            }
        }

        private void LoadPlayers(int pgenre,int isnationalteam, int countryid)
        {
            if (ddlTeamType.SelectedIndex == 1)
            {
                isnationalteam = 1; //male team
            }
            else if (ddlTeamType.SelectedIndex == 2)
            {
                isnationalteam = 0; //female team
            }

            countryid = ws.Country_Id_Get(ddlTeamCountry.SelectedItem.Text);
            int counter = 0;
            List<string> theList = ws.Players_Get(pgenre,isnationalteam,countryid);
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
                if(counter == 0)
                {
                    nameplayer = g;
                }
                else if(counter == 1)
                {
                    lastnameplayer = g;
                }
                else if(counter == 2)
                {
                    tshirt = g;
                }
                else if(counter == 4)
                {
                    countryplayer = g;
                }
                else if(counter == 6)
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
    }
}