using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using System.IO;
using laba7.Models;

namespace laba7
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Service> Services { get; set; }

        public ApplicationContext() : base("name=ASP_7ConnectionString") {}

        public static ApplicationContext Create()
        {
            ApplicationContext db = new ApplicationContext();
            DbInitializer.Initialize(db);
            return db;
        }
    }
}
