using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;


namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {

            if (!userManager.Users.Any())
            {
                var user = new User 
                {
                    UserName = "balconi",
                    Email = "balconi@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User 
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Red Bed",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/dogBed.jpeg",
                    Brand = "Carlin",
                    Type = "Beds & Furniture",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Blanket",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/dogBlanket.jpeg",
                    Brand = "Carlin",
                    Type = "Beds & Furniture",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Fresh Pillow",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/dogFreshpillow.jpeg",
                    Brand = "Carlin",
                    Type = "Beds & Furniture",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pooch Tie",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/dogGuide.jpeg",
                    Brand = "Carlin",
                    Type = "Collars, Harnesses & Leashes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Leashes Peg",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/dogLeashes.jpeg",
                    Brand = "Carlin",
                    Type = "Collars, Harnesses & Leashes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Monkey",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/dogMonkey.jpeg",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pug Plunsh",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/dogPlunsh.jpeg",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Toy screw",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/dogToy.jpeg",
                    Brand = "Carlin",
                    Type = "Toys",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Travel Tote",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/dogTravelTote.jpeg",
                    Brand = "Carlin",
                    Type = "Bags",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Travel Backpak",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/dogTravelBackpak.jpeg",
                    Brand = "Carlin",
                    Type = "Bags",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sweater",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/dogSweater.jpeg",
                    Brand = "Carlin",
                    Type = "Clothing & Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Towel",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/dogTowel.jpeg",
                    Brand = "Carlin",
                    Type = "Clean Up",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet PoochPad",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/poochpad.jpeg",
                    Brand = "Carlin",
                    Type = "Acessories",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Pet Product Name 14",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/dogAirTravel.jpeg",
                    Brand = "Carlin",
                    Type = "Acessories",
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
                
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}