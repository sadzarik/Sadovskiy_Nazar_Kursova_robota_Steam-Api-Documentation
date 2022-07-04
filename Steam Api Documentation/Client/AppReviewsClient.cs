using Steam_Api_Documentation.Constant;
using Steam_Api_Documentation.Model;
using Newtonsoft.Json;

namespace Steam_Api_Documentation.Client
{
    public class AppReviewsClient
    {
        private HttpClient _client;
        private static string _apiKey;
        private static string _address;
        private string _apiHost;
        public AppReviewsClient()
        {
            _client = new HttpClient();
            _apiKey = Constants.apiKey;
            _address = Constants.address;
            _apiHost = Constants.apiHost;
        }
        public async Task<AppReviewsModel> GetAppReviewsAsync(int AppId, int CountOfReviews)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_address}/appReviews/{AppId}/limit/{CountOfReviews}/*"),
                    Headers =
                {
                    { "X-RapidAPI-Key", $"{_apiKey}" },
                    { "X-RapidAPI-Host", $"{_apiHost}" },
                },
                };
                using (var response = await _client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<AppReviewsModel>(body);
                    return result;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong AppId");
                return null;
            }

        }
    }
}
