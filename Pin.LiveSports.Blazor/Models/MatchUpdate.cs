namespace Pin.LiveSports.Blazor.Models
{
    public class MatchUpdate
    {
        public string UpdateMessage { get; set; }

        public TimeOnly Time { get; set; }

        public string Update 
        { 
            get
            {
                return $"{Time}: {UpdateMessage}";
            }
        }
    }
}
