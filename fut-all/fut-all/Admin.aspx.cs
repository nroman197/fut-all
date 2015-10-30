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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlContinents.Items.Add("-Select Continent-");
                ddlConfederations.Items.Add("-Select Confederation-");
                ddlPosition.Items.Add("-Select Position-");
            }
            
        }

        protected void btnAddcontinent_Click(object sender, EventArgs e)
        {

        }

        protected void ddlContinents_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddConfederation_Click(object sender, EventArgs e)
        {

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

    }
}