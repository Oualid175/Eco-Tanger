namespace Eco_Tanger.Models
{
    public class AirPollution
    {
        public int airpollution_id { get; set; }
        public int location_id { get; set; }
        public string pollutant { get; set; } = "";
        public string pollutant_level { get; set; } = "";
        public DateTime timestamp { get; set; }
    }
}
