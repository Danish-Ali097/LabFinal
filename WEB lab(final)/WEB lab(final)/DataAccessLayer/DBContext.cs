using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WEB_lab_final_.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WEB_lab_final_.DataAccessLayer
{
    public class DBContext: DbContext
    {
        public DBContext() : base("Data Source=DESKTOP-QRKBNFU\\SQLEXPRESS;Initial Catalog=TyresShop;Integrated Security=True")
        { }
        public DbSet<Tyres> Tyres { set; get; }
        public DbSet<Sales> Sales { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}