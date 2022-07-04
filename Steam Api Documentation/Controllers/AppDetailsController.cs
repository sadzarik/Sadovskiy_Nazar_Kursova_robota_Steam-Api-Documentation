using Microsoft.AspNetCore.Mvc;
using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Client;

namespace Steam_Api_Documentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppDetailsController : ControllerBase
    {
        [HttpGet(Name = "AppDetails")]
        public AppDetailModel GetAppDetails(int AppId)
        {
            AppDetailClient client = new AppDetailClient();
            return client.GetAppDetailsAsync(AppId).Result;
        }
    }
}
