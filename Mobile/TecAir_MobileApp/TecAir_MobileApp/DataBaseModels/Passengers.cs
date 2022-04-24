using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TecAir_MobileApp.DataBaseModels
{
    [Table("passengers")]
    public class Passengers
    {
        [AutoIncrement,PrimaryKey]
        public int id { get; set; }
        public int transaction_id   { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string contact { get; set; }
        public string seatmo { get; set; }
        public string email { get; set; }
    }
}
