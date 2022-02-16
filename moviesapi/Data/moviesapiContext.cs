using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesapi.models;

namespace moviesapi.Data
{
    public class moviesapiContext : DbContext
    {
        public moviesapiContext (DbContextOptions<moviesapiContext> options)
            : base(options)
        {
        }

        public DbSet<moviesapi.models.Movies> Movies { get; set; }
    }
}
