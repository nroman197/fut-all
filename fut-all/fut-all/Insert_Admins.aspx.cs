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
            Response.Redirect("Home.aspx");
        }

        protected void ddlAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAddAdmin_Click(object sender, EventArgs e)
        {

            int userid = ws.User_Id_Get(ddlAdmin.SelectedItem.Text);
            if (ddlAdmin.SelectedIndex > 0)
            {
                ws.Create_Admin(userid);
                LoadUsers();
            }
        }
    }
}