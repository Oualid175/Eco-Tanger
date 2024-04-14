namespace Eco_Tanger.Models
{
    public class WaterWaste
    {
        public int waterwaste_id { get; set; }
        public int location_id { get; set; }
        public string waste_type { get; set; } = "";
        public string waste_volume { get; set; } = "";
        public DateTime timestamp { get; set; }
    }
}
