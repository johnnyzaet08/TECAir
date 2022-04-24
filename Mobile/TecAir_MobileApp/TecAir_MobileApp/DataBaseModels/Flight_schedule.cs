using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("flight_schedule")]
    public class Flight_schedule
    {
        [AutoIncrement, PrimaryKey]
        public int id { get; set; }
        public int flight_number { get; set; }
        public string weekday { get; set; }
    }
}
