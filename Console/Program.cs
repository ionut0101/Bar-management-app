using Bar;
using System;
using InputGuard;
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
            Product product = new Product(name: "LOUIS XIII de Remy Martin", price: "590", category: "asd", description: "top 1" , stockQuantity : "asd");
            Product secondProduct = new Product(name: "Cuba libre", price: "29", category: "2", description: "top 2", stockQuantity: "22");
            Product thirdProduct = new Product(name: "Remy Martin XO", price: "115", category: "3", description: "top 3", stockQuantity: "13");

                       
            DB.IProductDB db = new DB.ProductDB("test.txt");

            if(ProductIntegrityCheck.Validate(product).Count == 0)
            {
                db.Create(product);
            }

            if (ProductIntegrityCheck.Validate(secondProduct).Count == 0)
            {
                db.Create(secondProduct);
            }

            if (ProductIntegrityCheck.Validate(thirdProduct).Count == 0)
            {
                db.Create(thirdProduct);
            }

            List<IProduct> list = db.GetAll();

            foreach (IProduct p in list)
            {
                Console.WriteLine(p.Stringify());
            }
            
            

        }
    }
}
