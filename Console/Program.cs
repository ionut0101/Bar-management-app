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
            Bar.IProduct product = new Bar.Product(id : "2" , name: "test fdsfsd", price: "2.5 lei dada", category: "Suc", description: "beem si de asta" , stockQuantity : "15");

            DB.IProductDB db = new DB.ProductDB("test.txt");
            
            //db.Update(product);
            /*
            IProduct newProduct = new Product();

            newProduct.Name = "Produs nou";
            newProduct.Price = "10 lei baiatu";
            newProduct.Category = "Beutura";
            newProduct.Description = "Bei maine si mori azi";
            newProduct.StockQuantity = "20";
            

            db.Create(newProduct);
            */

            db.DeleteById("1");
            
            //DB.IProductDB db = new DB.ProductDB("test.txt");

            List<Bar.IProduct> list = db.GetAll();

            foreach (IProduct p in list)
            {
                Console.WriteLine(p.Stringify());
            }
            

        }
    }
}
