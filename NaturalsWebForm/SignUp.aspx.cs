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
    public partial class SignUp : System.Web.UI.Page
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

        protected void BtnSignup_Click(object sender, EventArgs e)
        {
            using (var Context = new NaturalsDatabase())
            {
                
                var emailPresent = Context.signUpInfo.FirstOrDefault(x => x.EMail == txtMail.Value);
                if (emailPresent == null)
                {
                    SignUpClass signup = new SignUpClass
                    {
                        Name = txtName.Value,
                        EMail = txtMail.Value,
                        Password = txtPassword.Value
                    };
                    Context.signUpInfo.Add(signup);
                    Context.SaveChanges();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('SignUp Successfull')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('The Account with this Email already exists')", true);
                }
            }
        }
    }
}