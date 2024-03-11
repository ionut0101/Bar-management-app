using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Product : IProduct
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

        public string GetValue(string propertyName)
        {
            var property = GetType().GetProperty(propertyName);

            if( property == null )
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            object result = property.GetValue(this);
            return result.ToString();
        }

        public void UpdateValue(string propertyName , string payload)
        {
            PropertyInfo property = GetType().GetProperty(propertyName);

            if( property == null)
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            property.SetValue(this , payload);
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
