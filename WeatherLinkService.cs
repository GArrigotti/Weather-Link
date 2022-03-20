using WeatherLink.Api_Model;
using WeatherLink.Facade;

namespace WeatherLink
{
    public class WeatherLinkService
    {
        private readonly ApiFacade api;

        private readonly string key;
        private readonly string secret;
        private readonly DateTime expiration;
        private readonly long timestamp;
        #region Constructor:

        public WeatherLinkService(string key, string secret, DateTime expiration)
        {
            this.key = key;
            this.secret = secret;
            this.expiration = expiration;

            api = new ApiFacade(new HttpClient());
            timestamp = (long)expiration.Subtract(DateTime.UnixEpoch).TotalSeconds;
        }

        #endregion

        public async Task<GetStationModel> GetStations()
        {
            var token = api.GenerateToken(secret, $"api-key{key}t{timestamp}", expiration);
            return await api.GetAsync<GetStationModel>($@"https://api.weatherlink.com/v2/stations?api-key={key}&api-signature={token.signature}&t={timestamp}");
        }

        public async Task<GetCurrentConditionModel> GetCurrentConditions(string station)
        {
            var token = api.GenerateToken(secret, $"api-key{key}station-id{station}t{timestamp}", expiration);
            return await api.GetAsync<GetCurrentConditionModel>($@"https://api.weatherlink.com/v2/current/{station}?api-key={key}&api-signature={token.signature}&t={timestamp}");
        }

        public async Task<GetHistoricConditionModel> GetHistoricConditions(string station, DateTime start, DateTime end)
        {
            var startUnix = (long)start.Subtract(DateTime.UnixEpoch).TotalSeconds;
            var endUnix = (long)end.Subtract(DateTime.UnixEpoch).TotalSeconds;

            var token = api.GenerateToken(secret, $"api-key{key}end-timestamp{endUnix}start-timestamp{startUnix}station-id{station}t{timestamp}", expiration);
            return await api.GetAsync<GetHistoricConditionModel>($@"https://api.weatherlink.com/v2/historic/{station}?api-key={key}&t={timestamp}&end-timestamp={endUnix}&start-timestamp={startUnix}&api-signature={token.signature}");

        }
    }
}