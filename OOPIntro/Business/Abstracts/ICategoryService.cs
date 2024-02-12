using OOPIntro.Business.Dtos.Requests;
using OOPIntro.Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest product);
        List<GetAllCategoryResponse> GetCategories();
    }
}
