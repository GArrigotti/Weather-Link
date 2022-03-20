using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using WeatherLink.Record;

namespace WeatherLink.Facade
{
    public class ApiFacade
    {
        private bool disposed = false;
        private readonly HttpClient client;

        #region Constructor:

        public ApiFacade(HttpClient client) => this.client = client;

        #endregion

        public TokenRecord GenerateToken(string secret, string data, DateTime expiration)
        {
            using var hash = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
            return new TokenRecord(BitConverter.ToString(hash.ComputeHash(Encoding.UTF8.GetBytes(data))).Replace("-", ""), expiration);
        }

        public async Task<TEntity> GetAsync<TEntity>(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TEntity>(content);
            }

            catch (Exception exception)
            {
                Console.WriteLine("Failed to retrieve data from WeatherLink");
                throw new Exception(exception.Message);
            }
        }
    }
}
