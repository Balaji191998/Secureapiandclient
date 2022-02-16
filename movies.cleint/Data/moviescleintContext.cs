using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies.cleint.Models;

namespace movies.cleint.Data
{
    public class moviescleintContext : DbContext
    {
        public moviescleintContext (DbContextOptions<moviescleintContext> options)
            : base(options)
        {
        }

        public DbSet<movies.cleint.Models.Movies> Movies { get; set; }
    }
}
