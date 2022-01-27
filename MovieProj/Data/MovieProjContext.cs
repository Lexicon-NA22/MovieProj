#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieProj.Models.Entities;

namespace MovieProj.Data
{
    public class MovieProjContext : DbContext
    {
        public MovieProjContext (DbContextOptions<MovieProjContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
