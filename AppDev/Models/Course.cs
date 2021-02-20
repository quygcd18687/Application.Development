using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDev.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Categogy { get; set; }
    }
}