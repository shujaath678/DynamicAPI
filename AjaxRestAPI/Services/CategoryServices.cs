using System;
using AjaxRestAPI.Models;
using System.Collections.Generic;
using System.Threading;

namespace AjaxRestAPI.Services
{

    public interface ICategoryServices
    {
        List<Category> GetCategories();

    }

    public class CategoryServices : ICategoryServices
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            Category category = new Category() { CategoryId = 1, CategoryName = "Category1" };
            categories.Add(category);

            category = new Category() { CategoryId = 2, CategoryName = "Category2" };
            categories.Add(category);

            category = new Category() { CategoryId = 3, CategoryName = "Category2" };
            categories.Add(category);

            return categories;
        }
    }
}
