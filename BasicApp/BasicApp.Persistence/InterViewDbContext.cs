using System;
using System.Collections.Generic;
using BasicApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BasicApp.Persistence
{
    public class InterViewDbContext : DbContext
    {
        public InterViewDbContext()
        {
        }

        public InterViewDbContext(DbContextOptions<InterViewDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
             
            });

        }
    }
}
