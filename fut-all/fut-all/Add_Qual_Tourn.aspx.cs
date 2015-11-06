using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Add_Qual_Tourn : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountries();
                LoadStadiums();
            }
        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamsQuant_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddEvent_Click(object sender, EventArgs e)
        {

        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        private void LoadStadiums()
        {

            List<string> theList = ws.Stadiums_Get();

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");


            foreach (string g in theList)
            {

                tb.Rows.Add(g);

            }

            grvStadiums.DataSource = tb;
            grvStadiums.DataBind();
        }

        private void LoadCountries()
        {

            List<string> theList = ws.Countries_Get();

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");


            foreach (string g in theList)
            {

                tb.Rows.Add(g);

            }

            grvCountries.DataSource = tb;
            grvCountries.DataBind();
        }

    }
}