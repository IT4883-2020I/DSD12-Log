using System;
using System.Text;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Helpers
{
    public static class Utility
    {
        public static Random Random = new Random();

        public static LogType GetRandomApiType()
        {
            var rand = Random.Next(0, 4);
            var apiType = new LogType[]
            {
                LogType.Add,
                LogType.Delete,
                LogType.Edit,
                LogType.ActivityLog
            };
            return apiType[rand];
        }

        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            var offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char) Random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public static LogType GetTypeFromUrl(string url)
        {
            var splits = url.Split('/');
            return splits[^1] switch
            {
                "add" => LogType.Add,
                "delete" => LogType.Delete,
                "edit" => LogType.Edit,
                "activity" => LogType.ActivityLog,
                _ => LogType.Empty
            };
        }

        public static int CompareEntityLog(EntityLog a, EntityLog b)
        {
            if (a.Timestamp > b.Timestamp)
            {
                return 1;
            }
            else if (a.Timestamp < b.Timestamp)
            {
                return -1;
            }

            return 0;
        }
    }
}