using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table ("cancellations")]
    public class Cancellations
    {
        [AutoIncrement, PrimaryKey]
        public int cancellation_id { get; set; }
        public DateTime cancellation_date { get; set; }
        public int cancellation_amount { get; set; }
        public int transaction_id { get; set; }
    }
}
