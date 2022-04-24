using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TecAir_MobileApp.DataBaseModels
{
    [Table ("admins")]
    public class Admins
    {
        [AutoIncrement, PrimaryKey]
        public string username { get; set; }
        public string password { get; set; }
    }
}
