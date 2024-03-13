using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar;

namespace DB
{
    public interface IProductDB
    {
        bool Create(IProduct product);
        List<IProduct> GetAll();
        void DeleteById( string id );
        bool Update(IProduct product);
        List<IProduct> LookupByName( string productName );
        string GetLastInsertedId();
        string ToStringFormat(IProduct product);
        IProduct ToProductFormat(string payload);
    }
}
