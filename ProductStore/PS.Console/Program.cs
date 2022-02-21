using PS.Domain;
using System;
using System.Collections.Generic;

namespace PS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Category cat2 = new Category()
            {
                Name = "cat2"
            };
            Category cat1 = new Category()
            {
                Name = "cat1"
            };
            Category cat3 = new Category()
            {
                Name = "cat3"
            };
            Product prod1 = new Product() {
                Name = "prod1",
                Quantity = 14,
                MyCategory=cat1
            };
            Product prod2 = new Biological()
            {
                Name = "prod2",
                MyCategory = cat1
            };
            Product prod3 = new Biological()
            {
                Name = "prod3",
                MyCategory = cat3
            };
            Product prod4 = new Biological()
            {
                Name = "prod4"
            };
            Product prod5 = new Biological()
            {
                Name = "prod5",
                MyCategory = cat2
            };
            Product prod6 = new Biological()
            {
                Name = "prod6",
                MyCategory = cat3
            };
            cat1.Products = new List<Product>() { prod1, prod2 };
            cat2.Products = new List<Product>() { prod5 };
            cat3.Products = new List<Product>() { prod3, prod6 };

            //prod.GetDetails();
            //prod2.GetDetails();

            Provider prov1 = new Provider()
            {
                UserName="prov1",
                Password = "00000",
                ConfirmPassword = "00000",
                Products= new List<Product>() { prod1, prod2, prod3 }
        };
            Provider prov2 = new Provider()
            {
                UserName = "prov2",
                Password = "00000",
                ConfirmPassword = "00000",
                Products = new List<Product>() { prod1, prod5 }
            };
            Provider prov3 = new Provider()
            {
                UserName = "prov3",
                Password = "00000",
                ConfirmPassword = "00000",
                Products = new List<Product>() { prod1, prod4 }
            };
            Provider prov4 = new Provider()
            {
                UserName = "prov4",
                Password = "00000",
                ConfirmPassword = "00000",
                Products = new List<Product>() { prod6, prod4 }
            };
            Provider prov5 = new Provider()
            {
                UserName = "prov5",
                Password = "00000",
                ConfirmPassword = "00000",
                Products = new List<Product>() { prod6, prod4 }
            };
            
            
            prod1.Providers = new List<Provider>() { prov1,prov2,prov3 };
            prod2.Providers = new List<Provider>() { prov1};
            prod3.Providers = new List<Provider>() { prov1};
            prod4.Providers = new List<Provider>() { prov3, prov4, prov5 };
            prod5.Providers = new List<Provider>() { prov2};
            prod6.Providers = new List<Provider>() { prov4, prov5 };

            prov1.GetDetails(); 
            //System.Console.WriteLine(P1.ConfirmPassword);
            //P1.Login("khalifa", "00000");
            //prod.GetDetails();
            //prod2.GetDetails();

            //System.Console.WriteLine(P1.Password);
            //bool b=false;
            //Provider.SetIsApproved("123", "123", ref b);
            //Provider.SetIsApproved(P1);
            //System.Console.WriteLine(b);
            //System.Console.WriteLine(P1.IsApproved);

        }
    }
}
