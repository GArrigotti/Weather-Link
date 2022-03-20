using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLink.Api_Model
{
    public class GetCurrentConditionModel
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
            public int ts { get; set; }
            public int? bar_trend { get; set; }
            public float? bar { get; set; }
            public float? temp_in { get; set; }
            public int? hum_in { get; set; }
            public float? temp_out { get; set; }
            public int? wind_speed { get; set; }
            public int? wind_speed_10_min_avg { get; set; }
            public int? wind_dir { get; set; }
            public string? temp_extra_1 { get; set; }
            public object? temp_extra_2 { get; set; }
            public object? temp_extra_3 { get; set; }
            public object? temp_extra_4 { get; set; }
            public object? temp_extra_5 { get; set; }
            public object? temp_extra_6 { get; set; }
            public object? temp_extra_7 { get; set; }
            public object? temp_soil_1 { get; set; }
            public object? temp_soil_2 { get; set; }
            public object? temp_soil_3 { get; set; }
            public object? temp_soil_4 { get; set; }
            public object? temp_leaf_1 { get; set; }
            public object? temp_leaf_2 { get; set; }
            public object? temp_leaf_3 { get; set; }
            public object? temp_leaf_4 { get; set; }
            public int? hum_out { get; set; }
            public object? hum_extra_1 { get; set; }
            public object? hum_extra_2 { get; set; }
            public object? hum_extra_3 { get; set; }
            public object? hum_extra_4 { get; set; }
            public object? hum_extra_5 { get; set; }
            public object? hum_extra_6 { get; set; }
            public object? hum_extra_7 { get; set; }
            public int? rain_rate_clicks { get; set; }
            public int? rain_rate_in { get; set; }
            public int? rain_rate_mm { get; set; }
            public object? uv { get; set; }
            public int? solar_rad { get; set; }
            public int? rain_storm_clicks { get; set; }
            public float? rain_storm_in { get; set; }
            public float? rain_storm_mm { get; set; }
            public int? rain_storm_start_date { get; set; }
            public int? rain_day_clicks { get; set; }
            public float? rain_day_in { get; set; }
            public float? rain_day_mm { get; set; }
            public int? rain_month_clicks { get; set; }
            public float? rain_month_in { get; set; }
            public float? rain_month_mm { get; set; }
            public int? rain_year_clicks { get; set; }
            public float? rain_year_in { get; set; }
            public float? rain_year_mm { get; set; }
            public float? et_day { get; set; }
            public float? et_month { get; set; }
            public float? et_year { get; set; }
            public object? moist_soil_1 { get; set; }
            public object? moist_soil_2 { get; set; }
            public object? moist_soil_3 { get; set; }
            public object? moist_soil_4 { get; set; }
            public object? wet_leaf_1 { get; set; }
            public object? wet_leaf_2 { get; set; }
            public object? wet_leaf_3 { get; set; }
            public int? wet_leaf_4 { get; set; }
            public int? forecast_rule { get; set; }
            public string forecast_desc { get; set; }
            public int? dew_point { get; set; }
            public int? heat_index { get; set; }
            public int? wind_chill { get; set; }
            public int? wind_gust_10_min { get; set; }
        }

    }
}
