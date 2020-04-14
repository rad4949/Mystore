using MyStore.Data.Interfaces;
using MyStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Data.Mocks
{
    public class MockCategory : IMotoCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName="Sport", desc="Швидкий"},
                    new Category { categoryName="Cross", desc="Прохідний"},
                    new Category { categoryName="Street", desc="Зручний"},
                    new Category { categoryName="Traveling", desc="Комфортний"},

                };

            }
        }
    }
}
