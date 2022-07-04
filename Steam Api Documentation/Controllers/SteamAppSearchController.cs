using Microsoft.AspNetCore.Mvc;
using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Client;

namespace Steam_Api_Documentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SteamAppSearchController : ControllerBase
    {
        [HttpGet(Name = "Get_Search_Steam_App")]
        public List<SteamAppInfo> GetSteamApp(string AppName )
        {
            SearchAppClient client = new SearchAppClient();
            return client.GetAppInfoAsync(AppName).Result;
        }
    }
}
