﻿using GigAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigAPP.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
        public ILookup<int, Attendance> Attendances { get; set; }
        public ILookup<string, Following> Followings { get; set; }
        public string CurrentUser { get; set; }
    }
}