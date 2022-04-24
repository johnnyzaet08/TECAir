using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("Flight_Master")]
    public class Flight_master
    {
        [AutoIncrement, PrimaryKey]
        public int flight_number { get; set; }
        public string departure_location { get; set; }
        public string arrival_location { get; set; }
        public DateTime departure_time { get; set; }
        public DateTime arrival_time { get; set; }
        public DateTime duration { get; set; }
    }
}
