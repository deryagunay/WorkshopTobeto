using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro.Entities
{
    public class Product
    {
        public Product()
        {
                
        }

        // ctrl .  generate consructor oluşturur.
        public Product(int ıd, string name, string description, double unitPrice)
        {
            Id = ıd;
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
        }

        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } 
        public double UnitPrice { get; set; }  
        public double DiscountRate { get; set; }
        public double DiscountedPrice  => UnitPrice - (UnitPrice * DiscountRate / 100);  //bu şekilde kullanımda sadece get edilebilir

        public Category Category { get; set; }

    }
}
