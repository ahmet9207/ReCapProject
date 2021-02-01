using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var product  in productManager.GetAll()) 
            {
                Console.WriteLine("Kiralanan Araba-----------");
                Console.WriteLine(product.CarBrantId);
                Console.WriteLine("Araba Model Yılı----------");
                Console.WriteLine(product.CarModelYear);
                Console.WriteLine("Araba Özellikleri---------");
                Console.WriteLine(product.CarDescription);
            }
        }
    }
}
