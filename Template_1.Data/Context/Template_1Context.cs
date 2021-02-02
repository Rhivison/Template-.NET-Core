using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Template_1.Data.Extensions;
using Template_1.Data.Mappings;
using Template_1.Domain.Entities;

namespace Template_1.Data.Context
{
    public class Template_1Context: DbContext
    {
        public Template_1Context(DbContextOptions<Template_1Context> option)
            : base(option) { }

        #region "DbSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
} 
