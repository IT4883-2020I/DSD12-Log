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

    public class DroneLog : EntityLog
    {
        public static int GroupId = 1;
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
    }

    public class DroneLogResponse : EntityLogDTO
    {
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
    }

    public class Payload : EntityActivityLog
    {
        public static int GroupId = 2;
    }

    public class PayloadResponse : EntityActivityLogDTO
    {
    }

    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Role { get; set; }
        public string WorkName { get; set; }
    }

    public class UserLogResponse : EntityLogDTO
    {
        public string Role { get; set; }
        public string WorkName { get; set; }
    }

    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
    }

    public class ImageLogResponse : EntityActivityLogDTO
    {
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
    }

    public class VideoLogResponse : EntityActivityLogDTO
    {
    }

    public class IncidentLog : EntityActivityLog
    {
        public static int GroupId = 5;
    }

    public class IncidentLogResponse : EntityActivityLogDTO
    {
    }

    public class ObjectObserve : EntityActivityLog
    {
        public static int GroupId = 6;
    }

    public class ObjectObserveResponse : EntityActivityLogDTO
    {
    }

    public class StaticalLog : EntityActivityLog
    {
        public static int GroupId = 7;
    }

    public class StaticalLogResponse : EntityActivityLogDTO
    {
    }

    public class WarningLog : EntityActivityLog
    {
        public static int GroupId = 8;
    }

    public class WarningLogResponse : EntityActivityLogDTO
    {
    }

    public class MonitorRegionLog : EntityActivityLog
    {
        public static int GroupId = 10;
    }

    public class MonitorRegionLogResponse : EntityActivityLogDTO
    {
    }

    public class ResolveProblemLog : EntityActivityLog
    {
        public static int GroupId = 11;
    }

    public class ResolveProblemLogResponse : EntityActivityLogDTO
    {
    }

    public class UavConnectLog : EntityActivityLog
    {
        public static int GroupId = 12;
    }

    public class UavConnectLogResponse : EntityActivityLogDTO
    {
    }

    public enum ApiType
    {
        Empty = -1,
        Get = 1,
        [Description("Add")] Add = 2,
        [Description("Delete")] Delete = 3,
        [Description("Edit")] Edit = 4,
        [Description("Has Problem")] HasProblem = 5,
        [Description("Change Schedule")] ChangeSchedule = 6,
        [Description("Register")] Register = 7,
        [Description("Work")] Work = 8,
        [Description("Role")] Role = 9,
        [Description("Result")] Result = 10,
        Confirm = 11,
        [Description("Change State")] ChangeState = 12,
        [Description("Export Report")] ExportReport = 13,
        [Description("Frequence Incident")] FrequenceIncident = 14,
        [Description("Common Incident")] CommonIncident = 15,
        [Description("Warning Level")] WarningLevel = 16,
        [Description("Solution Handling")] SolutionHandling = 17,

        [Description("Result Resolve Problem")]
        ResultResolveProblem = 18,

        [Description("Update Status Resolve Problem")]
        UpdateStatusResolveProblem = 19,
        [Description("Devide Monitor Region")] ActivityLog = 20
    }
}