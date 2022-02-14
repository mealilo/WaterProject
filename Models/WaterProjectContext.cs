using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WaterProject.Models
{
    public partial class WaterProjectContext : DbContext
    {
        public WaterProjectContext()
        {
        }

        public WaterProjectContext(DbContextOptions<WaterProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Projects { get; set; }


    }
}
