using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Pet Product Name 1",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/PetProductName1.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 2",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/PetProductName2.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/PetProductName3.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 4",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/PetProductName4.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 5",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/PetProductName5.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 6",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/PetProductName6.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 7",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/PetProductName7.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 8",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/PetProductName8.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 9",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/PetProductName9.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 10",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/PetProductName10.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 11",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/PetProductName11.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 12",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/PetProductName12.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 13",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/PetProductName13.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 14",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/PetProductName14.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 15",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/PetProductName15.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 16",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/PetProductName16.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 17",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/PetProductName17.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 18",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/PetProductName18.png",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}