
using Microsoft.EntityFrameworkCore;
using System;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> movie) : base (movie)
        {

        }

        public DbSet<MovieDatabase> info { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieDatabase>().HasData(

                new MovieDatabase
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Director = "Guard",
                    Title = "The Univited",
                    Rating = "PG-13",
                    Year = 2009,  
                },
                new MovieDatabase
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Director = "Alfonso Cuaron",
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Rating = "PG",
                    Year = 2004,
                },
                new MovieDatabase
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Director = "Robert Luketic",
                    Title = "Legally Blonde",
                    Rating = "PG-13",
                    Year = 2001,
                }
            ) ;

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Horror" },
                new Category { CategoryID = 2, CategoryName = "Fantasy" },
                new Category { CategoryID = 3, CategoryName = "Chick Flick" },
                new Category { CategoryID = 4, CategoryName = "Comedy" },
                new Category { CategoryID = 5, CategoryName = "Action" },
                new Category { CategoryID = 6, CategoryName = "History" },
                new Category { CategoryID = 7, CategoryName = "Western" }
                );
        }
    }
}
