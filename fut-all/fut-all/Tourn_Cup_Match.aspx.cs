using System;
using System.Collections.Generic;
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
                string val1 = Request.QueryString["team1Id"].ToString();
                int team1id = Convert.ToInt32(val1);
                string val2 = Request.QueryString["team2Id"].ToString();
                int team2id = Convert.ToInt32(val2);
                grvLoadTeam1(team1id);
                grvLoadTeam2(team2id);
                LoadPlayerst1(team1id);
                LoadPlayerst2(team2id);
                lbladdreplace.Font.Size = 12;
                lbladdreplacet2.Font.Size = 12;
                lblGoalst1.Font.Size = 12;
                lblGoalst2.Font.Size = 12;
                lblCardst1.Font.Size = 12;
                lblCardst2.Font.Size = 12;
                btnSaveAllChanges.Font.Size = 13;
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {
        }


         private void LoadPlayerst2(int team2id)
        {
            ddlplayernamet2.Items.Clear();
            ddlplayernamet2.Items.Add("-Select Player-");
            ddlreplacenamet2.Items.Clear();
            ddlreplacenamet2.Items.Add("-Select Replace-");


            List<string> ListPlayers = ws.FnTeamPlayers_Get(team2id);
            foreach (string g in ListPlayers)
            {
                ddlplayernamet2.Items.Add(g);
                ddlreplacenamet2.Items.Add(g);
            }
        }

        private void LoadPlayerst1(int team1id)
        {
            ddlplayernamet1.Items.Clear();
            ddlplayernamet1.Items.Add("-Select Player-");
            ddlreplacenamet1.Items.Clear();
            ddlreplacenamet1.Items.Add("-Select Replace-");


            List<string> ListPlayers = ws.FnTeamPlayers_Get(team1id);
            foreach (string g in ListPlayers)
            {
                ddlplayernamet1.Items.Add(g);
                ddlreplacenamet1.Items.Add(g);
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


        protected void btnaddreplace_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddreplacet1_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddreplacet2_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddgoalt1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddCardT1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddCardT2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            string datetimematch = txtmatchdatetime.Text;
            string stadiummatch = txtmatchstadium.Text;

        }
    }
}