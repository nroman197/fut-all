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
                LoadGroupGrid(idphase);
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        private void LoadGroupGrid(int idphase)
        {
            int counter = 0;
            List<string> theList = ws.GroupTeams_Get(idphase);
            string flag = ws.Team_Flag_Get(theList[1]);

            string logoteam1 = string.Empty;
            string logoteam2 = string.Empty;
            string logoteam3 = string.Empty;
            string logoteam4 = string.Empty;
            string teamname1 = string.Empty;
            string teamname2 = string.Empty;
            string teamname3 = string.Empty;
            string teamname4 = string.Empty;


            //string tshirt = string.Empty;
            //string positionplayer = string.Empty;zz
            //string countryplayer = string.Empty;

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Flag");
            tb.Columns.Add("Team");
            tb.Columns.Add("MP");
            tb.Columns.Add("W");
            tb.Columns.Add("D");
            tb.Columns.Add("L");
            tb.Columns.Add("GE");
            tb.Columns.Add("GA");
            tb.Columns.Add("+/-");
            tb.Columns.Add("FPP");
            tb.Columns.Add("Pts");
            foreach (string g in theList)
            {
                flag = ws.Team_Flag_Get(g);

                if (counter == 0)
                {

                }
                else if (counter == 1)
                {
                    teamname1 = g;

                    Image imglogo = new Image();
                    byte[] bytes = File.ReadAllBytes(flag);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    imglogo.ImageUrl = "data:image/png;base64," + base64String;
                    logoteam1 = Convert.ToString(imglogo);
                }
                else if (counter == 2)
                {

                }
                else if (counter == 3)
                {
                    teamname2 = g;
                    Image imglogo = new Image();
                    byte[] bytes = File.ReadAllBytes(flag);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    imglogo.ImageUrl = "data:image/png;base64," + base64String;
                    logoteam2 = Convert.ToString(imglogo);
                }
                else if (counter == 4)
                {

                }
                else if (counter == 5)
                {
                    teamname3 = g;
                    Image imglogo = new Image();
                    byte[] bytes = File.ReadAllBytes(flag);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    imglogo.ImageUrl = "data:image/png;base64," + base64String;
                    logoteam3 = Convert.ToString(imglogo);
                }
                else if (counter == 6)
                {

                }
                else if (counter == 7)
                {
                    teamname4 = g;
                    Image imglogo = new Image();
                    byte[] bytes = File.ReadAllBytes(flag);
                    string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                    imglogo.ImageUrl = "data:image/png;base64," + base64String;
                    logoteam4 = Convert.ToString(imglogo);
                    tb.Rows.Add(logoteam1, teamname1);
                    tb.Rows.Add(logoteam2, teamname2);
                    tb.Rows.Add(logoteam3, teamname3);
                    tb.Rows.Add(logoteam4, teamname4);
                    counter = -1;
                }

                counter++;
            }


            grvGroupTeams.DataSource = tb;
            grvGroupTeams.DataBind();
        }
    }


}