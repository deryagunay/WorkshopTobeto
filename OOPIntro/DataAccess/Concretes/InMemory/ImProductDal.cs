using OOPIntro.DataAccess.Abstracts;
using OOPIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.DataAccess.Concretes.InMemory
{
    public class ImProductDal:IProductDal
    {
        List<Product> products = new List<Product>();
        public ImProductDal()
        {
               
            products.Add(new Product   { Id = 1, Name ="Elma",UnitPrice=10, Description="Kırmızı elma",DiscountRate=10});
            products.Add(new Product { Id = 1, Name = "Armut", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 1, Name = "Üzüm", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 1, Name = "İncir", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
            products.Add(new Product { Id = 1, Name = "Kayısı", UnitPrice = 10, Description = "Kırmızı elma", DiscountRate = 10 });
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
