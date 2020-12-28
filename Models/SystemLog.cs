using System;
using System.ComponentModel.DataAnnotations.Schema;
using aspnetcoreapp.Controllers;

namespace aspnetcoreapp.Models
{
    public class SystemLog : TimeModel
    {
        public int Id { get; set; }
        public ErrorLevel Level { get; set; }
        [Column(TypeName = "varchar(255)")] public string AuthorId { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "varchar(255)")] public string ProjectType { get; set; }
        [Column(TypeName = "varchar(255)")] public string WorkName { get; set; }
    }

    public class SystemLogResponse : TimeModel
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string AuthorId { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string WorkName { get; set; }
    }

    public enum ErrorLevel
    {
        Empty = -1,
        Warning = 1,
        Error = 2,
        Critical = 3,
    }
}