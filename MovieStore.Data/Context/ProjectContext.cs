using Microsoft.EntityFrameworkCore;
using Moviestore.Map;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Data.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MONSTER;Database=MovieStore;UID=sa;PWD=1234;");
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new MovieMap());
        }
    }
}
