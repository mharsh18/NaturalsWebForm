using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NaturalsWebForm.Models
{
    public class SignUpClass
    {
        [Key]
        public string EMail { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }

    }
}