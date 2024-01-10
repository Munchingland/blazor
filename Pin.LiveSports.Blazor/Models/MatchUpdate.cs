using System.ComponentModel.DataAnnotations;

namespace Pin.LiveSports.Blazor.Models
{
    public class MatchUpdate
    {
        [Required(ErrorMessage ="gelieve een update te geven")]
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
