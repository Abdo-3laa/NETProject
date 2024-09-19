using Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Project.Context
{
    public class ProjectContext : DbContext
    {
        /*--------------------------------------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4O8E667\\SQLEXPRESS;DataBase=Project; Trusted_Connection=true; Encrypt=false;");
        }
        /*--------------------------------------------------------*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*----------------------------------------------------*/
            // Seading
            var _Categorys = new List<Category>
            {
                new Category { CategoryId = 1, Name = "Electronics", Description = "Labtops and Phones" },
                new Category { CategoryId = 2, Name ="Books", Description = "Books and Magazines" },
              
            };
            /*----------------------------------------------------*/
            var _Products = new List<Product>
            {
                new Product { ProductId = 1, Title= "Laptop", Price = "$884.69",Description="Apple 2023 MacBook Air Laptop with M2 chip: 15.3-inch Liquid Retina Display, 8GB Unified Memory, 256GB SSD Storage, 1080p FaceTime HD Camera, Touch ID. Works with iPhone/iPad; Midnight ", Quantity = 100, ImagePath = "/images/273869_pcdcp3.png", CategoryId = 1 },
                new Product { ProductId = 2, Title= "Laptop", Price = "$647.39",   Description="2020 Apple MacBook Air Laptop: Apple M1 Chip, 13” Retina Display, 8GB RAM, 256GB SSD Storage, Backlit Keyboard, FaceTime HD Camera, Touch ID. Works with iPhone/iPad; Gold ",   Quantity = 57, ImagePath = "/images/R.png",   CategoryId = 1 },
                new Product { ProductId = 3, Title= "Laptop", Price = "$767.04",  Description="Apple 2022 MacBook Air Laptop with M2 chip: Built for Apple Intelligence, 13.6-inch Liquid Retina Display, 8GB RAM, 256GB SSD Storage, Backlit Keyboard, 1080p FaceTime HD Camera; Starlight ",   Quantity = 55, ImagePath = "/images/macbookair.png",CategoryId = 1 },
                new Product { ProductId = 4, Title= "Labtop", Price = "$467.04",  Description="Late 2019 Apple MacBook Pro with 2.6GHz Intel Core i7 (16-Inch, 16GB RAM, 512GB Storage) - Silver (Renewed) ",   Quantity = 40, ImagePath = "/images/R (1).png" ,CategoryId = 1},
                new Product { ProductId = 5, Title= "Phone", Price = "$550.06",  Description="Apple iPhone 13, 128GB, Midnight - Unlocked ",   Quantity = 20, ImagePath = "/images/R (2).png",CategoryId = 1   },
                new Product { ProductId = 6, Title= "Phone", Price = "$500.00", Description="Apple iPhone 11 Pro, US Version, 256GB, Silver for AT&T ",   Quantity = 6234, ImagePath = "/images/R (3).png",  CategoryId = 1},
                new Product { ProductId = 7, Title= "Novel", Price = "$11.49", Description="These Things Happen: A Novel ",   Quantity = 30, ImagePath = "/images/61iNF0XaeNL._SL1500_.png", CategoryId = 2  },
                new Product { ProductId = 8, Title= "Book", Price = "$9.76",   Description="Men's Health Best: Weight-Free Workout ", Quantity = 20, ImagePath = "/images/71eR76UwWHL._SL1500_.png",CategoryId = 2   },
                new Product { ProductId = 9, Title= "Book", Price = "$11.99",  Description="100 Cars That Changed the World: The Designs, Engines, and Technologies That Drive Our Imaginations ",  Quantity = 30, ImagePath = "/images/81LDFz47KSL._SL1500_.png",CategoryId = 2 },
                new Product { ProductId = 10,Title = "Magazine", Price = "$17.89",   Description="Extraordinary Things to Cut Out and Collage ",Quantity = 10, ImagePath = "/images/81WO45mTtAL._SL1500_.png",CategoryId = 2},
            };
            /*----------------------------------------------------*/
            modelBuilder.Entity<Category>().HasData(_Categorys);
            modelBuilder.Entity<Product>().HasData(_Products);
            /*----------------------------------------------------*/
        }
        /*--------------------------------------------------------*/
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        /*--------------------------------------------------------*/

    }
}
