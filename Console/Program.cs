using Bar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bar.IProduct product = new Bar.Product(name: "Coca-Cola", price: "7.5 lei doar acum", category: "Beutura neagra", description: "yoyoyo" , stockQuantity : "100");

            DB.IProductDB db = new DB.ProductDB("test.txt");
            
            db.Create(product);
            /*
            IProduct newProduct = new Product();

            newProduct.Name = "Produs nou";
            newProduct.Price = "10 lei baiatu";
            newProduct.Category = "Beutura";
            newProduct.Description = "Bei maine si mori azi";
            newProduct.StockQuantity = "20";
            

            db.Create(newProduct);
            */

            //db.DeleteById("1");
            
            //DB.IProductDB db = new DB.ProductDB("test.txt");

            List<Bar.IProduct> list = db.GetAll();

            foreach (IProduct p in list)
            {
                Console.WriteLine(p.Stringify());
            }
            

        }
    }
}
