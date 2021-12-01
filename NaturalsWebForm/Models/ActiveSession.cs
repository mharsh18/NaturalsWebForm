using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NaturalsWebForm.Models
{
    public class ActiveSession
    {
        static public bool IsActive { get; set; } = false;
        static public string Name { get; set; } = string.Empty;
        static public string Mail { get; set; } =  string.Empty ;

    }
}