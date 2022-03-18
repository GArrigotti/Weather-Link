namespace WeatherLink.Model
{
    internal class CurrentConditions
    {
        public int Station_Id { get; set; }

        public IEnumerable<SensorsModel> Sensors { get; set; }

        public int Generated_At { get; set; }
    }
}
