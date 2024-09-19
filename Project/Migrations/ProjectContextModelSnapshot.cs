﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Context;

#nullable disable

namespace Project.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Labtops and Phones",
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Books and Magazines",
                            Name = "Books"
                        });
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Apple 2023 MacBook Air Laptop with M2 chip: 15.3-inch Liquid Retina Display, 8GB Unified Memory, 256GB SSD Storage, 1080p FaceTime HD Camera, Touch ID. Works with iPhone/iPad; Midnight ",
                            ImagePath = "/images/273869_pcdcp3.png",
                            Price = "$884.69",
                            Quantity = 100,
                            Title = "Laptop"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "2020 Apple MacBook Air Laptop: Apple M1 Chip, 13” Retina Display, 8GB RAM, 256GB SSD Storage, Backlit Keyboard, FaceTime HD Camera, Touch ID. Works with iPhone/iPad; Gold ",
                            ImagePath = "/images/R.png",
                            Price = "$647.39",
                            Quantity = 57,
                            Title = "Laptop"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Apple 2022 MacBook Air Laptop with M2 chip: Built for Apple Intelligence, 13.6-inch Liquid Retina Display, 8GB RAM, 256GB SSD Storage, Backlit Keyboard, 1080p FaceTime HD Camera; Starlight ",
                            ImagePath = "/images/macbookair.png",
                            Price = "$767.04",
                            Quantity = 55,
                            Title = "Laptop"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "Late 2019 Apple MacBook Pro with 2.6GHz Intel Core i7 (16-Inch, 16GB RAM, 512GB Storage) - Silver (Renewed) ",
                            ImagePath = "/images/R (1).png",
                            Price = "$467.04",
                            Quantity = 40,
                            Title = "Labtop"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Description = "Apple iPhone 13, 128GB, Midnight - Unlocked ",
                            ImagePath = "/images/R (2).png",
                            Price = "$550.06",
                            Quantity = 20,
                            Title = "Phone"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Description = "Apple iPhone 11 Pro, US Version, 256GB, Silver for AT&T ",
                            ImagePath = "/images/R (3).png",
                            Price = "$500.00",
                            Quantity = 6234,
                            Title = "Phone"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            Description = "These Things Happen: A Novel ",
                            ImagePath = "/images/61iNF0XaeNL._SL1500_.png",
                            Price = "$11.49",
                            Quantity = 30,
                            Title = "Novel"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            Description = "Men's Health Best: Weight-Free Workout ",
                            ImagePath = "/images/71eR76UwWHL._SL1500_.png",
                            Price = "$9.76",
                            Quantity = 20,
                            Title = "Book"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            Description = "100 Cars That Changed the World: The Designs, Engines, and Technologies That Drive Our Imaginations ",
                            ImagePath = "/images/81LDFz47KSL._SL1500_.png",
                            Price = "$11.99",
                            Quantity = 30,
                            Title = "Book"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            Description = "Extraordinary Things to Cut Out and Collage ",
                            ImagePath = "/images/81WO45mTtAL._SL1500_.png",
                            Price = "$17.89",
                            Quantity = 10,
                            Title = "Magazine"
                        });
                });

            modelBuilder.Entity("Project.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project.Models.Product", b =>
                {
                    b.HasOne("Project.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Project.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
