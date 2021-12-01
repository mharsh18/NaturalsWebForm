using NaturalsWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NaturalsWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (ActiveSession.IsActive == true)
                {
                    Response.Redirect("~/Home.aspx");
                }

            }

        }
    }
}