using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table("User_Master")]
    public class User_Master
    {
        [AutoIncrement, PrimaryKey]
        public int userid { get; set; }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime dob { get; set; }
        public string password { get; set; }
        public string email_id { get; set; }
        public string mobile { get; set; }
    }
}
