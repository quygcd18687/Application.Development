using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDev.Models
{
    public class Trainer : User
    {
        public string EducationLevel { get; set; }
        public string WorkingPlace { get; set; }
    }
}