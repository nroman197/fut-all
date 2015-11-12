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
                string val = Request.QueryString["groname"].ToString();
                string phasename = Convert.ToString(val);
                int idphase = ws.PhaseId_Get(phasename);
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
                
                //List<string> theList = ws.GroupTeams_Get(idphase);
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
                        //string flag = ws.Team_Flag_Get(theList[i]);
                        //logo = flag;

                        //Image imglogo = new Image();
                        //byte[] bytes = File.ReadAllBytes(logo);
                        //string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        //imglogo.ImageUrl = "data:image/png;base64," + base64String;

                        //// Create a new cell and add it to the row.
                        //TableCell tCell = new TableCell();
                        //tCell.Width = 80;
                        //tCell.VerticalAlign = VerticalAlign.Middle;
                        //tCell.HorizontalAlign = HorizontalAlign.Center;

                        //imglogo.Attributes["class"] = "circular";
                                              
                        TableCell tCell = new TableCell();
                        tCell.Width = 80;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;

                        Label lbl = new Label();
                        lbl.Text = groupstats[k];
                        tr.Cells.Add(tCell);

                    }
                    else if (counter % 9 == 1)
                    {                                               

                    }
                    else if (counter % 9 == 2)
                    {

                    }

                    else if (counter % 9 == 3)
                    {
                       
                    }
                    else if (counter % 9 == 4)
                    {
                    //    if (Convert.ToBoolean(theList[k]) == false)
                    //    {
                    //        teamtype = "National Teams";
                    //    }
                    //    else
                    //    {
                    //        teamtype = "Clubs";
                    //    }
                    //    TableCell tCell = new TableCell();
                    //    tCell.Width = 100;
                    //    tCell.VerticalAlign = VerticalAlign.Middle;
                    //    tCell.HorizontalAlign = HorizontalAlign.Center;
                    //    tr.Cells.Add(tCell);
                    //    Label lbl = new Label();
                    //    lbl.Attributes["class"] = "lblFontText";
                    //    lbl.Text = teamtype;
                    //    tCell.Controls.Add(lbl);

                    //}
                    //else if (counter % 6 == 5)
                    //{
                    //    if (Convert.ToBoolean(theList[k]) == false)
                    //    {
                    //        teamcat = "Men's";
                    //    }
                    //    else
                    //    {
                    //        teamcat = "Women's";
                    //    }

                    }
                    else if (counter % 9 == 5)
                    {

                    }
                    else if (counter % 9 == 6)
                    {

                    }
                    else if (counter % 9 == 7)
                    {

                    }
                    else if (counter % 9 == 8)
                    {
                        TableCell tCell = new TableCell();
                        tCell.Width = 80;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        //lbl.Text = teamcat;
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