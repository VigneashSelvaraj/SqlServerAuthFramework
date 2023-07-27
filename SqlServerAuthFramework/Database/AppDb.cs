using SqlServerAuthFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Data.Entity.SqlServer;

namespace SqlServerAuthFramework.Database
{
    [DbConfigurationType(typeof(MicrosoftSqlDbConfiguration))]
    public class AppDb: DbContext
    {
        public AppDb() : base("SqlConnectionString")
        {
            
        }
        public DbSet<TblProjectsSample> Project { get; set; }
        public DbSet<TblFieldSample> Field { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}