using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Northwind2Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind2;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Car>().ToTable("Cars");
        //    modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("CarId");
        //    modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("ModelYear");

        //    modelBuilder.Entity<CarImage>().ToTable("CarImages");
        //    modelBuilder.Entity<CarImage>().HasKey(x => x.Id);


        //    modelBuilder.Entity<Color>().ToTable("Colors");
        //    modelBuilder.Entity<Color>().Property(c => c.ColorId).HasColumnName("ColorId");

        //    modelBuilder.Entity<Brand>().ToTable("Brands");

        //    modelBuilder.Entity<User>().ToTable("Users");

        //    modelBuilder.Entity<Customer>().ToTable("Customers");

        //    modelBuilder.Entity<Rental>().ToTable("Rentals");



        //}
    }
}
