using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PS.Service
{
    public static class ProductExtension
    {
        public static string ToUpper(this ManageProduct manageProduct ,string name) 
        {
            return name.ToUpper();
        }
        

        public static bool InCategory(this ManageProduct manageProduct, Product p, string categoryName)
        {
            return p.MyCategory.Name.Equals(categoryName);
        }
    }


}
