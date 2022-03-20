using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink.Api_Model
{
    public class GetHistoricConditionModel
    {
            public int station_id { get; set; }

            public Sensor[] sensors { get; set; }

            public int generated_at { get; set; }
        

        public class Sensor
        {
            public int lsid { get; set; }

            public int sensor_type { get; set; }

            public int data_structure_type { get; set; }

            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public long ts { get; set; }

            public float dew_point_in { get; set; }

            public float heat_index_in { get; set; }

            public float temp_in { get; set; }

            public int temp_in_lo_at { get; set; }

            public int arch_int { get; set; }

            public float temp_in_hi { get; set; }

            public int temp_in_hi_at { get; set; }

            public float hum_in_hi { get; set; }

            public float temp_in_last { get; set; }

            public float temp_in_lo { get; set; }

            public float hum_in_lo { get; set; }

            public float hum_in_last { get; set; }

            public int hum_in_lo_at { get; set; }

            public int hum_in_hi_at { get; set; }
        }

    }
}
