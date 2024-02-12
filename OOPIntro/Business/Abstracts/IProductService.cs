using OOPIntro.Business.Dtos.Requests;
using OOPIntro.Business.Dtos.Responses;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Business.Abstracts
{
    public interface IProductService
    {
        void Add(CreateProductRequest product);//request
        List<GetAllProductResponse> GetProducts(); //response
    }
}
