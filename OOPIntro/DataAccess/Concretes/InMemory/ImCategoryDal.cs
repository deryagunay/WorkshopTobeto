using OOPIntro.DataAccess.Abstracts;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal:ICategoryDal
    {
        List<Category> categories=new List<Category>();
        public ImCategoryDal()
        {
            categories.Add(new Category {Id=1 , Name="Meyve"});
            categories.Add(new Category { Id=2,Name="Sebze"});
            categories.Add(new Category { Id = 3, Name = "Süt ürünleri"});

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
