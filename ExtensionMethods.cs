using System;
using System.ComponentModel;
using System.Reflection;
using aspnetcoreapp.Helpers;
using Newtonsoft.Json;

namespace aspnetcoreapp
{
    public static class ExtensionMethods
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            if (field == null)
            {
                return null;
            }

            DescriptionAttribute attribute =
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static string ToDescriptionString(this DateTime dateTime)
        {
            return dateTime.ToShortTimeString() + " " +
                   dateTime.ToShortDateString();
        }
    }
}