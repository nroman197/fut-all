using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Insert_Admins : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //load drop down list
                LoadUsers();
            }
        }

        private void LoadUsers()
        {
            ddlAdmin.Items.Clear();
            ddlAdmin.Items.Add("-Select Admin-");
            List<string> ListUsers = ws.Users_Get();

            foreach (string g in ListUsers)
            {
                ddlAdmin.Items.Add(g);
            }
        }
        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ddlAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddAdmin_Click(object sender, EventArgs e)
        {
            
            int continentid = ws.Continent_Id_Get(ddlContinent.SelectedItem.Text);
            if (newcontinent.Length != 0)
            {
                ws.Continent_Upd(newcontinent, continentid);
                txbContinent.Text = "";
                LoadContinents();
            }
        }
    }
}