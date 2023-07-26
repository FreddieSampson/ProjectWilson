using Microsoft.EntityFrameworkCore;
using ProjectWilson.Shared;

namespace ProjectWilson.Server.Data
{
    public class DataContext : DbContext
    {
        // this is a constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        //properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });  

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" },
                new Category { Id = 4, Name = "Music", Url = "music", Icon = "musical-note" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "This is a very intuitive description of the book !",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "This is a very intuitive description of the game !",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Grand Theft Auto 5",
                    Description = "This is a very intuitive description of the game !",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Unicorn - Noa Kirel",
                    Description = "Song performed by Noa Kirel during Eurovision 2023 representing Israel",
                    Image = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bf/Unicorn_%28song%29.jpeg/220px-Unicorn_%28song%29.jpeg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "iPhone 14 Pro",
                    Description = "The newest iPhone by Apple",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/IPhone_14_Pro_vector.svg/220px-IPhone_14_Pro_vector.svg.png",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "Paperback" },
                new Edition { Id = 3, Name = "E-Book" },
                new Edition { Id = 4, Name = "Audiobook" },
                new Edition { Id = 5, Name = "PC" },
                new Edition { Id = 6, Name = "PlayStation" },
                new Edition { Id = 7, Name = "Xbox" },
                new Edition { Id = 8, Name = "iPhone Pro" },
                new Edition { Id = 9, Name = "iPhone Pro Max" }
            );

            //modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
            //    .HasData(
            //        new { EditionsId = 1, ProductsId = 1 },
            //        new { EditionsId = 2, ProductsId = 1 },
            //        new { EditionsId = 3, ProductsId = 1 },
            //        new { EditionsId = 4, ProductsId = 2 },
            //        new { EditionsId = 5, ProductsId = 2 },
            //        new { EditionsId = 6, ProductsId = 2 },
            //        new { EditionsId = 4, ProductsId = 3 },
            //        new { EditionsId = 5, ProductsId = 3 },
            //        new { EditionsId = 6, ProductsId = 3 },
            //        new { EditionsId = 7, ProductsId = 5 },
            //        new { EditionsId = 8, ProductsId = 5 }
            //    );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 5,
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 6,
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 7,
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 5,
                    Price = 29.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 6,
                    Price = 29.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 7,
                    Price = 29.99m,
                    OriginalPrice = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 8,
                    OriginalPrice = 1200.00m,
                    Price = 700.00m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 9,
                    OriginalPrice = 1500.00m,
                    Price = 1000.00m
                }
            );
        }
    }
}
