using System;
using System.ComponentModel;
using System.Reflection;

namespace aspnetcoreapp
{
    public static class ExtensionMethods
    {
        public static string getDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}