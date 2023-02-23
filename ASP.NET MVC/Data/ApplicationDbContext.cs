using ASP.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Jay Kay", City = "Gotemburgo", PhoneNumber = "666-692471337" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Mike Truk", City = "Austin", PhoneNumber = "555-302540371" });
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Bobson Dugnut", City = "Tallahassee", PhoneNumber = "555-782575942" });
        }

    }
}
