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

                        tCell.VerticalAlign = VerticalAlign.Top;

                        imglogo.Attributes["class"] += "circular";
                        tRow.Cells.Add(tCell);

                        tCell.Controls.Add(imglogo);
                    }
                    else if (counter%6 == 1)
                    {
                        name = theList[k];
                        TableCell tCell = new TableCell();
                        tRow.Cells.Add(tCell);
                        tCell.Controls.Add(new LiteralControl(name));
                    }
                    else if (counter%6 == 2)
                    {
                        startdate = theList[k];
                        TableCell tCell = new TableCell();
                        tRow.Cells.Add(tCell);
                        tCell.Controls.Add(new LiteralControl(startdate));
                    }
                    else if (counter%6 == 3)
                    {
                        enddate = theList[k];
                        TableCell tCell = new TableCell();
                        tRow.Cells.Add(tCell);
                        tCell.Controls.Add(new LiteralControl(enddate));
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
                        tRow.Cells.Add(tCell);
                        tCell.Controls.Add(new LiteralControl(teamtype));

                    }
                    else if (counter%6 == 5)
                    {
                        if (Convert.ToBoolean(theList[k]) == false)
                        {
                            teamcat = "Men";
                        }
                        else
                        {
                            teamcat = "Women";
                        }
                        TableCell tCell = new TableCell();
                        tRow.Cells.Add(tCell);
                        tCell.Controls.Add(new LiteralControl(teamcat));
                        
                        cur = cur + 6;

                    }
                    counter++;
                }
                total = total + 6;
            }

        }
    }
}