using OOPIntro.Business.Abstracts;
using OOPIntro.Business.Dtos.Requests;
using OOPIntro.Business.Dtos.Responses;
using OOPIntro.DataAccess.Abstracts;
using OOPIntro.DataAccess.Concretes.InMemory;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Business.Concretes
{
   /// <summary>
   /// githuba yüklenme testi
   /// </summary>
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(CreateCategoryRequest category)
        {

            Category categoryToCreate = new Category();
            categoryToCreate.Name = category.Name;
            categoryToCreate.Description = category.Description;
            _categoryDal.Add(categoryToCreate);

        }

        public List<GetAllCategoryResponse> GetCategories()
        {
            List<GetAllCategoryResponse> categories = new List<GetAllCategoryResponse>();
            foreach (var item in _categoryDal.GetCategories())
            {
                GetAllCategoryResponse responseCategory=new GetAllCategoryResponse();
                responseCategory.Id = item.Id;
                responseCategory.Name = item.Name;
                responseCategory.Description= item.Description;
                categories.Add(responseCategory);

            }



            return categories;
        }

        //public void Add(Category category)
        //{
        //    _categoryDal.Add(category);
        //}

        //public List<Category> GetCategories() 
        //{
        //    return _categoryDal.GetCategories();
        //}
    }
}
