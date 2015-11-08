using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Add_Local_Tourn : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountries();
                LoadTeamTypes();
                LoadTeamCategories();
                LoadTeamsQuantity();
            }
        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {
            if (ddlTeamCathegory.SelectedIndex != 0 && ddlTeamType.SelectedIndex != 0)
            {
                int ptype = 0;
                if (ddlTeamType.SelectedIndex == 2)
                {
                    ptype = 1;
                }
                int pcat = 0;
                if (ddlTeamCathegory.SelectedIndex == 2)
                {
                    pcat = 1;
                }

                LoadTeamsxTypexCategory(ptype, pcat);
            }
        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {
            if (ddlTeamCathegory.SelectedIndex != 0 && ddlTeamType.SelectedIndex != 0)
            {
                int ptype = 0;
                if (ddlTeamType.SelectedIndex == 2)
                {
                    ptype = 1;
                }
                int pcat = 0;
                if (ddlTeamCathegory.SelectedIndex == 2)
                {
                    pcat = 1;
                }

                LoadTeamsxTypexCategory(ptype, pcat);
            }            
        }

        protected void ddlTeamsQuant_TextChanged(object sender, EventArgs e)
        {
            int groupsQ = (Convert.ToInt32(ddlTeamsQuant.Text)) / 4;
            int qualQ = (Convert.ToInt32(groupsQ)) * 2;
            lblGroupsQuant.Text = Convert.ToString(groupsQ);
            lblQualifQuant.Text = Convert.ToString(qualQ);     
        }

        protected void btnAddEvent_Click(object sender, EventArgs e)
        {

        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        private void LoadTeamTypes()
        {
            ddlTeamType.Items.Clear();
            ddlTeamType.Items.Add("-Select Type-");
            ddlTeamType.Items.Add("National Team");  // id 0
            ddlTeamType.Items.Add("Club"); // id 1
        }

        private void LoadTeamsQuantity()
        {
            ddlTeamsQuant.Items.Clear();
            ddlTeamsQuant.Items.Add("-Select Quantity-");
            ddlTeamsQuant.Items.Add("32");  // id 0
            ddlTeamsQuant.Items.Add("16"); // id 1
            ddlTeamsQuant.Items.Add("8"); // id 2
        }

        private void LoadTeamCategories()
        {
            ddlTeamCathegory.Items.Clear();
            ddlTeamCathegory.Items.Add("-Select Category-");
            ddlTeamCathegory.Items.Add("Male");  // id 0
            ddlTeamCathegory.Items.Add("Female"); // id 1
        }

        private void LoadTeamsxTypexCategory(int ptype, int pcat)
        {

            List<string> theList = ws.TeamxTypexCategory_Get(ptype, pcat);

            System.Data.DataTable tb = new System.Data.DataTable();

            // manage gridview
            tb.Columns.Add("Name");


            foreach (string g in theList)
            {

                tb.Rows.Add(g);

            }

            grvParticipants.DataSource = tb;
            grvParticipants.DataBind();
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