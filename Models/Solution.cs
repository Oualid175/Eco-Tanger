namespace Eco_Tanger.Models
{
    public class Solution
    {
        public int solution_id { get; set; }
        public int location_id { get; set; }
        public string problem_type { get; set; }
        public string action_taken { get; set; }
        public DateTime timestamp { get; set; }
    }
}
