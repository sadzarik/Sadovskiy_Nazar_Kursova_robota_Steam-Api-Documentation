using Steam_Api_Documentation.Client;
using Steam_Api_Documentation.Constant;
using Steam_Api_Documentation.Model;
using Newtonsoft.Json;

namespace Steam_Api_Documentation.Client
{
    public class GlobalAchievementClient
    {
        private HttpClient _client;
        private static string _apiKey;
        private static string _address;
        private string _apiHost;
        public GlobalAchievementClient()
        {
            _client = new HttpClient();
            _apiKey = Constants.apiKey;
            _address = Constants.address;
            _apiHost = Constants.apiHost;
        }
        public async Task<GlobalAchievementsModel> GetGlobalAchievementsAsync(int AppId)
        {
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"{_address}/globalAchievementPercentagesForApp/{AppId}"),
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
                    var result = JsonConvert.DeserializeObject<GlobalAchievementsModel>(body);
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
