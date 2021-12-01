using NaturalsWebForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NaturalsWebForm.DataAccess
{
    public class NaturalsDatabase : DbContext
    {
        public NaturalsDatabase(): base("NaturalsDatabase")
        {

        }
        public DbSet<SignUpClass> signUpInfo { get; set; }
    }
}