using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;


using OpenQbit.PIS.Common.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using OpenQbit.PIS.DataAccess.DAL.Contracts;

namespace OpenQbit.PIS.DataAccess.DAL
{
    public class PISContext : DbContext, IPISContext
    {
        public PISContext() : base("PISDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Message> Message { get; set; }
        public DbSet <MessageDetail> MessageDetail { get; set; }
        public DbSet<Employee> Employee { get; set; }

      

        public DbSet<Notification> Notification { get; set; }

        public DbSet<TaskDetail> TaskDetail { get; set; }
        public DbSet<Common.Models.Task> Task { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
