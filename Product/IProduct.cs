using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public interface IProduct
    {
        string Id { get; set; }
        string Name { get; set; }
        string Price { get; set; }
        string Description { get; set; }
        string Category { get; set; }
        string StockQuantity { get; set; }
        string Stringify();
        string GetValue(string propertyName);
        void UpdateValue(string propertyName, string payload);
        void Clear();
    }
}
