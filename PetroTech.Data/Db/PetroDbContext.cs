using PetroTech.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroTech.Data
{
    public class PetroDbContext : DbContext
    {
        public PetroDbContext() : base("PetroConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Log> Logs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
