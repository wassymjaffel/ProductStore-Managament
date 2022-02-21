using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Service
{
    public class ManageProduct
    {
        public List<Product> Products { get; set; }

        public List<Product> Get5Chemical(double price)
        {
            return (from prod in Products
                    where prod.Price > price && prod is Chemical
                    select prod).Take(5).ToList();
        }

        public List<Product> GetProductPrice(double price)
        {
            return (from prod in Products
                    where prod.Price > price
                    select prod).Skip(2).ToList();
        }

        public double GetAveragePrice()
        {
            return (from prod in Products
                    select prod.Price).Average();
        }

        public Product GetMaxPrice()
        {
            double max=(from prod in Products
            select prod.Price).Max();

            return (from prod in Products
                    where prod.Price==max
                    select prod).FirstOrDefault();
        }
        public Product GetMaxPrice2()
        {
            return (from prod in Products
                    orderby prod.Price descending
                    select prod).FirstOrDefault();
        }

        public int GetCountProduct(string city)
        {
            return (from prod in Products
                    where prod is Chemical && ((Chemical) prod).City == city
                    select prod.Price).Count();
        }
        public List<Product> GetChemicalCity()
        {
            return (from prod in Products
                    orderby ((Chemical)prod).City 
            select prod).ToList();
        }

   

        public List<Product> GetChemicalGroupByCity()
        {
            return (from product in Products
                    orderby ((Chemical)product).City 
              
                    select product).ToList();
        }
    
       
    }
}
