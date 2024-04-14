namespace Eco_Tanger.Models
{
    public class ForestPollution
    {
        public int forestpollution_id { get; set; }
        public int location_id { get; set; }
        public string pollutant { get; set; } = "";
        public string severity { get; set; } = "";
        public DateTime timestamp { get; set; }
    }
}
