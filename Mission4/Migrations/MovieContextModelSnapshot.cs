// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Chick Flick"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "History"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Western"
                        });
                });

            modelBuilder.Entity("Mission4.Models.MovieDatabase", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("info");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "Guard",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Univited",
                            Year = 2009
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 2,
                            Director = "Alfonso Cuaron",
                            Edited = false,
                            Rating = "PG",
                            Title = "Harry Potter and the Prisoner of Azkaban",
                            Year = 2004
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Robert Luketic",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Legally Blonde",
                            Year = 2001
                        });
                });

            modelBuilder.Entity("Mission4.Models.MovieDatabase", b =>
                {
                    b.HasOne("Mission4.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
