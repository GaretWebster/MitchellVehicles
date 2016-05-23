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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
                new Author() { Id = 1, Name = "Honda" },
                new Author() { Id = 2, Name = "Tesla" },
                new Author() { Id = 3, Name = "Ford" },
                new Author() { Id = 4, Name = "Toyota" }
                );

            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "Civic",
                    Year = 1985,
                    AuthorId = 1,
                    Price = 9.99M,
                    Genre = "Honda"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Model 3",
                    Year = 2019,
                    AuthorId = 1,
                    Price = 12.95M,
                    Genre = "Tesla"
                },
                new Book()
                {
                    Id = 4,
                    Title = "Focus",
                    Year = 2000,
                    AuthorId = 2,
                    Price = 15,
                    Genre = "Ford"
                },
                new Book()
                {
                    Id = 3,
                    Title = "Prius",
                    Year = 2010,
                    AuthorId = 3,
                    Price = 8.95M,
                    Genre = "Toyota"
                }
            );
        }
    }
}
