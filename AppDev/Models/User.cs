using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDev.Models
{
    public class User: ApplicationUser
    {
        public string FullName { get; set; }
        public DateTime BirthOfDate { get; set; }

        public string Address { get; set; }
        public Course Course { get; set; }
        public int? CourseId { get; set; }
    }
}