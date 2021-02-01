using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ CarId=1,CarBrantId="Mercedes", CarModelYear="2020", ColorId=1, CarDailyPrice=200, CarDescription="Otomatik Dizel" },
                new Product{ CarId=2,CarBrantId="VW", CarModelYear="2020", ColorId=1, CarDailyPrice=260, CarDescription="Otomatik Dizel" },
                new Product{ CarId=3, CarBrantId="Mercedes",CarModelYear="2021", ColorId=2, CarDailyPrice=300, CarDescription="Otomatik Benzin" },
                new Product{ CarId=4,CarBrantId="VW", CarModelYear="2019", ColorId=3, CarDailyPrice=200, CarDescription="Otomatik Dizel" },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product); 
        }

        public void Delete(Product product)
        {
           
            Product productToDelete = _products.SingleOrDefault(p=>p.CarId==product.CarId);
            _products.Remove(productToDelete);


        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int carCategoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.CarId == product.CarId);
            productToUpdate.CarId = product.CarId;
            productToUpdate.CarBrantId = product.CarBrantId;
            productToUpdate.CarModelYear = product.CarModelYear;
            productToUpdate.CarDailyPrice = product.CarDailyPrice;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.CarDescription = product.CarDescription;

        }

        public List<Product> GetAllByCategory1(int carCategoryId)
        {
            return _products.Where(p => p.CarId == carCategoryId).ToList();
        }
    }
}
