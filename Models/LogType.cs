using System.ComponentModel;

namespace aspnetcoreapp.Models
{
    public enum LogType
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
        [Description("Activity Log")] ActivityLog = 20,
    }
}