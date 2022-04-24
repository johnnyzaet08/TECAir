using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("credit_card")]
    public class Credit_card
    {
        [AutoIncrement, PrimaryKey]
        public int id { get; set; }
        public  int cardnumber { get; set; }
        public int expmonth { get; set; }
        public int expyear { get; set; }
        public int userid { get; set; }
    }
}
