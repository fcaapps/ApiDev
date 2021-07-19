using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//using CrudFornec.Data.Extensions;
//using CrudFornec.Data.Mappings;
using ApiDev.Domain.Entities;


namespace ApiDev.Data.Content
{
    public class ApiDevContext : DbContext
    {
        public ApiDevContext(DbContextOptions<ApiDevContext> option)
            : base(option) {}

        #region "DbSets"
        public DbSet<Fornecedor> Fornecedor { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UserMap());

            //modelBuilder.ApplyGlobalConfigurations();
            //modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
