using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Tourn_Cup_Groups : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string val = Request.QueryString["evId"].ToString();
                int eventid = Convert.ToInt32(val);
                showPhases(eventid);
                LoadStadiums(eventid);
                LoadCountries(eventid);
                LoadGeneralstats(eventid);
                List<string> winners = ws.Winners_Get(eventid);
                if (winners.Count() > 0)
                {
                    lblChampion.Text = winners[0];
                    lblSubCham.Text = winners[1];
                    string flagcham = ws.Team_Flag_Get(lblChampion.Text);
                    string flagsub = ws.Team_Flag_Get(lblSubCham.Text);
                }
                
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void showPhases(int eventid)
        {
            // Total number of rows.
            int rowCnt = ws.Phases_Count(eventid);
            List<string> theList = ws.Phases_Get(eventid);
            
            for(int i = 0; i < rowCnt; i++)
            {
                int counter = theList.Where(s => s == theList[0]).Count();
                counter = counter * 2;

                TableRow tRow = new TableRow();
                tbl.Rows.Add(tRow);
                Panel pan = new Panel();
                TableCell tc = new TableCell();
                tRow.Cells.Add(tc);
                tc.Controls.Add(pan);
                Table intbl = new Table();
                intbl.Height = 80;
                pan.Controls.Add(intbl);
                pan.Attributes["class"] = "roundedChartTbl";
                
                TableRow tr = new TableRow();
                intbl.Controls.Add(tr);
                TableCell tCellGroup = new TableCell();
                tr.Cells.Add(tCellGroup);                
                Label lblGroup = new Label();
                lblGroup.Text = theList[0];
                tCellGroup.Width = 150;
                tCellGroup.VerticalAlign = VerticalAlign.Middle;
                tCellGroup.HorizontalAlign = HorizontalAlign.Center;

                int phaseid = ws.Phase_Id_Get(eventid, theList[0]);
                
                System.Web.UI.WebControls.HyperLink h = new HyperLink();
                h.Text = lblGroup.Text;
                h.Attributes["class"] = "lblFontName";
                h.NavigateUrl = "Tourn_Cup_Phase_Matches.aspx?evId=" + Convert.ToString(eventid)+"&phaId="+Convert.ToString(phaseid) ;
                tCellGroup.Controls.Add(h);


                for(int j = 0; j < counter; j++)
                {
                    if(j%2 ==1)
                    {
                        //set flags
                        string flag = ws.Team_Flag_Get(theList[j]);
                        if (!flag.Equals(""))
                        {
                            Image imgflag = new Image();
                            byte[] bytes = File.ReadAllBytes(flag);
                            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                            imgflag.ImageUrl = "data:image/png;base64," + base64String;

                            // Create a new cell and add it to the row.
                            TableCell tCellFlag = new TableCell();
                            tr.Cells.Add(tCellFlag);
                            tCellFlag.Width = 50;
                            tCellFlag.VerticalAlign = VerticalAlign.Middle;
                            tCellFlag.HorizontalAlign = HorizontalAlign.Center;

                            imgflag.Attributes["class"] = "circularFlag";
                            tCellFlag.Controls.Add(imgflag);
                        
                        }
                        
                        //
                        TableCell tCell = new TableCell();
                        tr.Cells.Add(tCell);
                        tCell.Width = 100;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Left;
                        Label lbl = new Label();
                        lbl.Text = theList[j];
                        lbl.Attributes["class"] = "lblFontText";
                        tCell.Controls.Add(lbl);
                    } 
                }

                for(int y = 0; y < counter; y ++)
                {
                    theList.RemoveAt(0);
                }

                if (theList.Count() > 0)
                {
                    if (lblGroup.Text.Equals("Group 1") || lblGroup.Text.Equals("Group 2") || lblGroup.Text.Equals("Group 3")
                        || lblGroup.Text.Equals("Group 4") || lblGroup.Text.Equals("Group 5") || lblGroup.Text.Equals("Group 6") ||
                        lblGroup.Text.Equals("Group 7") || lblGroup.Text.Equals("Group 8"))
                    {
                        theList[0].Contains("Group");
                        TableCell tCell2 = new TableCell();
                        tr.Cells.Add(tCell2);
                        tCell2.Width = 100;
                        tCell2.VerticalAlign = VerticalAlign.Middle;
                        tCell2.HorizontalAlign = HorizontalAlign.Left;
                        System.Web.UI.WebControls.HyperLink h2 = new HyperLink();
                        h2.Text = "Stats";
                        h2.Attributes["class"] = "lblFontText";
                        h2.NavigateUrl = "Phase_Stats.aspx?groname=" + Convert.ToString(lblGroup.Text);
                        tCell2.Controls.Add(h2);
                    }
                }
            }                
        }

        private void LoadStadiums(int eventid)
        {

            List<string> theList = ws.StadiumxEvent_Get(eventid);

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Host Stadiums");

            foreach (string g in theList)
            {
                tb.Rows.Add(g);
            }


            grvStadiums.DataSource = tb;
            grvStadiums.DataBind();
        }

        private void LoadCountries(int eventid)
        {

            List<string> theList = ws.CountryxEvent_Get(eventid);

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Host Countries");

            foreach (string g in theList)
            {
                tb.Rows.Add(g);
            }

            grvCountries.DataSource = tb;
            grvCountries.DataBind();
        }

        private void LoadGeneralstats(int eventid)
        {
            int played = ws.MatchesPlayed_Get(eventid);
            int total = ws.TotalMatches_Get(eventid);
            lblMatchesPlayed.Text = Convert.ToString(played) +"/"+ Convert.ToString(total);
            lblMatchesPlayed.Font.Size = 30;
            lblGoalsxMatch.Font.Size = 30;
            lblAverageYellow.Font.Size = 30;
            lblAverageRed.Font.Size = 30;
            lblAverageShots.Font.Size = 30;

            double goalsxmatch = ws.GoalsxMatch_Get(eventid);
            lblGoalsxMatch.Text = Convert.ToString(goalsxmatch);

            double yellxmatch = ws.CardsxMatch_Get(eventid, 0);
            lblAverageYellow.Text = Convert.ToString(yellxmatch);
            double redxmatch = ws.CardsxMatch_Get(eventid, 0);
            lblAverageRed.Text = Convert.ToString(redxmatch);

            double shotsxteam = ws.ShotsxTeam_Get(eventid);
            lblAverageShots.Text = Convert.ToString(shotsxteam);

        }
    }
}