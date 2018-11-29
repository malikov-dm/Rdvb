using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RdvbDotNetCoreRazor.Models
{
    public class RdvbDotNetCoreRazorContext : DbContext
    {
        public RdvbDotNetCoreRazorContext (DbContextOptions<RdvbDotNetCoreRazorContext> options)
            : base(options)
        {
        }

        public DbSet<RdvbDotNetCoreRazor.Models.Article> Article { get; set; }
    }
}
