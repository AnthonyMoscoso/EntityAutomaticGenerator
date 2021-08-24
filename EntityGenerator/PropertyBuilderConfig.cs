using Core.Entities.Utilities.EntityGenerator.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Utilities.EntityGenerator
{
    public class PropertyBuilderConfig<TProperty> : IPropertyBuilderConfig
    {
        public IDictionary<string, string> Parameters { get; set; }
        public string PropertyName { get; set; }
        public PropertyBuilderConfig(string propertyName, IDictionary<string, string> parameters = null)
        {
            PropertyName = propertyName;

            if (parameters == null)
            {
                Parameters = new Dictionary<string, string>();
            }
            else
            {
                Parameters = parameters;
            }

        }

        public IPropertyBuilderConfig IsEmail(bool isEmail = true)
        {
            Parameters.Add("IsMail", isEmail.ToString());
            return this;
        }

        public IPropertyBuilderConfig IsPhoneNumber(bool isPhone = true)
        {
            Parameters.Add("IsPhone", isPhone.ToString());
            return this;
        }

        public IPropertyBuilderConfig IsUnique(bool unique = true)
        {

            Parameters.Add("IsUnique", unique.ToString());
            return this;

        }

        public IPropertyBuilderConfig MaxLeng(int max)
        {
            Parameters.Add("MaxLeng", max.ToString());
            return this;
        }

        public IPropertyBuilderConfig MaxValue(double value)
        {
            Parameters.Add("MaxValue", value.ToString());
            return this;
        }

        public IPropertyBuilderConfig DateEnd(DateTime dateTime)
        {
            Parameters.Add("DateEnd", dateTime.ToString());
            return this;
        }

        public IPropertyBuilderConfig MaxValue(char value)
        {
            Parameters.Add("MaxValue", value.ToString());
            return this;
        }

        public IPropertyBuilderConfig MinLeng(int min)
        {
            Parameters.Add("MinLeng", min.ToString());
            return this;
        }

        public IPropertyBuilderConfig MinValue(double value)
        {
            Parameters.Add("MinValue", value.ToString());
            return this;
        }

        public IPropertyBuilderConfig DateStart(DateTime dateTime)
        {
            Parameters.Add("DateStart", dateTime.ToString());
            return this;
        }

        public IPropertyBuilderConfig MinValue(char value)
        {
            Parameters.Add("MinValue", value.ToString());
            return this;
        }

        public IPropertyBuilderConfig IsEnum(Type enumType)
        {

            Array enumValues = Enum.GetValues(enumType);
            Parameters.Add("MaxValue", (enumValues.Length - 1).ToString());
            Parameters.Add("MinValue", "0");
            return this;
        }

        public IPropertyBuilderConfig ParamsFilter(ICollection<string> parameters)
        {
            string filters = string.Empty;
            foreach (string s in parameters)
            {
                filters += s + ";";
            }
            filters = filters.Remove(filters.Length - 1);

            Parameters.Add("Parameters", filters);
            return this;
        }

        public IPropertyBuilderConfig TextFormat(TextFormats textFormats)
        {
            Parameters.Add("TextFormat", textFormats.ToString());
            return this;
        }
    }
}
