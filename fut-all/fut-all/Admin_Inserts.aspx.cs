using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContinents();
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

        protected void btnAddcontinent_Click(object sender, EventArgs e)
        {
            if(txbContinent.Text.Length > 0){
                ws.Continent_Ins(txbContinent.Text);
                txbContinent.Text = "";
            }
  
        }

        protected void ddlContinents_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddConfederation_Click(object sender, EventArgs e)
        {
            if (ddlContinents.SelectedIndex > 0)
            {
                if (txbConfederation.Text.Length > 0)
                {
                    int theId = ws.Continent_Id_Get(ddlContinents.SelectedItem.Text);
                    ws.Confederation_Ins(txbConfederation.Text, theId);
                    txbConfederation.Text = "";
                    //LoadConfederations(theId);
                }
            }
        }

        protected void ddlConfederations_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddCountry_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddStadium_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {

        }

        protected void ddlPosition_TextChanged(object sender, EventArgs e)
        {

        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ddlCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadContinents()
        {
            ddlContinents.Items.Clear();
            ddlContinents.Items.Add("-Select Continent-");

            List<string> theList = ws.Continents_Get();

            foreach (string g in theList)
            {
                ddlContinents.Items.Add(g);
            }
        }

        protected void ddlGenrePlayer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamStadium_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCountry_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void ddlTeamType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ddlTeamCathegory_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddPlayer_Click1(object sender, EventArgs e)
        {

        }

        protected void grvPlayers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grvPlayers_PageIndexChanged(object sender, EventArgs e)
        {

        }

        //protected void eli_Click(object sender, EventArgs e)
        //{
        //    string queseleccione = string.Empty;

        //    foreach (GridViewRow row in grvPlayers.Rows)
        //    {
        //        if (row.RowType == DataControlRowType.DataRow)
        //        {
        //            CheckBox chkRow = (row.Cells[0].FindControl("chk") as CheckBox);
        //            if (chkRow.Checked)
        //            {
        //                string name = row.Cells[1].Text;
        //                queseleccione = queseleccione + name;
        //            }
        //        }
        //    }

        //    etienne.Text = queseleccione;
        //}


    }
}