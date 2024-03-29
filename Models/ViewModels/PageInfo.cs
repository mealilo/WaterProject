﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models.ViewModels
{
    public class PageInfo
    {
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumProjects { get; set; }
        public int TotalPages => (int) Math.Ceiling((double) TotalNumProjects / ProjectsPerPage);
    }
}
