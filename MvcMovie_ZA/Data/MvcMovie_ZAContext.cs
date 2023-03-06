using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_ZA.Models;

namespace MvcMovie_ZA.Data
{
    public class MvcMovie_ZAContext : DbContext
    {
        public MvcMovie_ZAContext (DbContextOptions<MvcMovie_ZAContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_ZA.Models.Movie> Movie { get; set; } = default!;
    }
}
