namespace aspnetcoreapp.Models
{
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
}