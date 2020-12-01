namespace aspnetcoreapp.Models
{
    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Metadata { get; set; }
        public int UserId { get; set; }
    }

    public struct UserLogRequest
    {
        public int user_id { get; set; }
        public int target_id { get; set; }
        public string description { get; set; }
        public string meta_data { get; set; }
    }

    public class UserLogResponse : TypeAndTimeStamp
    {
        public int TargetId { get; set; }
        public string Metadata { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}