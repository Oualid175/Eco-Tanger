using Microsoft.CodeAnalysis;

namespace Eco_Tanger.Models
{
    public class Resource
    {
        public City City { get; set; }
        public List<Location> Locations { get; set; }
        public List<AirPollution> AirPollution { get; set; }
        public List<WaterWaste> WaterWaste { get; set; }
        public List<ForestPollution> ForestPollution { get; set; }
    }
}
