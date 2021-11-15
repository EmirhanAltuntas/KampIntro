using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Id + " " + product.CategoryId + " " + product.ProductName + " " + product.UnitPrice + " " + product.UnitInStock);
        }

        public  void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi! ") ;
        }
    
     


    }
}
