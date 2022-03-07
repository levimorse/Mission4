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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieDatabase>().HasData(

                new MovieDatabase
                {
                    MovieID = 1,
                    Category = "Horror",
                    Director = "Guard",
                    Title = "The Univited",
                    Rating = "PG-13",
                    Year = 2009,  
                },
                new MovieDatabase
                {
                    MovieID = 2,
                    Category = "Fantasy",
                    Director = "Alfonso Cuaron",
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Rating = "PG",
                    Year = 2004,
                },
                new MovieDatabase
                {
                    MovieID = 3,
                    Category = "Chick Flick",
                    Director = "Robert Luketic",
                    Title = "Legally Blonde",
                    Rating = "PG-13",
                    Year = 2001,
                }
            ) ;
        }
    }
}
