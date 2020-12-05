
using System;
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
}