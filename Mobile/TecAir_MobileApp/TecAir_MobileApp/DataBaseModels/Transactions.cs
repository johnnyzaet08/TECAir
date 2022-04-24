using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("Transactions")]
    public class Transactions

    {
        [AutoIncrement, PrimaryKey]
        public int transaction_id { get; set; }
        public int user_id { get; set; }
        public int flight_number { get; set; }
        public DateTime booking_date { get; set; }
        public int number_of_seats { get; set; }
        public DateTime travel_date { get; set; }
        public string seat_type { get; set; }
        public int amount { get; set; }
        public bool cancellation_status { get; set; }

    }
}
