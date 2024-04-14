namespace Eco_Tanger.Models
{
    public class Location
    {
        public int location_id { get; set; }
        public int city_id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string address { get; set; } = "";
    }
}
