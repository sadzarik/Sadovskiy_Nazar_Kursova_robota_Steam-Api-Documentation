using Steam_Api_Documentation.Model;
using Steam_Api_Documentation.Constant;
using Newtonsoft.Json;

namespace Steam_Api_Documentation.Client
{
    public class AppDetailClient
    {
        private HttpClient _client;
        private static string _apiKey;
        private static string _address;
        private string _apiHost;
        public AppDetailClient()
        {
            _client = new HttpClient();
            _apiKey = Constants.apiKey;
            _address = Constants.address;
            _apiHost = Constants.apiHost;
        }
        public async Task<AppDetailModel> GetAppDetailsAsync(int AppId)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_address}/appDetail/{AppId}"),
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
                    var result = JsonConvert.DeserializeObject<AppDetailModel>(body);
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
