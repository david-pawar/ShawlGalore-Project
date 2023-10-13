using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShawlGalore.Data;
using System;
using System.Linq;           //using statement for this file

namespace ShawlGalore.Models
{
    public static class SeedData          //class name
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShawlGaloreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ShawlGaloreContext>>()))
            {
                // We're initializing a database context using a provided service provider.
                // The context will be responsible for managing interactions with the database.

                // Now, we're checking if there are any existing records in the 'Shawl' table.
                // when I recreated the app but previous data was there, i could not seed data in, because there was already data existed
                if (context.Shawl.Any())
                {
                    return;    // If there are existing records, we don't need to seed the database.
                }

                // If there are no existing records, we proceed to add new records to the 'Shawl' table.



                context.Shawl.AddRange( // now, instances of the Shawl class will be created
                  new Shawl
                  {  // these instance should have the all values corresponding to the Shawl.cs class 's properties

                      Material = "Silk",
                      Color = "Blue",
                      Design = "Printed",
                      Occasion = "Casual",
                      Size = "Large",
                      Price = 45.99M
                  },

                        new Shawl   // a shawl instance is created with help of new keyword
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
                // At this point, we save the changes made to the 'Shawl' objects and persist them in the database.
            }
        }
    }
}