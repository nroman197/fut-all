using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WS ws = new WS();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            int emailexists =ws.EmailExists_Get(txbEmail.Text);
            if (emailexists == 0)
            {
                ws.User_Ins(txbEmail.Text, Encrypt.Encriptar(txbPassword.Text));
                txbEmail.Text = "";

                string script = "alert(\"User created succesfully!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
            else{
                string script = "alert(\"Email already exists!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                txbEmail.Text = "";
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            int loginexists = ws.LoginValidation_Get(txbEmail.Text, Encrypt.Encriptar(txbPassword.Text));
            if (loginexists > 0)
            {
                Session["user_id"] = ws.User_Id_Get(txbEmail.Text, Encrypt.Encriptar(txbPassword.Text));
                Response.Redirect("Home.aspx");
            }
            else
            {
                string script = "alert(\"Incorrect email or password! Try again.!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                txbEmail.Text = "";
            }
        }
    }
}