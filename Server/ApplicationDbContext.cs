using System;
using Microsoft.EntityFrameworkCore;
using LetrasBlog.Infraestructure.Entities;

namespace LetrasBlog.Server
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>().HasKey(x => new { x.IdArticle });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Articles> Articles { get; set; }
    }
}
