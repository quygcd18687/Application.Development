﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDev.Models
{
    public class Trainee : User
    {
        public string TOEICScore { get; set; }
        public string Department { get; set; }
    }
}