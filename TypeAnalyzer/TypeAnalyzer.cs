using System;
using System.Reflection;

namespace Type
{
    public class Analyzer
    {
        public string GetValue(string propertyName)
        {
            var property = GetType().GetProperty(propertyName);

            if (property == null)
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            object result = property.GetValue(this);
            return result.ToString();
        }

        public void UpdateValue(string propertyName, string payload)
        {
            PropertyInfo property = GetType().GetProperty(propertyName);

            if (property == null)
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            property.SetValue(this, payload);
        }
    }
}
