using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Tourn_Cup_Group_Matches : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            string val0 = "";
            int eventid = 0;
            string val1 = "";
            int phaseid = 0;

            if (!IsPostBack)
            {
                int role = ws.User_Role_Get(Convert.ToInt32(Session["user_id"]));

                if (role == 1)
                {
                    lbladmin.Text = "Admin";
                    refadmin.HRef = "Insert_admins.aspx";

                }
                else
                {
                    lbladmin.Text = "";
                }

                ddl1.Visible = false;
                ddl2.Visible = false;
                vs.Visible = false;
                btnSaveInfo.Visible = false;
                val0 = Request.QueryString["evId"].ToString();
                eventid = Convert.ToInt32(val0);
                val1 = Request.QueryString["phaId"].ToString();
                phaseid = Convert.ToInt32(val1);
                showMatches(phaseid, eventid);
            }
            
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void showMatches(int phaseid, int eventid)
        {
            int phatypeid = ws.PhaseType_Id_Get(phaseid);
            // Total number of rows.
            int rowCnt = ws.Matches_Count(phaseid);
            string phname = ws.Phase_Name_Get(phaseid);
            List<string> theList = ws.Matches_Get(phaseid);
            TableRow tRow0 = new TableRow();
            tbl.Rows.Add(tRow0);
            TableCell tcell0 = new TableCell();
            tRow0.Cells.Add(tcell0);
            Label lblph = new Label();
            lblph.Text = phname;
            lblph.Attributes["class"] = "lblFontName";
            tcell0.Controls.Add(lblph);

            List<string> qualTeams = ws.TeamsxPhase_Get(eventid, phatypeid);
         
            //int count = phatypeid;
            //while (qualTeams.Count == 0)
            //{
                qualTeams = ws.TeamsxPhase_Get(eventid, 1);
                //count--;

            //}
            

            for (int i = 0; i < rowCnt; i++)
            {
                
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

                // team 1
                //set flags
                if (!theList[0].Equals(""))
                {
                    string flag = ws.Team_Flag_Get(theList[0]);
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
                
                TableCell tCell = new TableCell();
                tr.Cells.Add(tCell);
                tCell.Width = 100;
                tCell.VerticalAlign = VerticalAlign.Middle;
                tCell.HorizontalAlign = HorizontalAlign.Left;

                if (theList[0].Equals(""))
                {
                    ddl1.Items.Clear();
                    ddl1.Items.Add("---");
                    ddl1.SelectedIndex = 0;                    

                    foreach (string g in qualTeams)
                    {
                        ddl1.Items.Add(g);
                    }

                    ddl1.Visible = true;
                    vs.Visible = true;
                    btnSaveInfo.Visible = true;
                }
                else
                {
                    Label lbl = new Label();
                    lbl.Text = theList[0];
                    lbl.Attributes["class"] = "lblFontText";
                    tCell.Controls.Add(lbl);
                
                }
                                
                // 
                TableCell tCellVs = new TableCell();
                tr.Cells.Add(tCellVs);
                tCellVs.Width = 100;
                tCellVs.VerticalAlign = VerticalAlign.Middle;
                tCellVs.HorizontalAlign = HorizontalAlign.Left;
                Label lblvs = new Label();
                lblvs.Text = "VS";
                lblvs.Attributes["class"] = "lblFontText";
                tCellVs.Controls.Add(lblvs);

                // team 2
                //set flags
                if (!theList[1].Equals(""))
                {
                    string flag = ws.Team_Flag_Get(theList[1]);
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
                TableCell tCell1 = new TableCell();
                tr.Cells.Add(tCell1);
                tCell1.Width = 100;
                tCell1.VerticalAlign = VerticalAlign.Middle;
                tCell1.HorizontalAlign = HorizontalAlign.Left;


                if (theList[1].Equals(""))
                {

                    ddl2.Items.Clear();
                    ddl2.Items.Add("---");
                    ddl2.SelectedIndex = 0;
                    
                    foreach (string g in qualTeams)
                    {
                        ddl2.Items.Add(g);
                    }

                    ddl2.Visible = true;
                }
                else
                {
                    Label lbl = new Label();
                    lbl.Text = theList[1];
                    lbl.Attributes["class"] = "lblFontText";
                    tCell1.Controls.Add(lbl);

                }

                // hlink
                TableCell tCell2 = new TableCell();
                tr.Cells.Add(tCell2);
                tCell2.Width = 100;
                tCell2.VerticalAlign = VerticalAlign.Middle;
                tCell2.HorizontalAlign = HorizontalAlign.Left;
                Label lbl2 = new Label();
                lbl2.Text = "See ";
                lbl2.Attributes["class"] = "lblFontText";
                System.Web.UI.WebControls.HyperLink h = new HyperLink();
                h.Text = lbl2.Text;
                h.Attributes["class"] = "lblFontName";
                h.NavigateUrl = "Tourn_Cup_Match.aspx?phaId=" + Convert.ToString(phaseid) + "&team1Id=" + Convert.ToString(ws.Team_Id_Get(theList[0]))
                    + "&team2Id=" + Convert.ToString(ws.Team_Id_Get(theList[1]) + "&evId="+ Convert.ToString(eventid));
                tCell2.Controls.Add(h);


                for (int k = 0; k < 2; k++)
                {
                    theList.Remove(theList[0]);
                }
            }
        }

        protected void btnSaveInfo_Click(object sender, EventArgs e)
        {
            int t1 = ws.Team_Id_Get(ddl1.Text);
            int t2 = ws.Team_Id_Get(ddl2.Text);
            List<string> tlist = new List<string>();


            string val0 = Request.QueryString["evId"].ToString();
            int eventid = Convert.ToInt32(val0);

            string val1 = Request.QueryString["phaId"].ToString();
            int phaseid = Convert.ToInt32(val1);
            tlist = ws.match_idsxPhase_Get(phaseid);

            if(tlist.Count() > 0){
                int matchid = Convert.ToInt32(tlist[0]);
                ws.spMatchQualifs_Upd(matchid, t1, t2);
            }
            Response.Redirect("Tourn_Cup_Phase_Matches.aspx?evId=" + Convert.ToString(eventid)+"&phaId="+Convert.ToString(phaseid));

            //showMatches(phaseid, eventid);                        


        }

    }

}