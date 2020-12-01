namespace aspnetcoreapp.Models
{
    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public string Name { get; set; }
    }

    public class ImageLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public string Name { get; set; }
    }

    public class VideoLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}