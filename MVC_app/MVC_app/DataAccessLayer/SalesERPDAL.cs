using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_app.Models;

namespace MVC_app.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        //public SalesERPDAL() : base("NewConnectionString")
        //{

        //}
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}