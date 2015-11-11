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

            //poner en labels los otros campos

            // Total number of rows.
            int rowCnt;
            rowCnt = 4;

            int cur = 0;
            int total = 11;

            for (int i = 0; i < rowCnt; i++)
            {
                int counter = 0;             
                
                List<string> theList = ws.GroupTeams_Get(idphase);
               
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
                    if (counter % 11 == 0)
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
                        //tr.Cells.Add(tCell);

                        //tCell.Controls.Add(imglogo);
                        
                    }
                    else if (counter % 11 == 1)
                    {
                                               
                        //teamname= theList[k];
                        //TableCell tCell4 = new TableCell();
                        //tCell4.Width = 100;
                        //tCell4.VerticalAlign = VerticalAlign.Middle;
                        //tCell4.HorizontalAlign = HorizontalAlign.Center;
                        //tr.Cells.Add(tCell4);
                        //Label lbl = new Label();
                        //lbl.Attributes["class"] = "lblFontText";
                        //lbl.Text = teamname;
                        //tCell4.Controls.Add(lbl);

                    }
                    else if (counter % 11 == 2)
                    {
                        //startdate = theList[k];
                        //TableCell tCell = new TableCell();
                        //tCell.Width = 100;
                        //tCell.VerticalAlign = VerticalAlign.Middle;
                        //tCell.HorizontalAlign = HorizontalAlign.Center;
                        //tr.Cells.Add(tCell);
                        //Label lbl = new Label();
                        //lbl.Attributes["class"] = "lblFontText";
                        //string[] realsdate = startdate.Split(' ');
                        //lbl.Text = realsdate[0];
                        //tCell.Controls.Add(lbl);
                    }

                    else if (counter % 11 == 3)
                    {
                        //TableCell tCell0 = new TableCell();
                        //tCell0.Width = 20;
                        //tCell0.VerticalAlign = VerticalAlign.Middle;
                        //tCell0.HorizontalAlign = HorizontalAlign.Center;
                        //Label lbl0 = new Label();
                        //lbl0.Attributes["class"] = "lblFontText";
                        //lbl0.Text = "-";
                        //tr.Cells.Add(tCell0);
                        //tCell0.Controls.Add(lbl0);

                        //enddate = theList[k];
                        //TableCell tCell = new TableCell();
                        //tCell.Width = 100;
                        //tCell.VerticalAlign = VerticalAlign.Middle;
                        //tCell.HorizontalAlign = HorizontalAlign.Center;
                        //tr.Cells.Add(tCell);
                        //Label lbl = new Label();
                        //lbl.Attributes["class"] = "lblFontText";
                        //string[] realedate = enddate.Split(' ');
                        //lbl.Text = realedate[0];
                        //tCell.Controls.Add(lbl);
                    }
                    else if (counter % 11 == 4)
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
                    //    TableCell tCell = new TableCell();
                    //    tCell.Width = 80;
                    //    tCell.VerticalAlign = VerticalAlign.Middle;
                    //    tCell.HorizontalAlign = HorizontalAlign.Center;
                    //    tr.Cells.Add(tCell);
                    //    Label lbl = new Label();
                    //    lbl.Attributes["class"] = "lblFontText";
                    //    lbl.Text = teamcat;
                    //    tCell.Controls.Add(lbl);
                    //    cur = cur + 6;
                    }
                    else if (counter % 11 == 5)
                    {

                    }
                    else if (counter % 11 == 6)
                    {

                    }
                    else if (counter % 11 == 7)
                    {

                    }
                    else if (counter % 11 == 8)
                    {

                    }
                    else if (counter % 11 == 9)
                    {

                    }
                    else if (counter % 11 == 10)
                    {

                    }

                    counter++;
                }
                total = total + 11;


            }


        }
    }
}