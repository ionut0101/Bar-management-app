using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bar;

namespace DB
{
    public class ProductDB : IProductDB
    {
        private string dataBaseName;
        private char dataBaseSeparator = ':';
        private Dictionary<string, int> dataBaseColumns = new Dictionary<string, int>();

        public ProductDB(string databaseName)
        {
            dataBaseName = AppDomain.CurrentDomain.BaseDirectory + databaseName;

            if( !File.Exists(dataBaseName) )
            {
                File.Create(dataBaseName).Close();
            }

            dataBaseColumns.Add( "Id" , 0 );
            dataBaseColumns.Add( "Name" , 1 );
            dataBaseColumns.Add( "Price" , 2 );
            dataBaseColumns.Add( "Category" , 3 );
            dataBaseColumns.Add( "Description" , 4 );
            dataBaseColumns.Add( "StockQuantity", 5 );
        }

        public string ToStringFormat( Bar.IProduct product )
        {
            string result = string.Empty;
            foreach(string tableKey in dataBaseColumns.Keys)
            {
                result += product.GetValue(tableKey) + dataBaseSeparator;
            }

            result = result.Remove(result.Length - 1, 1);

            return result;
        }

        public IProduct ToProductFormat( string payload )
        {
            IProduct product = new Product();
            string[] details = payload.Split( dataBaseSeparator );

            int index;
            string tableColumn;

            try
            {
                for (index = 0; index < details.Length; index++)
                {
                    tableColumn = dataBaseColumns.FirstOrDefault(x => x.Value == index).Key;
                    if (tableColumn != null)
                    {
                        product.UpdateValue( tableColumn , details[ index ] );
                    }
                }

                return product;
            } catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public List<IProduct> GetAll()
        {
            List<IProduct> products = new List<IProduct>();

            IProduct currentProduct;
            StreamReader streamReader = new StreamReader( dataBaseName );
            string databaseRow;

            while(( databaseRow = streamReader.ReadLine() ) != null )
            {
                currentProduct = ToProductFormat(databaseRow);
                products.Add(currentProduct);
            }

            streamReader.Close();
            return products;
        }

        public List<IProduct> LookupByName( string productName )
        {
            List<IProduct> list = new List<IProduct>();
            string dataBaseRow;
            IProduct product;
            productName = productName.ToLower();

            if( productName.Length == 0 )
            {
                return list;
            }

            StreamReader streamReader = new StreamReader( dataBaseName );

            while((dataBaseRow = streamReader.ReadLine()) != null)
            {
                product = ToProductFormat( dataBaseRow );
                if( product.GetValue( "Name" ).ToLower().Contains( productName ) )
                {
                    list.Add( product );
                }
            }

            streamReader.Close();

            return list;
        }

        public string GetLastInsertedId()
        {
            string lastId = "0";
            string lastRow = string.Empty, currentRow;
            StreamReader streamReader = new StreamReader( dataBaseName );

            while((currentRow = streamReader.ReadLine()) != null)
            {
                lastRow = currentRow;
            }

            streamReader.Close();

            if( lastRow != string.Empty )
            {
                IProduct product = ToProductFormat(lastRow);
                return product.GetValue( "Id" );
            }

            return lastId;
        }

        public bool Create(IProduct product)
        {
            try
            {
                string lastId = GetLastInsertedId();
                int nextId = Convert.ToInt32(lastId);
                nextId++;

                product.UpdateValue( "Id", nextId.ToString() );

                StreamWriter streamWriter = new StreamWriter( dataBaseName, append: true );
                string streamPayload = ToStringFormat(product);

                streamWriter.WriteLine(streamPayload);
                streamWriter.Close();

                return true;
            } catch(Exception)
            {
                return false;
            }
    
        }

        public void DeleteById( string removeId )
        {
            try
            {
                string[] rows = File.ReadAllLines( dataBaseName );
                List<string> newRows = new List<string>();

                IProduct product;

                foreach (string row in rows)
                {
                    product = ToProductFormat(row);
                    if (product.GetValue( "Id" ) != removeId)
                    {
                        newRows.Add(row);
                    }
                }

                File.WriteAllLines(dataBaseName , newRows);
            } catch(Exception)
            {

            }
        }

        public bool Update(IProduct product)
        {
            try
            {
                string[] rows = File.ReadAllLines( dataBaseName );
                int rowIndex;
                bool productExists = false;
                IProduct currentProduct;

                for( rowIndex = 0; rowIndex < rows.Length; rowIndex++ )
                {
                    currentProduct = ToProductFormat( rows[ rowIndex ] );
                    if( currentProduct.GetValue( "Id" ) == product.Id )
                    {
                        rows[rowIndex] = ToStringFormat( product );
                        productExists = true;
                        break;
                    }
                }

                if( productExists )
                {
                    File.WriteAllLines( dataBaseName, rows );
                }

                return productExists;
            } catch(Exception)
            {
                return false;
            }
        }
    }
}
