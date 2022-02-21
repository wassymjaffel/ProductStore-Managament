using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {
        String password;
        public String Password {
            get { return password; }
            set { if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else
                    Console.WriteLine("pass length >5 <20");
            }
        }
        public int Id { get; set; }
        public String Email { get; set; }
        public DateTime DateCreated { get; set; }
        public Boolean IsApproved { get; set; }
        public String UserName { get; set; }
        String confirmPassword;
        public String ConfirmPassword {
            get { return confirmPassword; }
            set { if (password==value)
                    confirmPassword = value;
                  else
                    Console.WriteLine("confirmPass <> pass ");
            } 
        }
        public IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("UserName : " + UserName + ", Email : " + Email);
            foreach(Product p in Products){
                p.GetDetails();
            }
        }

        public static void SetIsApproved(Provider P)
        {
            //if (P.Password == P.ConfirmPassword)
            //{
            //    P.IsApproved = true;
            //}
            //else
            //{
            //    P.IsApproved = false;
            //}
            P.IsApproved = P.Password == P.ConfirmPassword ? true : false;
        }
        public static void SetIsApproved(String password, String confirmPassword, ref bool isApproved)
        {
            isApproved = password == confirmPassword;
        }

        //public bool Login(String userName, String password)
        //{
        //    return userName == UserName && password == Password;
        //}

        //public bool Login(String userName, String password,  String email)
        //{
        //    return userName == UserName && password == Password && email == Email;
        //}

        public bool Login(String userName, String password, String email=null)
        {
            if (email != null)
                return userName == UserName && password == Password && email == Email;
            else
                return userName == UserName && password == Password;
        }
        public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Description":
                    foreach (Product p in Products) {
                        if (filterValue == p.Description)
                            p.GetDetails();
                            }
                    break;
                case "Name":
                    foreach (Product p in Products)
                    {
                        if (filterValue == p.Name)
                            p.GetDetails();
                    }
                    break;
                case "ProductId":
                    foreach (Product p in Products)
                    {
                        if (int.Parse(filterValue) == p.ProductId)
                            Console.WriteLine(p);
                    }
                    break;
                case "DateProd":
                    foreach (Product p in Products)
                    {
                        if (DateTime.Parse(filterValue) == p.DateProd)
                            Console.WriteLine(p);
                    }
                    break;
                default:
                    Console.WriteLine("filtre inconnu");
                    break;
            }
        }
    }
}
