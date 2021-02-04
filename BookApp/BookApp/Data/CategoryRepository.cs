using BookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{Id=1, Name="Dram"},
                new Category{Id=2, Name="Elmi Fantastika"},
                new Category{Id=3, Name="Dedektiv"},
                new Category{Id=4, Name="Macera"},
                new Category{Id=5, Name="Romantika"}
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i=>i.Id==id);
        }
    }
}
