using Microsoft.EntityFrameworkCore;
using MosesApi77.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MosesApi77.Data
{
    public class MosesApiContext : DbContext
    {
        public MosesApiContext(DbContextOptions<MosesApiContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
