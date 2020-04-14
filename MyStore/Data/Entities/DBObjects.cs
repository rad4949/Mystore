using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Entities
{
    public class DBObjects
    {
        public static void Initial(AppDbContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Motorcycle.Any())
            {
                content.AddRange(
                     new Motorcycle
                     {
                         name = "Ducati",
                         shortDesc = "Streetfighter",
                         longDesc = "Зручний у використанні.",
                         img = "/img/Streetfighter.jpg",
                         price = 15000,
                         isFavorite = true,
                         availabel = true,
                         Category = Categories["Street"]
                     },
                  new Motorcycle
                  {
                      name = "Ducati",
                      shortDesc = "Hypermotard",
                      longDesc = "Зручний у використанні.",
                      img = "/img/Hypermotard.jpg",
                      price = 14000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Street"]
                  },
                  new Motorcycle
                  {
                      name = "ВMW",
                      shortDesc = "GS 1200",
                      longDesc = "Приємно подорожувати.",
                      img = "/img/GS 1200.jpg",
                      price = 16000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Traveling"]
                  },
                  new Motorcycle
                  {
                      name = "Honda",
                      shortDesc = "250 CRF",
                      longDesc = "Підходить для ралі, надійний.",
                      img = "/img/250 CRF.jpg",
                      price = 14000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Cross"]
                  },
                  new Motorcycle
                  {
                      name = "Ducati",
                      shortDesc = "Panigale R",
                      longDesc = "Неймовірно швидкий, підходить для шосейних треків.",
                      img = "/img/Panigale R.jpg",
                      price = 27000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Sport"]
                  },
                  new Motorcycle
                  {
                      name = "Kawasaki ",
                      shortDesc = "H2r",
                      longDesc = "Має найбільшу швидкість.",
                      img = "/img/H2r.jpg",
                      price = 39000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Sport"]
                  },
                  new Motorcycle
                  {
                      name = "Ducati",
                      shortDesc = "Diavel",
                      longDesc = "Неймовірно комфортний та надійний",
                      img = "/img/Diavel.jpg",
                      price = 25000,
                      isFavorite = true,
                      availabel = true,
                      Category = Categories["Traveling"]
                  }
                );
            }
            content.SaveChanges();
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
                     new Category { categoryName="Sport", desc="Швидкий"},
                     new Category { categoryName="Cross", desc="Прохідний"},
                     new Category { categoryName="Street", desc="Зручний"},
                     new Category { categoryName="Traveling", desc="Комфортний"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }

        }
    }
}
