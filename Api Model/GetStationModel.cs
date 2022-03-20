using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink.Api_Model
{
    public class GetStationModel
    {
            public Station[] stations { get; set; }

            public int generated_at { get; set; }
    }

    public class Station
    {
        public int station_id { get; set; }

        public string station_name { get; set; }

        public int gateway_id { get; set; }

        public string gateway_id_hex { get; set; }

        public string product_number { get; set; }

        public string username { get; set; }

        public string user_email { get; set; }

        public string company_name { get; set; }

        public bool active { get; set; }

        public bool _private { get; set; }

        public int uploadInterval { get; set; }

        public string firmware_version { get; set; }

        public string imei { get; set; }

        public string meid { get; set; }

        public int registered_date { get; set; }

        public int subscription_end_date { get; set; }

        public string time_zone { get; set; }

        public string city { get; set; }

        public string region { get; set; }

        public string country { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        public string elevation { get; set; }
    }

}
