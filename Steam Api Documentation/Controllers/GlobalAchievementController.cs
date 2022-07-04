using Microsoft.AspNetCore.Mvc;
using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Client;

namespace Steam_Api_Documentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GlobalAchievementController : ControllerBase
    {
        [HttpGet(Name = "Get_Global_Acievement")]
        public GlobalAchievementsModel GetGlobalAchievements(int AppId)
        {
            GlobalAchievementClient client = new GlobalAchievementClient();
            return client.GetGlobalAchievementsAsync(AppId).Result;
        }
    }
}
