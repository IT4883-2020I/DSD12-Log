using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace aspnetcoreapp.Models
{
    public class EntityLog
    {
        [Key]
        public int EntityLogPrimaryKeyId { get; set; }
        public int EntityId { get; set; }
        public string Name { get; set; }
        public ApiType Type { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
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

    public class EntityLogDTO
    {
        public int EntityId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Timestamp { get; set; }
    }


    public class DroneLogRequest : DroneLog
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }


    public class UserLogRequest : UserLog
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }













}