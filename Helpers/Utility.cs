using System;
using System.Text;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Helpers
{
    public static class Utility
    {
        public static Random Random = new Random();
        
        public static ApiType GetRandomApiType()
        {
            var rand  = Random.Next(0,3);
            var apiType = new ApiType[]
            {
                ApiType.Add,
                ApiType.Delete,
                ApiType.Edit,
                ApiType.ActivityLog
            };
            return apiType[rand];
        }
        
        public static string RandomString(int size, bool lowerCase = false)  
        {  
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';  
            const int lettersOffset = 26; // A...Z or a..z: length=26  
  
            for (var i = 0; i < size; i++)  
            {  
                var @char = (char)Random.Next(offset, offset + lettersOffset);  
                builder.Append(@char);  
            }  
  
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();  
        }

        public static ApiType GetTypeFromString(string s)
        {
            return s switch
            {
                "add" => ApiType.Add,
                "delete" => ApiType.Delete,
                "edit" => ApiType.Edit,
                "activity" => ApiType.ActivityLog,
                _ => ApiType.Empty
            };
        }
    }
}