using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Tourn_Cup_Match : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int role = ws.User_Role_Get(Convert.ToInt32(Session["user_id"]));
                int eventid = Convert.ToInt32(Request.QueryString["evId"]);
                int team1idl = Convert.ToInt32(Request.QueryString["team1Id"]);
                int team2idl = Convert.ToInt32(Request.QueryString["team2Id"]);
                
                lblteam1.Text = ws.Team_Name_Get(team1idl);
                string flag = ws.Team_Flag_Get(lblteam1.Text);
                byte[] bytes = File.ReadAllBytes(flag);
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                imgteam1.ImageUrl = "data:image/png;base64," + base64String;

                imgcardyellow1.ImageUrl = "Images/miniyellowcard.png";
                imgcardyellow2.ImageUrl = "Images/miniyellowcard.png";
                imgcardred1.ImageUrl = "Images/miniredcard.png";
                imgcardred2.ImageUrl = "Images/miniredcard.png";
                imgsaver1.ImageUrl = "Images/minisaver.png";
                imgsaver2.ImageUrl = "Images/minisaver.png";
                imgcorner2.ImageUrl = "Images/minicorner.png";
                imgcorner1.ImageUrl = "Images/minicorner.png";
                lblteam2.Text = ws.Team_Name_Get(team2idl);
                string flag2 = ws.Team_Flag_Get(lblteam2.Text);
                byte[] bytes2 = File.ReadAllBytes(flag2);
                string base64String2 = Convert.ToBase64String(bytes2, 0, bytes2.Length);
                imgteam2.ImageUrl = "data:image/png;base64," + base64String2;

                LoadGoals(team1idl, team2idl);
                
                if (role == 1)
                {
                    lbladmin.Text = "Admin";
                    refadmin.HRef = "Insert_admins.aspx";

                }
                else
                {
                    lbladmin.Text = "";
                    tbladmin.Visible = false;
                    txtmatchdatetime.Enabled = false;
                    ddlstadiums.Enabled = false;
                    txbCorners1.Enabled = false;
                    txbCorners2.Enabled = false;
                    txbSaver1.Enabled = false;
                    txbSaver2.Enabled = false;
                }
                string val1 = Request.QueryString["team1Id"].ToString();
                int team1id = Convert.ToInt32(val1);
                string val2 = Request.QueryString["team2Id"].ToString();
                int team2id = Convert.ToInt32(val2);
                int matchid = ws.TournMatch_Id_Get(team1id,team2id);
                Session["match_id"] = ws.TournMatch_Id_Get(team1id, team2id);

                LoadCards(team1id, team2id);
                LoadCorners(team1id, team2id);
                LoadSavers(team1id, team2id);
                LoadStadiums(eventid);
                grvLoadTeam1(team1id);
                grvLoadTeam2(team2id);
                LoadPlayerst1(team1id);
                LoadPlayerst2(team2id);
                grvLoadGoalTeam1(team1id);
                grvLoadGoalTeam2(team2id);
                grvLoadCardsTeam1(team1id);
                grvLoadCardsTeam2(team2id);
                LoadCardColor();
                LoadDateTimeMatch(matchid);
                LoadMatchStadium(matchid);
                lbladdreplace.Font.Size = 12;
                lbladdreplacet2.Font.Size = 12;
                btnSaveAllChanges.Font.Size = 13;
            }
        }

        protected void LoadGoals(int team1idl, int team2idl)
        {
            int matchid = ws.TournMatch_Id_Get(team1idl, team2idl);
            int goal1 = ws.goalsxteam1_Get(matchid, team1idl);
            int goal2 = ws.goalsxteam2_Get(matchid, team2idl);
            lblgoal1.Text = Convert.ToString(goal1);
            lblgoal2.Text = Convert.ToString(goal2);
                
        }

        protected void LoadCorners(int team1idl, int team2idl)
        {
            int matchid = ws.TournMatch_Id_Get(team1idl, team2idl);
            int corner1 = ws.cornersxteam1_Get(matchid, team1idl);
            int corner2 = ws.cornersxteam2_Get(matchid, team2idl);
            txbCorners1.Text = Convert.ToString(corner1);
            txbCorners2.Text = Convert.ToString(corner2);

        }

        protected void LoadSavers(int team1idl, int team2idl)
        {
            int matchid = ws.TournMatch_Id_Get(team1idl, team2idl);
            int saver1 = ws.saversxteam1_Get(matchid, team1idl);
            int saver2 = ws.saversxteam2_Get(matchid, team2idl);
            txbSaver1.Text = Convert.ToString(saver1);
            txbSaver2.Text = Convert.ToString(saver2);

        }

        protected void LoadCards(int team1idl, int team2idl)
        {
            int matchid = ws.TournMatch_Id_Get(team1idl, team2idl);
            int yellow1 = ws.cardsxteam_Get(matchid, team1idl, 0);
            int yellow2 = ws.cardsxteam_Get(matchid, team2idl, 0);
            int red1 = ws.cardsxteam_Get(matchid, team1idl, 1);
            int red2 = ws.cardsxteam_Get(matchid, team2idl, 1);
            lblcardyellow2.Text = Convert.ToString(yellow2);
            lblcardred2.Text = Convert.ToString(red2);
            lblCardyellow1.Text = Convert.ToString(yellow1);
            lblCardRed1.Text = Convert.ToString(red1);

        }

        private void LoadStadiums(int eventid)
        {
            ddlstadiums.Items.Clear();
            ddlstadiums.Items.Add("-Select Stadium-");

            List<string> theList = ws.StadiumxEvent_Get(eventid);

            foreach (string g in theList)
            {
                ddlstadiums.Items.Add(g);
            }
        }

        private void LoadDateTimeMatch(int matchid)
        {            
            string indate = ws.MatchDateTime_Get(matchid);
            if (!indate.Equals(""))
            {
                DateTime datetime = Convert.ToDateTime(indate);
                string date = datetime.ToString("MM/dd/yyyy");
                txtmatchdatetime.Text = date;
            }            
        }

        private void LoadMatchStadium(int matchid)
        {
            string sta = ws.MatchStadium_Get(matchid);
            for (int i = 0; i < ddlstadiums.Items.Count; i++)
            {
                if (ddlstadiums.Items[i].Text.Equals(sta))
                {
                    ddlstadiums.SelectedIndex = i;
                }
            }
            
        }

        private void LoadCardColor()
        {
            ddlColorT1.Items.Clear();
            ddlColorT1.Items.Add("-Select the card color");
            ddlColorT1.Items.Add("Red");
            ddlColorT1.Items.Add("Yellow");

            ddlColorT2.Items.Clear();
            ddlColorT2.Items.Add("-Select the card color");
            ddlColorT2.Items.Add("Red");
            ddlColorT2.Items.Add("Yellow");
        }

        private void LoadPlayerst2(int team2id)
        {
            ddlplayernamet2.Items.Clear();
            ddlplayernamet2.Items.Add("-Select Player-");
            ddlreplacenamet2.Items.Clear();
            ddlreplacenamet2.Items.Add("-Select Replace-");
            ddlGoalPlayert2.Items.Clear();
            ddlGoalPlayert2.Items.Add("-Select Player-");
            ddlCardst2.Items.Clear();
            ddlCardst2.Items.Add("-Select Player-");

             
            List<string> ListPlayers = ws.fnTournTeamPlayers_Get(team2id);
            foreach (string g in ListPlayers)
            {
                ddlplayernamet2.Items.Add(g);
                ddlreplacenamet2.Items.Add(g);
                ddlGoalPlayert2.Items.Add(g);
                ddlCardst2.Items.Add(g);
            }
        }

        private void LoadPlayerst1(int team1id)
        {
            ddlplayernamet1.Items.Clear();
            ddlplayernamet1.Items.Add("-Select Player-");
            ddlreplacenamet1.Items.Clear();
            ddlreplacenamet1.Items.Add("-Select Replace-");
            ddlGoalPlayert1.Items.Clear();
            ddlGoalPlayert1.Items.Add("-Select Player-");
            ddlCardst1.Items.Clear();
            ddlCardst1.Items.Add("-Select Player-");


            List<string> ListPlayers = ws.fnTournTeamPlayers_Get(team1id);
            foreach (string g in ListPlayers)
            {   
                ddlplayernamet1.Items.Add(g);
                ddlreplacenamet1.Items.Add(g);
                ddlGoalPlayert1.Items.Add(g);
                ddlCardst1.Items.Add(g);
            }
        }

        protected void grvLoadTeam1(int idteam){

            int counter = 0;
            List<string> theList = ws.FnTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;
            string lastnameplayer = string.Empty;
            string positionplayer = string.Empty;

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");
            tb.Columns.Add("Last Name");
            tb.Columns.Add("Position");
            tb.Columns.Add("Replace Name");

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
                    positionplayer = g;
                    tb.Rows.Add(nameplayer, lastnameplayer, positionplayer);
                    counter = -1;
                }

                counter++;
            }

            grvTeam1.DataSource = tb;
            grvTeam1.DataBind();
        }

        protected void grvLoadTeam2(int idteam)
        {
            //llenar grid with players.
             int counter = 0;
            List<string> theList = ws.FnTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;
            string lastnameplayer = string.Empty;
            string positionplayer = string.Empty;

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");
            tb.Columns.Add("Last Name");
            tb.Columns.Add("Position");
            tb.Columns.Add("Replace Name");

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
                    positionplayer = g;
                    tb.Rows.Add(nameplayer, lastnameplayer, positionplayer);
                    counter = -1;
                }

                counter++;
            }

            grvTeam2.DataSource = tb;
            grvTeam2.DataBind();
        }

        protected void grvLoadGoalTeam1(int idteam)
        {
            //llenar grid with players.
            int counter = 0;
            List<string> theList = ws.fnTournTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;
     

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Player Name");

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;
              
                    tb.Rows.Add(nameplayer);
                    counter = -1;
                }

                counter++;
            }

            grvGoalsT1.DataSource = tb;
            grvGoalsT1.DataBind();
        }

        protected void grvLoadGoalTeam2(int idteam)
        {
            //llenar grid with players.
            int counter = 0;
            List<string> theList = ws.fnTournTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;
       

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Player Name");
   

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;
                    tb.Rows.Add(nameplayer);
                    counter = -1;
                }
                counter++;
            }
            grvGoalsT2.DataSource = tb;
            grvGoalsT2.DataBind();
        }

        protected void grvLoadCardsTeam1(int idteam)
        {
            //llenar grid with players.
            int counter = 0;
            List<string> theList = ws.fnTournTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;


            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Player Name");

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;

                    tb.Rows.Add(nameplayer);
                    counter = -1;
                }

                counter++;
            }

            grvCardsT1.DataSource = tb;
            grvCardsT1.DataBind();
        }

        protected void grvLoadCardsTeam2(int idteam)
        {
            //llenar grid with players.
            int counter = 0;
            List<string> theList = ws.fnTournTeamPlayers_Get(idteam);
            string nameplayer = string.Empty;


            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Player Name");

            foreach (string g in theList)
            {
                if (counter == 0)
                {
                    nameplayer = g;

                    tb.Rows.Add(nameplayer);
                    counter = -1;
                }

                counter++;
            }

            grvCardsT2.DataSource = tb;
            grvCardsT2.DataBind();
        }

        protected void btnaddreplace_Click(object sender, EventArgs e)
        {
            int thePlayerId = ws.Player_Id_Get(ddlplayernamet1.SelectedItem.Text);
            int theReplacePlayerId = ws.Player_Id_Get(ddlreplacenamet1.SelectedItem.Text);
            if (ddlplayernamet1.SelectedIndex > 0 && ddlreplacenamet1.SelectedIndex > 0)
            {
                if (txtreptimet1.Text.Length > 0)
                {
                    foreach (GridViewRow row in grvTeam1.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkplayert1") as CheckBox);//the check cell of the gridview
                             TextBox txt =   (row.Cells[2].FindControl("txtrepltimet1") as TextBox);
                             txt.Width = 23;
                            string[] playername = ddlplayernamet1.SelectedItem.Text.Split(' ');
                            string name = playername[0];
                            string replacename = ddlreplacenamet1.SelectedItem.Text;
                            if(row.Cells[1].Text.Equals(name))
                            {
                                chkRow.Checked = true;
                                 txt.Text = txtreptimet1.Text;
                                 row.Cells[4].Text = replacename;
                            }
                            
                                
                            }
                        }
                    } 
                }
            }

        protected void btnaddreplacet2_Click(object sender, EventArgs e)
        {
            int thePlayerId = ws.Player_Id_Get(ddlplayernamet2.SelectedItem.Text);
            int theReplacePlayerId = ws.Player_Id_Get(ddlreplacenamet2.SelectedItem.Text);
            if (ddlplayernamet2.SelectedIndex > 0 && ddlreplacenamet2.SelectedIndex > 0)
            {
                if (txtreptimet2.Text.Length > 0)
                {
                    foreach (GridViewRow row in grvTeam2.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkplayert2") as CheckBox);//the check cell of the gridview
                            TextBox txt = (row.Cells[2].FindControl("txtrepltimet2") as TextBox);
                            txt.Width = 23;
                            string[] playername = ddlplayernamet2.SelectedItem.Text.Split(' ');
                            string name = playername[0];
                            string replacename = ddlreplacenamet2.SelectedItem.Text;
                            if (row.Cells[1].Text.Equals(name))
                            {
                                chkRow.Checked = true;
                                txt.Text = txtreptimet2.Text;
                                row.Cells[4].Text = replacename;
                            }


                        }
                    }
                }
            }
          
        }

        protected void btnaddgoalt1_Click(object sender, EventArgs e)
        {
        
            if (ddlGoalPlayert1.SelectedIndex > 0)
            {
                if (txtGoalMinutet1.Text.Length > 0)
                {
                    foreach (GridViewRow row in grvGoalsT1.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            TextBox txt = (row.Cells[0].FindControl("txtGoalt1") as TextBox);
                            txt.Width = 23;
                            string playername = ddlGoalPlayert1.SelectedItem.Text;
                            
                            if (row.Cells[1].Text.Equals(playername))
                            {
                                txt.Text = txtGoalMinutet1.Text;
                            
                            }


                        }
                    }
                }
            }
        }

        protected void btnAddCardT1_Click(object sender, EventArgs e)
        {
            string cardcolor = "";
            if (ddlCardst1.SelectedIndex > 0 && CardMinuteT1.Text.Length > 0)
            {
                if (ddlColorT1.SelectedIndex == 1)
                {
                    cardcolor = ddlColorT1.SelectedItem.Text;
                }
                else if(ddlColorT1.SelectedIndex == 2){
                    cardcolor = ddlColorT1.SelectedItem.Text;
                }
    
                    foreach (GridViewRow row in grvCardsT1.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            TextBox txtcolor = (row.Cells[0].FindControl("txtCardcolort1") as TextBox);
                            TextBox txtminute = (row.Cells[0].FindControl("txtCardminutet1") as TextBox);
                            string playername = ddlCardst1.SelectedItem.Text;

                            if (row.Cells[1].Text.Equals(playername))
                            {
                                txtcolor.Text = cardcolor;
                                txtminute.Text =  CardMinuteT1.Text;

                            }
                        }
                    }
            }
        }

        protected void btnAddCardT2_Click(object sender, EventArgs e)
        {
            string cardcolor = "";
            if (ddlCardst2.SelectedIndex > 0 && CardMinuteT2.Text.Length > 0)
            {
                if (ddlColorT2.SelectedIndex == 1)
                {
                    cardcolor = ddlColorT2.SelectedItem.Text;
                }
                else if(ddlColorT2.SelectedIndex == 2){
                    
                    cardcolor = ddlColorT2.SelectedItem.Text;
                }
    
                    foreach (GridViewRow row in grvCardsT2.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            TextBox txtcolor = (row.Cells[0].FindControl("txtCardcolort2") as TextBox);
                            TextBox txtminute = (row.Cells[0].FindControl("txtCardminutet2") as TextBox);
                            string playername = ddlCardst2.SelectedItem.Text;

                            if (row.Cells[1].Text.Equals(playername))
                            {
                                txtcolor.Text = cardcolor;
                                txtminute.Text =  CardMinuteT2.Text;

                            }
                        }
                    }
            }
        }

        protected void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            if(txtmatchdatetime.Text.Length > 0 && ddlstadiums.SelectedIndex > 0 && txbCorners1.Text.Length > 0 
                && txbCorners2.Text.Length > 0 && txbSaver1.Text.Length > 0 && txbSaver2.Text.Length > 0)
            {
                int stadium_id = ws.Stadium_Id_Get(ddlstadiums.SelectedItem.Text);
                DateTime datetime = Convert.ToDateTime(txtmatchdatetime.Text);
                string date = datetime.ToString("MM/dd/yyyy");
                ws.TournMatch_Upd(Convert.ToInt32(Session["match_id"]), date, stadium_id, Convert.ToInt32(txbCorners1.Text),
                    Convert.ToInt32(txbCorners2.Text), Convert.ToInt32(txbSaver1.Text), Convert.ToInt32(txbSaver2.Text));

                foreach (GridViewRow row in grvTeam1.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox AlignPlayer = (row.Cells[0].FindControl("chkplayert1") as CheckBox);//the check cell of the gridview
                        CheckBox Iscaptain = (row.Cells[1].FindControl("chkiscaptt1") as CheckBox);
                        TextBox repPlayer = (row.Cells[2].FindControl("txtrepltimet1") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (AlignPlayer.Checked && Iscaptain.Checked && !(repPlayer.Text.Equals(""))) //captain , is in the aligment and exist a replace
                        { 
                            string[] replacedplayer = row.Cells[4].Text.Split(' ');
                            string realplayername = string.Empty;
                            string realplayerlastname = string.Empty;
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            string replacedtime = repPlayer.Text;
                            if(replacedplayer.Length > 0)
                            {
                                realplayername = replacedplayer[0];
                                realplayerlastname = replacedplayer[1];
                                int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                                int replaplayerid = ws.Player_Id_Get(realplayername, realplayerlastname);
                                ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 1, replaplayerid, Convert.ToInt32(replacedtime));
                            }

                        }   
                            else if(AlignPlayer.Checked && Iscaptain.Checked && repPlayer.Text.Equals("")){

                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 1, 0, Convert.ToInt32(0));
                            }
                        else if(AlignPlayer.Checked  && Iscaptain.Checked != true && repPlayer.Text.Equals(""))
                        {
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 0, 0, Convert.ToInt32(0));
                        }
                        else if (AlignPlayer.Checked && Iscaptain.Checked != true && !(repPlayer.Text.Equals("")))
                        {
                            string[] replacedplayer = row.Cells[4].Text.Split(' ');
                            string realplayername = replacedplayer[0];
                            string realplayerlastname = replacedplayer[1];
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            string replacedtime = repPlayer.Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            int replaplayerid = ws.Player_Id_Get(realplayername, realplayerlastname);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 0, replaplayerid, Convert.ToInt32(replacedtime));
                        }
                       
                           
                        }
                    }

                foreach (GridViewRow row in grvTeam2.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        CheckBox AlignPlayer = (row.Cells[0].FindControl("chkplayert2") as CheckBox);//the check cell of the gridview
                        CheckBox Iscaptain = (row.Cells[1].FindControl("chkiscaptt2") as CheckBox);
                        TextBox repPlayer = (row.Cells[2].FindControl("txtrepltimet2") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (AlignPlayer.Checked && Iscaptain.Checked && !(repPlayer.Text.Equals(""))) //captain , is in the aligment and exist a replace
                        {
                            string[] replacedplayer = row.Cells[4].Text.Split(' ');
                            string realplayername = string.Empty;
                            string realplayerlastname = string.Empty;
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            string replacedtime = repPlayer.Text;
                            if (replacedplayer.Length > 0)
                            {
                                realplayername = replacedplayer[0];
                                realplayerlastname = replacedplayer[1];
                                int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                                int replaplayerid = ws.Player_Id_Get(realplayername, realplayerlastname);
                                ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 1, replaplayerid, Convert.ToInt32(replacedtime));
                            }

                        }
                        else if (AlignPlayer.Checked && Iscaptain.Checked && repPlayer.Text.Equals(""))
                        {

                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 1, 0, Convert.ToInt32(0));
                        }
                        else if (AlignPlayer.Checked && Iscaptain.Checked != true && repPlayer.Text.Equals(""))
                        {
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 0, 0, Convert.ToInt32(0));
                        }
                        else if (AlignPlayer.Checked && Iscaptain.Checked != true && !(repPlayer.Text.Equals("")))
                        {
                            string[] replacedplayer = row.Cells[4].Text.Split(' ');
                            string realplayername = replacedplayer[0];
                            string realplayerlastname = replacedplayer[1];
                            string nameplayergrid = row.Cells[1].Text;
                            string lastnamegrid = row.Cells[2].Text;
                            string replacedtime = repPlayer.Text;
                            int playerid = ws.Player_Id_Get(nameplayergrid, lastnamegrid);
                            int replaplayerid = ws.Player_Id_Get(realplayername, realplayerlastname);
                            ws.Aligment_Ins(playerid, Convert.ToInt32(Session["match_id"]), 0, replaplayerid, Convert.ToInt32(replacedtime));
                        }


                    }
                }

                foreach (GridViewRow row in grvGoalsT1.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox goalmin = (row.Cells[0].FindControl("txtGoalt1") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (!goalmin.Text.Equals(""))
                        {

                            string[] nameplayergrid = row.Cells[1].Text.Split(' ');
                            string realname = nameplayergrid[0];
                            string lastname = nameplayergrid[1];
                            int playerid = ws.Player_Id_Get(realname, lastname);
                            string min = goalmin.Text;
                            int matchid = Convert.ToInt32(Session["match_id"]);
                            ws.Goal_Ins(Convert.ToInt32(min), playerid, Convert.ToInt32(matchid));
                        }
                    }
                }
                foreach (GridViewRow row in grvGoalsT2.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox goalmin = (row.Cells[0].FindControl("txtGoalt2") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (!goalmin.Text.Equals(""))
                        {
                            string[] nameplayergrid = row.Cells[1].Text.Split(' ');
                            string realname = nameplayergrid[0];
                            string lastname = nameplayergrid[1];
                            int playerid = ws.Player_Id_Get(realname, lastname);
                            string min = goalmin.Text;
                            int matchid = Convert.ToInt32(Session["match_id"]);
                            ws.Goal_Ins(Convert.ToInt32(min), playerid, Convert.ToInt32(matchid));
                        }
                    }
                }
                foreach (GridViewRow row in grvCardsT1.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox color = (row.Cells[0].FindControl("txtCardcolort1") as TextBox);
                        TextBox min = (row.Cells[0].FindControl("txtCardminutet1") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (!color.Text.Equals("") && !(min.Text.Equals("")))
                        {
                            string[] nameplayergrid = row.Cells[1].Text.Split(' ');
                            string realname = nameplayergrid[0];
                            string lastname = nameplayergrid[1];
                            string cardcolor = color.Text;
                            string minute = min.Text;
                            int playerid = ws.Player_Id_Get(realname, lastname);
                            int matchid = Convert.ToInt32(Session["match_id"]);
                            int colorbit = 0;
                            if (cardcolor.Equals("Yellow"))
                            {
                                colorbit = 0;
                            }
                            else if (cardcolor.Equals("Red"))
                            {
                                colorbit = 1;
                            }
                            ws.Card_Ins(Convert.ToInt32(matchid), colorbit, Convert.ToInt32(minute), playerid);
                        }
                    }
                }
                foreach (GridViewRow row in grvCardsT2.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        TextBox color = (row.Cells[0].FindControl("txtCardcolort2") as TextBox);
                        TextBox min = (row.Cells[0].FindControl("txtCardminutet2") as TextBox);
                        //if the checkbox is checked means that the player will be insert in the team
                        if (!color.Text.Equals("") && !(min.Text.Equals("")))
                        {
                            string[] nameplayergrid = row.Cells[1].Text.Split(' ');
                            string realname = nameplayergrid[0];
                            string lastname = nameplayergrid[1];
                            string cardcolor = color.Text;
                            string minute = min.Text;
                            int playerid = ws.Player_Id_Get(realname, lastname);
                            int matchid = Convert.ToInt32(Session["match_id"]);
                            int colorbit = 0;
                            if (cardcolor.Equals("Yellow"))
                            {
                                colorbit = 0;
                            }
                            else if (cardcolor.Equals("Red"))
                            {
                                colorbit = 1;
                            }
                            ws.Card_Ins(Convert.ToInt32(matchid), colorbit, Convert.ToInt32(minute), playerid);
                        }
                    }
                }
                ddlCardst1.SelectedIndex = 0;
                ddlCardst2.SelectedIndex = 0;
                ddlColorT1.SelectedIndex = 0;
                ddlColorT2.SelectedIndex = 0;
                ddlGoalPlayert1.SelectedIndex = 0;
                ddlGoalPlayert2.SelectedIndex = 0;
                ddlplayernamet1.SelectedIndex = 0;
                ddlplayernamet2.SelectedIndex = 0;
                ddlreplacenamet1.SelectedIndex = 0;
                ddlreplacenamet2.SelectedIndex = 0;
                CardMinuteT1.Text = "";
                CardMinuteT2.Text = "";
                txtGoalMinutet2.Text = "";
                txtGoalMinutet1.Text = "";
                txtreptimet2.Text = "";
                txtreptimet1.Text = "";

                }
                                     
    }
        
        protected void btnaddgoalt2_Click(object sender, EventArgs e)
        {
            if (ddlGoalPlayert2.SelectedIndex > 0)
            {
                if (txtGoalMinutet2.Text.Length > 0)
                {
                    foreach (GridViewRow row in grvGoalsT2.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {

                            TextBox txt = (row.Cells[0].FindControl("txtGoalt2") as TextBox);
                            txt.Width = 23;
                            string playername = ddlGoalPlayert2.SelectedItem.Text;

                            if (row.Cells[1].Text.Equals(playername))
                            {
                                txt.Text = txtGoalMinutet2.Text;
                            }
                        }
                    }
                }
            }
        }
    }
}