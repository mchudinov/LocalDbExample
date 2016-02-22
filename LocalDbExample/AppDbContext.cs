﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LocalDbExample
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Widget> Widgets { get; set; }
    }
}
