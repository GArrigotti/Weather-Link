using WeatherLink.Facade;
using WeatherLink.Model;

namespace WeatherLink
{
    public class WeatherLinkService
    {
        private readonly ApiFacade api;

        private readonly string key;
        private readonly string secret;
        private readonly DateTime expiration;

        #region Constructor:

        public WeatherLinkService(string key, string secret, DateTime expiration)
        {
            this.key = key;
            this.secret = secret;
            this.expiration = expiration;

            api = new ApiFacade(new HttpClient());
        }

        #endregion

        public async Task<IEnumerable<StationModel>> GetStations()
        {
            var token = api.GenerateToken(secret, $"api-key{key}t{(long)expiration.Subtract(DateTime.UnixEpoch).TotalSeconds}", expiration);
            return await api.GetAsync<StationModel>($@"https://api.weatherlink.com/v2/stations?api-key={key}&api-signature={token.signature}");
        }

        public async Task<IEnumerable<SensorsModel>> GetCurrentConditions(string station)
        {
            var token = api.GenerateToken(secret, $"api-key{key}station-id{station}t{(long)expiration.Subtract(DateTime.UnixEpoch).TotalSeconds}", expiration);
            return await api.GetAsync<SensorsModel>($@"https://api.weatherlink.com/v2/current/{station}?api-key={key}&api-signature={token.signature}");
        }

        public async Task<IEnumerable<SensorsModel>> GetHistoricConditions(string station, long start, long end)
        {
            var token = api.GenerateToken(secret, $"api-key{key}station-id{station}t{(long)expiration.Subtract(DateTime.UnixEpoch).TotalSeconds}", expiration);
            return await api.GetAsync<SensorsModel>($@"https://api.weatherlink.com/v2/historic/{station}?api-key={key}&api-signature={token.signature}&t={(long)expiration.Subtract(DateTime.UnixEpoch).TotalSeconds}&start-timestamp={start}&end-timestamp={end}");

        }
    }
}