using Microsoft.AspNetCore.Mvc;
using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Client;

namespace Steam_Api_Documentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppNewsController : ControllerBase
    {
        [HttpGet(Name = "Get_Steam_App_News")]
        public AppNewsModel GetAppNews(int AppId)
        {
            AppNewsClient client = new AppNewsClient();
            return client.GetAppNewsAsync(AppId).Result;
        }
    }
}
