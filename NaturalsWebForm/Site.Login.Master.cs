using NaturalsWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NaturalsWebForm
{
    public partial class Site_Login : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            ActiveSession.IsActive = false;
            ActiveSession.Name = string.Empty;
            ActiveSession.Mail = string.Empty;
            Response.Redirect("~/Default.aspx");
        }
    }
}