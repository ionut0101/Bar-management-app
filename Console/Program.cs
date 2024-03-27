using Bar;
using System;
using InputGuard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDetails;

namespace ConsoleBar
{
    internal class Program
    {
        static void Main()
        {
            /*
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
            
            */

            IUser user = new User( "gicu" , "asd123451" );

            Dictionary<string, string> userErrors = UserIntegrityCheck.Validate(user);

            UserDB.UserDB userDB = new UserDB.UserDB();

            if (userErrors.Count == 0)
            {
                bool registered = userDB.Register(user);

                if (registered)
                {
                    Console.WriteLine("User registered");
                    Console.WriteLine(userDB.LookupByName(user.Name).Stringify());
                }
                else
                {
                    Console.WriteLine("Not registered");
                }

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("User errors : ");
                // show errors
                foreach( var userError in userErrors )
                {
                    Console.WriteLine("\n" + userError.Value);
                }
            }


            // list users
            Console.WriteLine("\nUser list :");
            List<IUser> users = userDB.GetAll();
            foreach( IUser currentUser in users )
            {
                Console.WriteLine(currentUser.Stringify());
            }
            Console.WriteLine("\n");


            // test auth
            // as putea face sa returneze ce eroare / urmeaza in viitoare update-uri / acum e fast-forward
            IUser testAuth = userDB.Auth( "Cjhrnel" , "asdfgdsgd");
            if (testAuth != null)
            {
                Console.WriteLine("Authed");
            }
            else
            {
                Console.WriteLine( "Auth error" );
            }
            
            

            Console.ReadLine();
        }
    }
}
