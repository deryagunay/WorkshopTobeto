using OOPIntro.Business.Abstracts;
using OOPIntro.Business.Dtos.Requests;
using OOPIntro.Business.Dtos.Responses;
using OOPIntro.DataAccess.Abstracts;
using OOPIntro.DataAccess.Concretes.EntityFramework;
using OOPIntro.DataAccess.Concretes.InMemory;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Business.Concretes
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        //github deneme
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //ImProductDal productDal = new ImProductDal();
        public void Add(CreateProductRequest product)
        {
            //business rules
            Product productToCreate = new Product();
            productToCreate.Name = product.Name;
            productToCreate.UnitPrice = product.UnitPrice;
            productToCreate.Description = product.Description;
            productToCreate.DiscountRate = product.DiscountRate;


            ////vidodan bak
            _productDal.Add(productToCreate);
            
        }
        public List<GetAllProductResponse> GetProducts() 
        {
            //business
            List<GetAllProductResponse> products = new List<GetAllProductResponse>();
            foreach (var item in _productDal.GetProducts())
            {
                GetAllProductResponse getAllProductResponse = new GetAllProductResponse();
                getAllProductResponse.Id = item.Id;
                getAllProductResponse.Name= item.Name;
                getAllProductResponse.Description = item.Description;
                getAllProductResponse.UnitPrice = item.UnitPrice;
                getAllProductResponse.DiscountRate=item.DiscountRate;
                products.Add(getAllProductResponse);

            }
            return products;
        }
    }
}
