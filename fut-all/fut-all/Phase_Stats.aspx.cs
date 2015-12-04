using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Group_Stats : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string val = Request.QueryString["evId"].ToString();
                int eventid = Convert.ToInt32(val);

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

                string val1 = Request.QueryString["groname"].ToString();

                string phasename = Convert.ToString(val1);
                int idphase = ws.Phase_Id_Get(eventid, phasename);
                Label1.Text = phasename;
                LoadGroupGrid(idphase);
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        private void LoadGroupGrid(int idphase)
        {

            // Total number of rows.
            int rowCnt;
            rowCnt = 4;

            int cur = 0;
            int total = 9;
            

            for (int i = 0; i < rowCnt; i++)
            {
                int counter = 0;             
                List<string> groupstats = ws.StatsxGroup_Get(idphase);
                string logo = string.Empty;
                string teamname = string.Empty;

                // Create a new row and add it to the table.
                TableRow tRow = new TableRow();
                tbl.Rows.Add(tRow);
                counter = 0;
                TableCell tc = new TableCell();
                tRow.Cells.Add(tc);
                Panel pn = new Panel();
                pn.Attributes["class"] = "roundedChartTbl";
                tc.Controls.Add(pn);
                Table intbl = new Table();
                intbl.Height = 80;
                pn.Controls.Add(intbl);
                TableRow tr = new TableRow();
                intbl.Rows.Add(tr);                
       
                for (int k = cur; k < total; k++)
                {
                    if (counter % 9 == 0)
                    {

                        teamname = groupstats[k];
                        logo = ws.Team_Flag_Get(teamname);
                        Image imglogo = new Image();
                        byte[] bytes = File.ReadAllBytes(logo);
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        imglogo.ImageUrl = "data:image/png;base64," + base64String;

                        // Create a new cell and add it to the row.
                        TableCell tCelli = new TableCell();
                        tCelli.Width = 120;
                        tCelli.HorizontalAlign = HorizontalAlign.Center;
                        tCelli.VerticalAlign = VerticalAlign.Middle;

                        imglogo.Attributes["class"] = "circular";
                        tr.Cells.Add(tCelli);

                        tCelli.Controls.Add(imglogo);

                        TableCell tCell = new TableCell();
                        tCell.Width = 130;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tCell.VerticalAlign = VerticalAlign.Middle;

                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = teamname;
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 1)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;                       
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 2)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }

                    else if (counter % 9 == 3)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 4)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 5)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 6)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter % 9 == 7)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                        
                    }
                    else if (counter % 9 == 8)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 90;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);
                        tCell.Controls.Add(lbl);
                        cur = cur + 9;
                    }
                    counter++;
                }
                total = total + 9;


            }


        }
    }
}