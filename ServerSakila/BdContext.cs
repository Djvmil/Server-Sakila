using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ServeurSakila.Model;

namespace ServerSakila
{
    public class BdContext : DbContext
    {
        public DbSet<Actor> Actors  { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Film_Actor> Film_Actors { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Store> Stores { get; set; }

        public BdContext() :base("name = SakilaContext")
        {
            Database.SetInitializer<BdContext>(new DropCreateDatabaseIfModelChanges<BdContext>());
        }
    }
}
