using BuildConnectBackend.Model;
using Microsoft.EntityFrameworkCore;
using RecipesApi.Model;
using System.Collections.Generic;

namespace BuildConnectBackend.Context
{
    public class BuildConnectContext : DbContext
    {
        public BuildConnectContext(DbContextOptions<BuildConnectContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        public DbSet<MaterialReport> MaterialReports { get; set; }
        public DbSet<WorkProgress> WorkProgresses { get; set; }
        public DbSet<WorkHour> WorkHrs { get; set; }
    }
}