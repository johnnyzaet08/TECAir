using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("flight_cost")]
    public class Flight_cost
    {
        [AutoIncrement,PrimaryKey]
        public int id { get; set; }
        public int enconomy_price { get; set; }
        public int business_price { get; set; }

    }
}
