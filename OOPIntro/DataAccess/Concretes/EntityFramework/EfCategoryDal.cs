using OOPIntro.DataAccess.Abstracts;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        List<Category> categories = new List<Category>();
        public EfCategoryDal()
        {
            categories.Add(new Category { Id = 1, Name = "MeyveEF" });
            categories.Add(new Category { Id = 2, Name = "SebzeEF" });
            categories.Add(new Category { Id = 3, Name = "Süt ürünleriEF" });

        }

        public void Add(Category category)
        {
            categories.Add(category);
        }
        public List<Category> GetCategories()
        {
            return categories;
        }
    }
}