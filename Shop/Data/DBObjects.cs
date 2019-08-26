using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContext context)
        {
            if(!context.Category.Any())
                context.Category.AddRange(Categories.Select(c => c.Value));

            if (!context.Car.Any())
            {
                context.AddRange(
                    new Car { Name = "Tesla", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 45000, IsFavorite = true, IsAvailable = true, Category = Categories["Electrocars"] },
                    new Car { Name = "Tesla1", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 35000, IsFavorite = true, IsAvailable = true, Category = Categories["Electrocars"] },
                    new Car { Name = "Tesla2", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 15000, IsFavorite = true, IsAvailable = true, Category = Categories["Electrocars"] },
                    new Car { Name = "Tesla3", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 25000, IsFavorite = true, IsAvailable = true, Category = Categories["Electrocars"] },
                    new Car { Name = "Tesla4", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 65000, IsFavorite = true, IsAvailable = true, Category = Categories["Electrocars"] },
                    new Car { Name = "Tesla5", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 27000, IsFavorite = true, IsAvailable = true, Category = Categories["Classic cars"] },
                    new Car { Name = "Tesla6", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 41000, IsFavorite = true, IsAvailable = true, Category = Categories["Classic cars"] },
                    new Car { Name = "Tesla7", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla1.jpg", Price = 48000, IsFavorite = true, IsAvailable = true, Category = Categories["Classic cars"] },
                    new Car { Name = "Tesla8", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla2.jpg", Price = 17000, IsFavorite = true, IsAvailable = true, Category = Categories["Classic cars"] },
                    new Car { Name = "Tesla9", ShortDesc = "best car", LongDesc = "best car i have ever seen, i dont know what tp write", Img = "/img/tesla.jpg", Price = 33000, IsFavorite = true, IsAvailable = true, Category = Categories["Classic cars"] });
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Electrocars", Description = "Modern transport type" },
                        new Category { CategoryName = "Classic cars", Description = "Cars with internal combustion engine" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var item in list)
                        category.Add(item.CategoryName, item);
                }
                return category;
            }
        }
    }
}
