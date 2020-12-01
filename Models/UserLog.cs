namespace aspnetcoreapp.Models
{
    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Metadata { get; set; }
        public int TargetId { get; set; }
    }

    public struct UserLogRequest
    {
        public int user_id;
        public int target_id;
        public string description;
        public string meta_data;
    }

    public class UserLogResponse : EntityLogDTO
    {
        public string Role { get; set; }
        public string WorkName { get; set; }
    }
}