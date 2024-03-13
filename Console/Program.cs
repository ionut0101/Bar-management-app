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
            /*
            Product product = new Product(name: "LOUIS XIII de Remy Martin", price: "590 LEI", category: "COGNACS", description: "top 1" , stockQuantity : "10");
            Product secondProduct = new Product(name: "Cuba libre", price: "29 LEI", category: "CLASSIC", description: "top 2", stockQuantity: "22");
            Product thirdProduct = new Product(name: "Remy Martin XO", price: "115 LEI", category: "COGNACS", description: "top 3", stockQuantity: "13");
            */

            DB.IProductDB db = new DB.ProductDB("test.txt");
            /*
            db.Create(product);
            db.Create(secondProduct);
            db.Create(thirdProduct);
            */
            
            List<IProduct> list = db.LookupByName("cub");

            foreach (IProduct p in list)
            {
                Console.WriteLine(p.Stringify());
            }
   
        }
    }
}
