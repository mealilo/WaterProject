using System;
using System.Collections.Generic;

#nullable disable

namespace WaterProject.Models
{
    public partial class Project
    {
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public long? ProjectRegionalProgram { get; set; }
        public long? ProjectImpact { get; set; }
        public string ProjectPhase { get; set; }
        public string ProjectFunctionalityStatus { get; set; }
    }
}
