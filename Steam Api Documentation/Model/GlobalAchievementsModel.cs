using Newtonsoft.Json;

namespace Steam_Api_Documentation.Model
{
    public class GlobalAchievementsModel
    {
        [JsonProperty("achievementpercentages")]
        public Achievements achievementpercentages { get; set; }
    }
    public class Achievements
    {
        [JsonProperty("achievements")]
        public List<AchivementItem> achievements { get; set; }
    }
    public class AchivementItem
    {
        [JsonProperty("name")]
        public string name { get; set; }
        public double percent { get; set; }
    }
}
