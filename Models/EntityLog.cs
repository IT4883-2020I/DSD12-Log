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

    public class EntityStateLogDTO
    {
        public int EntityId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Timestamp { get; set; }
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

    public class DroneLog : EntityLog
    {
        public static int GroupId = 1;
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
    }

    public class DroneLogRequest : DroneLog
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Payload : EntityActivityLog
    {
        public static int GroupId = 2;
    }

    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Role { get; set; }
        public string WorkName { get; set; }
    }

    public class UserLogRequest : UserLog
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
    }

    public class IncidentLog : EntityActivityLog
    {
        public static int GroupId = 5;
    }

    public class IncidentLogRequest : IncidentLog
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class ObjectObserve : EntityActivityLog
    {
        public static int GroupId = 6;
    }

    public class StaticalLog : EntityActivityLog
    {
        public static int GroupId = 7;
    }

    public class WarningLog : EntityActivityLog
    {
        public static int GroupId = 8;
    }

    public class MonitorRegionLog : EntityActivityLog
    {
        public static int GroupId = 10;
    }

    public class ResolveProblemLog : EntityActivityLog
    {
        public static int GroupId = 11;
    }

    public class UavConnectLog : EntityActivityLog
    {
        public static int GroupId = 12;
    }

    public enum ApiType
    {
        Empty,
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
        [Description("Export Report")] ExportReport,
        [Description("Frequence Incident")] FrequenceIncident,
        [Description("Common Incident")] CommonIncident,
        [Description("Warning Level")] WarningLevel,
        [Description("Solution Handling")] SolutionHandling,
        [Description("Devide Monitor Region")] DevideRegion,
        StaffResolveProblem,
        ResultResolveProblem,
        UpdateStatusResolveProblem,
        SuccessConnect,
        FailConnect,
        ActivityLog
    }
}