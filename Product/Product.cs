using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Type;

namespace Bar
{
    public class Product : Analyzer , IProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string StockQuantity { get; set; }

        public Product() { }

        public Product(string name, string price, string description, string category , string stockQuantity)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            StockQuantity = stockQuantity;
        }

        public Product(string id , string name , string price , string description , string category , string stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            StockQuantity = stockQuantity;
        }

        public string Stringify()
        {
            return $"Id :\t\t{Id}\nName :\t\t{Name}\nPrice :\t\t{Price}\nDescription :\t{Description}\nCategory :\t{Category}\nStock :\t\t{StockQuantity}\n";
        }

        public void Clear()
        {
            Id = string.Empty;
            Name = string.Empty;
            Price = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            StockQuantity = string.Empty;
        }
    }
}
