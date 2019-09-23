using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BugReport.Models
{
    public class BugReportContext : DbContext
    {
        public BugReportContext (DbContextOptions<BugReportContext> options)
            : base(options)
        {
        }

        public DbSet<BugReport.Models.Bug> Bug { get; set; }
    }
}
