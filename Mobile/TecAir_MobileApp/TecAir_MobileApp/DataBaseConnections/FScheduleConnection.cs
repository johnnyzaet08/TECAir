using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TecAir_MobileApp.DataBaseModels;

namespace TecAir_MobileApp.DataBaseConnections
{
    internal class FScheduleConnection
    {


        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.sqliteTEC.db");

        public FScheduleConnection()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Flight_schedule>();
        }

        public List<Flight_schedule> List()
        {
            return _database.Table<Flight_schedule>().ToList();
        }
    }
}
