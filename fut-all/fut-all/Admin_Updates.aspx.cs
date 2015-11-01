using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Admin_Updates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.Data.DataTable tb = new System.Data.DataTable();
                tb.Columns.Add("Name");
                tb.Columns.Add("Last Name");
                tb.Columns.Add("Position");
                tb.Columns.Add("Country");
                tb.Columns.Add("#");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "1");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "1");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "1");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "8");
                tb.Rows.Add("Kimberly", "Cordero", "Middle Field", "Costa Rica", "1");
                grvPlayers.DataSource = tb;
                grvPlayers.DataBind();
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void btnAddcontinent_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddConfederation_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddCountry_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddStadium_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddcontinent_Click1(object sender, EventArgs e)
        {

        }

        protected void ddlContinents_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlConfederations_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPosition_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlContinent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlStadiums_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPlayername_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addPlayer_Click(object sender, EventArgs e)
        {

        }

        protected void ddlContinent_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlGenrePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}