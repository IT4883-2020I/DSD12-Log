using System;
using aspnetcoreapp.Controllers;

namespace aspnetcoreapp.Models
{
    public class SystemLog
    {
        public int Id { get; set; }
        public ErrorLevel Level { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }
    }

    public enum ErrorLevel
    {
        Empty = -1,
        Warning = 1,
        Error = 2,
        Critical = 3,
    }
}