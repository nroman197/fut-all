using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class WebForm3 : System.Web.UI.Page
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
                LoadTeams();
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

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

        private void LoadTeamTypes()
        {
            ddlTeamType.Items.Clear();
            ddlTeamType.Items.Add("-Select Type-");
            ddlTeamType.Items.Add("National Team");  // id 0
            ddlTeamType.Items.Add("Club"); // id 1
        }

        private void LoadTeamCategories()
        {
            ddlTeamCathegory.Items.Clear();
            ddlTeamCathegory.Items.Add("-Select Category-");
            ddlTeamCathegory.Items.Add("Male");  // id 0
            ddlTeamCathegory.Items.Add("Female"); // id 1
        }

        private void LoadTeamsQuantity()
        {
            ddlTeamsQuant.Items.Clear();
            ddlTeamsQuant.Items.Add("-Select Quantity-");
            ddlTeamsQuant.Items.Add("32");  // id 0
            ddlTeamsQuant.Items.Add("16"); // id 1
            ddlTeamsQuant.Items.Add("8"); // id 2
        }

        private void LoadTeams()
        {

            List<string> theList = ws.Teams_Get();

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
 
        protected void btnAddTeam_Click(object sender, EventArgs e)
        {

        }

        protected void ddlTeamsQuant_TextChanged(object sender, EventArgs e)
        {                       
                int groupsQ = (Convert.ToInt32(ddlTeamsQuant.Text))/4;
                int qualQ = (Convert.ToInt32(groupsQ))*2;
                lblGroupsQuant.Text = Convert.ToString(groupsQ);
                lblQualifQuant.Text = Convert.ToString(qualQ);            
        }

        protected void chkcountry_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grvCountries.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkcountry") as CheckBox);

                    if (chkRow.Checked)
                    {
                        string namecountry = row.Cells[1].Text;
                        int idcou = ws.Country_Id_Get(namecountry);
                        ws.StadiumxCountry_Get(idcou);
                        grvCountries.DataSource = null;
                        grvCountries.DataBind();
                    }
                }
            }
           
        }

    }
}