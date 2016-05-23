namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Manufacturers.AddOrUpdate(x => x.Id,
                new Manufacturer() { Id = 1, Name = "Honda" },
                new Manufacturer() { Id = 2, Name = "Tesla" },
                new Manufacturer() { Id = 3, Name = "Ford" },
                new Manufacturer() { Id = 4, Name = "Toyota" }
                );

            context.Vehicles.AddOrUpdate(x => x.Id,
                new Vehicle()
                {
                    Id = 1,
                    Make = "Civic",
                    Year = 1985,
                    ManufacturerId = 1
                },
                new Vehicle()
                {
                    Id = 2,
                    Make = "Model 3",
                    Year = 2019,
                    ManufacturerId = 2
                },
                new Vehicle()
                {
                    Id = 4,
                    Make = "Focus",
                    Year = 2000,
                    ManufacturerId = 3
                },
                new Vehicle()
                {
                    Id = 3,
                    Make = "Prius",
                    Year = 2010,
                    ManufacturerId = 4
                }
            );
        }
    }
}
