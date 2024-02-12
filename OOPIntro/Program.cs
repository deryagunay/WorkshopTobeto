// See https://aka.ms/new-console-template for more information
using OOPIntro.Business.Concretes;
using OOPIntro.DataAccess.Concretes.EntityFramework;
using OOPIntro.Entities;

Console.WriteLine("Hello, World!");

int number1 = 10;
Product product1= new Product();
product1.Id = 1;
product1.Name = "laptop";
product1.Description = "aşırı güçlü laptop";
product1.UnitPrice = 50000;
product1.DiscountRate = 10;

Product product2= new Product(1,"GSM","samsung bişey",70000);

ProductManager productManager = new ProductManager(new EfProductDal());
//productManager.Add(product1);
//productManager.Add(product2);

foreach (var product in productManager.GetProducts())
{
    Console.WriteLine(product.Name);
}

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
Category category1 = new Category();
category1.Id = 1;
category1.Name = "sebzePcs";
//categoryManager.Add(category1);
Category category2 = new Category();
category2.Id = 2;
category2.Name = "MeyvePcs";
//categoryManager.Add(category2);

foreach (var category in categoryManager.GetCategories())
{
    Console.WriteLine(category.Name);
}



