using System;
using System.Collections.Generic;

namespace PS.Domain
{
    public class Product : Concept
    {
        public DateTime DateProd{get; set;}
        public String Description { get; set; }
        public String Name { get; set; }
        public  double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public IList<Provider> Providers { get; set; }
        public Category MyCategory { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("name :" + Name +" , quantity : "+Quantity) ;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("Product");
        }
        
    }
}
