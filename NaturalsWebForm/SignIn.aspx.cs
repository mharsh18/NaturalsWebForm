using NaturalsWebForm.DataAccess;
using NaturalsWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NaturalsWebForm
{
    public partial class SignIn : System.Web.UI.Page
    {
        private NaturalsDatabase db = new NaturalsDatabase();
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
        protected void BtnSignin_Click(object sender, EventArgs e)
        {
            var signin = db.signUpInfo.FirstOrDefault(s => s.EMail == txtMail.Value && s.Password == txtPassword.Value);
            if (signin == null) { ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email or Password Incorrect')", true); }
            else {
                ActiveSession.IsActive = true;
                ActiveSession.Name = signin.Name;
                ActiveSession.Mail = signin.EMail;
                Response.Redirect("~/Home.aspx"); 
            }
            
        }
    }
}