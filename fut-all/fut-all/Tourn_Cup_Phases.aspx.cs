﻿using System;
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
                tCellGroup.Controls.Add(lblGroup);

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
                            tCellFlag.Width = 110;
                            tCellFlag.VerticalAlign = VerticalAlign.Middle;
                            tCellFlag.HorizontalAlign = HorizontalAlign.Center;

                            imgflag.Attributes["class"] = "circularFlag";
                            tCellFlag.Controls.Add(imgflag);
                        
                        }
                        
                        //
                        TableCell tCell = new TableCell();
                        tr.Cells.Add(tCell);
                        Label lbl = new Label();
                        lbl.Text = theList[j];
                        tCell.Controls.Add(lbl);
                    } 
                }

                for(int y = 0; y < counter; y ++)
                {
                    theList.RemoveAt(0);
                }
            }                
        }
    }
}