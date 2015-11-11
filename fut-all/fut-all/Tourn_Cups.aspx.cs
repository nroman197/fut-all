using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Tourn_Cups : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
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
                showEvents();

            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void showEvents()
        {
            // Total number of rows.
            int rowCnt;
            rowCnt = ws.Events_Count();

            int cur = 0;
            int total = 6;

            for (int i = 0; i < rowCnt; i++)
            {
                int counter = 0;
                List<string> theList = ws.Events_Get();
                string logo = string.Empty;
                string name = string.Empty;
                string startdate = string.Empty;
                string enddate = string.Empty;
                string teamtype = string.Empty;
                string teamcat = string.Empty;

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
                    if (counter%6 == 0)
                    {
                        logo = theList[k];
                        Image imglogo = new Image();
                        byte[] bytes = File.ReadAllBytes(logo);
                        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                        imglogo.ImageUrl = "data:image/png;base64," + base64String;

                        // Create a new cell and add it to the row.
                        TableCell tCell = new TableCell();
                        tCell.Width = 80;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;

                        imglogo.Attributes["class"] = "circular";
                        tr.Cells.Add(tCell);

                        tCell.Controls.Add(imglogo);
                    }
                    else if (counter%6 == 1)
                    {
                        name = theList[k];
                        TableCell tCell = new TableCell();
                        tCell.Width = 200;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);

                        int eventid = ws.Event_Id_Get(name);

                        System.Web.UI.WebControls.HyperLink h = new HyperLink();
                        h.Text = name;
                        h.Attributes["class"] = "lblFontName";
                        h.NavigateUrl = "Tourn_Cup_Phases.aspx?evId=" + Convert.ToString(eventid);
                        tCell.Controls.Add(h);
                    }
                    else if (counter%6 == 2)
                    {
                        startdate = theList[k];
                        TableCell tCell = new TableCell();
                        tCell.Width = 100;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        string[] realsdate = startdate.Split(' ');
                        lbl.Text = realsdate[0];
                        tCell.Controls.Add(lbl);
                    }

                    else if (counter%6 == 3)
                    {
                        TableCell tCell0 = new TableCell();
                        tCell0.Width = 20;
                        tCell0.VerticalAlign = VerticalAlign.Middle;
                        tCell0.HorizontalAlign = HorizontalAlign.Center;
                        Label lbl0 = new Label();
                        lbl0.Attributes["class"] = "lblFontText";
                        lbl0.Text = "-";
                        tr.Cells.Add(tCell0);
                        tCell0.Controls.Add(lbl0);

                        enddate = theList[k];
                        TableCell tCell = new TableCell();
                        tCell.Width = 100;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        string[] realedate = enddate.Split(' ');
                        lbl.Text = realedate[0];
                        tCell.Controls.Add(lbl);
                    }
                    else if (counter%6 == 4)
                    {
                        if (Convert.ToBoolean(theList[k]) == false)
                        {
                            teamtype = "National Teams";
                        }
                        else
                        {
                            teamtype = "Clubs";
                        }
                        TableCell tCell = new TableCell();
                        tCell.Width = 100;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = teamtype;
                        tCell.Controls.Add(lbl);

                    }
                    else if (counter%6 == 5)
                    {
                        if (Convert.ToBoolean(theList[k]) == false)
                        {
                            teamcat = "Men's";
                        }
                        else
                        {
                            teamcat = "Women's";
                        }
                        TableCell tCell = new TableCell();
                        tCell.Width = 80;
                        tCell.VerticalAlign = VerticalAlign.Middle;
                        tCell.HorizontalAlign = HorizontalAlign.Center;
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Attributes["class"] = "lblFontText";
                        lbl.Text = teamcat;
                        tCell.Controls.Add(lbl);
                        cur = cur + 6;

                    }
                    counter++;
                }
                total = total + 6;
            }

        }
    }
}