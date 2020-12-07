using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace aspnetcoreapp.Models
{
    public class TimeModel : IComparable
    {
        public DateTime Timestamp { get; set; }

        public int CompareTo(object? obj)
        {
            if (!(obj is TimeModel entityLog)) return 1;
            if (this.Timestamp > entityLog.Timestamp)
            {
                return 1;
            }
            else if (this.Timestamp < entityLog.Timestamp)
            {
                return -1;
            }

            return 0;
        }
    }

    public class EntityLog : TimeModel
    {
        [Key] public int EntityLogPrimaryKeyId { get; set; }
        public int EntityId { get; set; }
        public ApiType Type { get; set; }
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
        public string State { get; set; }
    }

    public class EntityLogDTO : TypeAndTimeStamp
    {
        public int EntityId { get; set; }
        public string Description { get; set; }
    }

    public class TypeAndTimeStamp
    {
        public string Type { get; set; }
        public string Timestamp { get; set; }
    }

    public class CommonRequest
    {
        public int EntityId { get; set; }
        public string Description { get; set; }
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
            var rand = new Random().Next(1, 4);
            return Project[rand];
        }
    }
}