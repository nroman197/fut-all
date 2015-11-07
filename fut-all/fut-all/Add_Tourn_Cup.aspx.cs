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
                
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

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
 
        protected void ddlTeamsQuant_TextChanged(object sender, EventArgs e)
        {                       
                int groupsQ = (Convert.ToInt32(ddlTeamsQuant.Text))/4;
                int qualQ = (Convert.ToInt32(groupsQ))*2;
                lblGroupsQuant.Text = Convert.ToString(groupsQ);
                lblQualifQuant.Text = Convert.ToString(qualQ);            
        }

        protected void chkcountry_CheckedChanged(object sender, EventArgs e)
        
        {
            
            List<string> theList = new List<string>();
            foreach (GridViewRow row in grvCountries.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkcountry") as CheckBox);

                    if (chkRow.Checked)
                    {
                        string namecountry = row.Cells[1].Text;
                        int idcou = ws.Country_Id_Get(namecountry);
                        List<string> couList = ws.StadiumxCountry_Get(idcou);
                        foreach(string h in couList)
                        {
                            theList.Add(h);
                        }
                    }
                }
            }

            System.Data.DataTable tb = new System.Data.DataTable();
            tb.Columns.Add("Name");

            foreach (string g in theList)
            {                
                 tb.Rows.Add(g);           
            }

            grvStadiums.DataSource = tb;
            grvStadiums.DataBind();
        }

        protected void btnAddEvent_Click(object sender, EventArgs e)
        {

            if(txbEventName.Text.Length > 0 && fuEventLogo.HasFile && ddlTeamCathegory.SelectedIndex > 0 &&
                ddlTeamType.SelectedIndex > 0 && txbStartDate.Text.Length > 0 && txbEndDate.Text.Length > 0 &&
                ddlTeamsQuant.SelectedIndex > 0){


                    List<string> theListCou = new List<string>();
                    foreach (GridViewRow row in grvCountries.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkcountry") as CheckBox);

                            if (chkRow.Checked)
                            {
                                string namecountry = row.Cells[1].Text;

                                theListCou.Add(namecountry);
                                
                            }
                        }
                    }
                    List<string> theListSta = new List<string>();
                    foreach (GridViewRow row in grvStadiums.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkstadiums") as CheckBox);

                            if (chkRow.Checked)
                            {
                                string namesta = row.Cells[1].Text;

                                theListSta.Add(namesta);

                            }
                        }
                    }
                    List<string> theListTeam = new List<string>();
                    foreach (GridViewRow row in grvParticipants.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            CheckBox chkRow = (row.Cells[0].FindControl("chkParticipants") as CheckBox);

                            if (chkRow.Checked)
                            {
                                string nameteam = row.Cells[1].Text;

                                theListTeam.Add(nameteam);

                            }
                        }
                    }

                    if (theListCou.Count > 0 && theListSta.Count > 0 && theListTeam.Count == Convert.ToInt32(ddlTeamsQuant.Text))
                    {
                        // generate groups
                       
                    }
                    else if(theListCou.Count == 0)
                    {
                                        
                        string script = "alert(\"Please select at least one host country!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);                    
                    }
                    else if (theListSta.Count == 0)
                    {

                        string script = "alert(\"Please select at least one host stadium!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
                    else if (theListTeam.Count != Convert.ToInt32(ddlTeamsQuant.Text))
                    {

                        string script = "alert(\"Please select " + ddlTeamsQuant.Text + " teams!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                    }
            }
            else
            {
                string script = "alert(\"Please complete all the fields!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

    }
}