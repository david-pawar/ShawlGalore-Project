using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShawlGalore.Data;
using System;
using System.Linq;

namespace ShawlGalore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShawlGaloreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShawlGaloreContext>>()))
            {
                // Look for any movies.
                if (context.Shawl.Any())
                {
                    return;   // DB has been seeded
                }


                context.Shawl.AddRange(
                  new Shawl
                  {
                      // Image = "../wwwroot/img/blue-silk2.avif",
                      Material = "Silk",
                      Color = "Blue",
                      Design = "Printed",
                      Occasion = "Casual",
                      Size = "Large",
                      Price = 45.99M
                  },

                        new Shawl
                        {
                            // Image = "../wwwroot/img/black-shawl.webp",
                            Material = "Wool",
                            Color = "Black",
                            Design = "Plain",
                            Occasion = "Everyday",
                            Size = "Small",

                            Price = 30.99M
                        },

                        new Shawl
                        {
                            // Image = "../wwwroot/img/white-pashima.webp",
                            Material = "Pashmina",
                            Color = "White",
                            Design = "Beaded",
                            Occasion = "Wedding",
                            Size = "Medium",

                            Price = 80.99M
                        },
                        new Shawl
                        {

                            Material = "Silk",
                            Color = "Red",
                            Design = "Floral",
                            Occasion = "Formal",
                            Size = "Large",

                            Price = 49.99M
                        },
                    new Shawl
                    {

                        Material = "Cashmere",
                        Color = "Blue",
                        Design = "Striped",
                        Occasion = "Casual",
                        Size = "Medium",

                        Price = 39.99M
                    },
                    new Shawl
                    {

                        Material = "Wool",
                        Color = "Green",
                        Design = "Geometric",
                        Occasion = "Casual",
                        Size = "Small",

                        Price = 29.99M
                    },
                    new Shawl
                    {
                        Material = "Cotton",
                        Color = "Black",
                        Design = "Plain",
                        Occasion = "Everyday",
                        Size = "Large",

                        Price = 34.99M
                    },

                    new Shawl
                    {

                        Material = "Cashmere",
                        Color = "Pink",
                        Design = "Printed",
                        Occasion = "Casual",
                        Size = "Large",

                        Price = 42.99M
                    },
                    new Shawl
                    {
                        // Image = "../wwwroot/img/purple-wool.jpg",
                        Material = "Wool",
                        Color = "Purple",
                        Design = "Plaid",
                        Occasion = "Casual",
                        Size = "Small",

                        Price = 31.99M
                    },
                    new Shawl
                    {

                        Material = "Cotton",
                        Color = "White",
                        Design = "Striped",
                        Occasion = "Everyday",
                        Size = "Medium",

                        Price = 36.99M
                    },

                    new Shawl
                    {
                        //   Image = "../wwwroot/img/red-cashmere.webp",
                        Material = "Cashmere",
                        Color = "Red",
                        Design = "Embroidered",
                        Occasion = "Formal",
                        Size = "Medium",

                        Price = 57.99M
                    },
                    new Shawl
                    {

                        Material = "Cotton",
                        Color = "Yellow",
                        Design = "Plain",
                        Occasion = "Everyday",
                        Size = "Small",

                        Price = 28.99M
                    },
                    new Shawl
                    {

                        Material = "Wool",
                        Color = "Gray",
                        Design = "Plaid",
                        Occasion = "Casual",
                        Size = "Medium",

                        Price = 32.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}