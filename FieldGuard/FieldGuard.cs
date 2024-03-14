using Bar;
using System;
using System.Collections.Generic;

namespace InputGuard
{
    public class ProductIntegrityCheck
    {
        const int nameMinLength = 1;
        const int nameMaxLength = 32;
        const int descriptionMinLength = 0;
        const int descriptionMaxLength = 50;

        public static Dictionary<string, string> Validate(IProduct product)
        {

            // This method is still under development. Additional constraints may be introduced in future updates.

            Dictionary<string, string> errorList = new Dictionary<string, string>();
            var properties = product.GetType().GetProperties();

            bool isError;
            string temporary;

            foreach (var property in properties)
            {
                if ( property.Name == "Id" )
                {
                    continue;
                }

                isError = false;
                temporary = product.GetValue( property.Name );

                if (property.Name == "Price" || property.Name == "StockQuantity" )
                {
                    isError = FieldNumberCheck(temporary);
                }

                if (property.Name == "Name")
                {
                    isError = FieldNameCheck(temporary);
                }

                if (property.Name == "Description")
                {
                    isError = FieldDescriptionCheck(temporary);
                }

                if (isError)
                {
                    errorList.Add(property.Name, $"{property.Name} is invalid.");
                }
            }

            return errorList;
        }

        static bool FieldNumberCheck(string payload)
        {
            return !int.TryParse(payload, out _);
        }

        static bool FieldNameCheck(string productName)
        {
            return productName.Length <= nameMinLength || productName.Length >= nameMaxLength;
        }
        static bool FieldDescriptionCheck(string productDescription)
        {
            return productDescription.Length <= descriptionMinLength || productDescription.Length >= descriptionMaxLength;
        }
    }
}
