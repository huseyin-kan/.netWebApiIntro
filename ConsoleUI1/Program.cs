using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //foreach(var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
            ProductManager productManager= new ProductManager(new EfProductDal());
            foreach (var productDetail in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(productDetail.ProductName + "/" + productDetail.CategoryName);
            }

        }
    }
}
