namespace aspnetcoreapp.Models
{
    public class ResolveProblemLog : EntityActivityLog
    {
        public static int GroupId = 11;
        public string Name { get; set; }
    }

    public class ResolveProblemLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}