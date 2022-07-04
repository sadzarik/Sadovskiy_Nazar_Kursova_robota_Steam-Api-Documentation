using Microsoft.AspNetCore.Mvc;
using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Client;

namespace Steam_Api_Documentation.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AppReviewController : ControllerBase
    {
        [HttpGet(Name = "AppReviews")]
        public AppReviewsModel GetAppReviews(int AppId, int CountOfReviews)
        {
            AppReviewsClient client = new AppReviewsClient();
            return client.GetAppReviewsAsync(AppId, CountOfReviews).Result;
        }
    }
}
