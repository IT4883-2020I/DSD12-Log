using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace aspnetcoreapp.Models
{
    public class EntityLog
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public ApiType Type { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class EntityLogDTO
    {
        public int EntityId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Timestamp { get; set; }
    }
    public class DroneLog : EntityLog { }
    public class Payload : EntityLog { }
    public class UserLog : EntityLog { }
    public class ImageLog : EntityLog { }
    public class VideoLog : EntityLog { }
    public class IncidentLog : EntityLog { }
    public class ObjectObserve : EntityLog { }

    public enum ApiType
    {
        Get,
        [Description("Add")] Add,
        [Description("Delete")] Delete,
        [Description("Edit")] Edit,
        [Description("Has Problem")] HasProblem,
        [Description("Change Schedule")] ChangeSchedule,
        [Description("Register")] Register,
        [Description("Work")] Work,
        [Description("Role")] Role,
        [Description("Result")] Result,
        Confirm,
        [Description("Change State")] ChangeState,

    }


}