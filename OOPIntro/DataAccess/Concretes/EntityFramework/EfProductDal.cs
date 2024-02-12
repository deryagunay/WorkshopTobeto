using OOPIntro.DataAccess.Abstracts;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.DataAccess.Concretes.EntityFramework
{
    
    

        public class EfProductDal:IProductDal
        {
            List<Product> products = new List<Product>();
            public EfProductDal()
            {

                products.Add(new Product { Id = 1, Name = "ElmaEf", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
                products.Add(new Product { Id = 1, Name = "ArmutEf", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
                products.Add(new Product { Id = 1, Name = "ÜzümEf", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
                products.Add(new Product { Id = 1, Name = "İncirEf", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
                products.Add(new Product { Id = 1, Name = "KayısıEf", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            }
            public void Add(Product product)
            {
                products.Add(product);
            }

            public List<Product> GetProducts()
            {

                return products;
            }
        }
    
}
