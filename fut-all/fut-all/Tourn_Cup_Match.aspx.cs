using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fut_all
{
    public partial class Tourn_Cup_Match : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lbladdreplace.Font.Size = 12;
                lbladdreplacet2.Font.Size = 12;
                lblGoalst1.Font.Size = 12;
                lblGoalst2.Font.Size = 12;
                lblCardst1.Font.Size = 12;
                lblCardst2.Font.Size = 12;
                btnSaveAllChanges.Font.Size = 13;
            }
        }

        protected void imgLogoHome_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void LoadTeam1(int idteam){

        }

        protected void LoadTeam2(int idteam)
        {
            //llenar grid with players.
        }


        protected void btnaddreplace_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddreplacet1_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddreplacet2_Click(object sender, EventArgs e)
        {

        }

        protected void btnaddgoalt1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddCardT1_Click(object sender, EventArgs e)
        {

        }

        protected void btnAddCardT2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            string datetimematch = txtmatchdatetime.Text;
            string stadiummatch = txtmatchstadium.Text;

        }
    }
}