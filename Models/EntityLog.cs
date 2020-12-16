using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace aspnetcoreapp.Models
{
    public class TimeModel : IComparable
    {
        public DateTime Timestamp { get; set; }

        public int CompareTo(object? obj)
        {
            if (!(obj is TimeModel entityLog)) return 1;
            return Timestamp.CompareTo(entityLog.Timestamp);
            // if (this.Timestamp > entityLog.Timestamp)
            // {
            //     return 1;
            // }
            // else if (this.Timestamp < entityLog.Timestamp)
            // {
            //     return -1;
            // }
            //
            // return 0;
        }
    }

    public class EntityLog : TimeModel
    {
        [Key] public int EntityLogPrimaryKeyId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string EntityId { get; set; }
        public string AuthorId { get; set; }
        public LogType Type { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
    }

    public class EntityActivityLog : EntityLog
    {
        public string State { get; set; }
    }

    public class EntityActivityLogInput : EntityActivityLog
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class EntityActivityLogDTO : EntityLogDTO
    {
    }

    public class EntityLogDTO : TypeAndTimeStamp
    {
        public string EntityId { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public string AuthorId { get; set; }
    }

    public class TypeAndTimeStamp
    {
        public string Type { get; set; }
        public string Timestamp { get; set; }
    }

    public class CommonRequest
    {
        public string EntityId { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public string ProjectType { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
    }

    public class UserPassword
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public static class ProjectType
    {
        public const string DeDieu = "DE_DIEU";
        public const string CayTrong = "CAY_TRONG";
        public const string ChayRung = "CHAY_RUNG";
        public const string LuoiDien = "LUOI_DIEN";

        private static readonly Dictionary<int, string> Project = new Dictionary<int, string>()
        {
            {1, ProjectType.DeDieu},
            {2, ProjectType.CayTrong},
            {3, ProjectType.ChayRung},
            {4, ProjectType.LuoiDien}
        };

        public static string GetRandomProjectType()
        {
            var rand = new Random().Next(1, 5);
            return Project[rand];
        }

        public static bool IsProjectType(string s)
        {
            return s != null && Project.Any((pair => pair.Value.ToLower() == s.ToLower()));
        }
    }
}