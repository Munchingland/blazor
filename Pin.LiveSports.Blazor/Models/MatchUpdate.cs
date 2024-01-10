namespace Pin.LiveSports.Blazor.Models
{
    public class MatchUpdate
    {
        public string UpdateMessage { get; set; }

        public DateTime Time { get; set; }

        public string FullUpdate 
        { 
            get
            {
                return $"{TimeOnly.FromDateTime(Time)}: {UpdateMessage}";
            }
        }
    }
}
