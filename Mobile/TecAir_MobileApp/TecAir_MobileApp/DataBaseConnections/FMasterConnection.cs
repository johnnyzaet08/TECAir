using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TecAir_MobileApp.DataBaseModels;

namespace TecAir_MobileApp.DataBaseConnections
{
    internal class FMasterConnection
    {

        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.sqliteTEC.db");

        public FMasterConnection()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Flight_master>();
        }

        public List<Flight_master> List()
        {
            return _database.Table<Flight_master>().ToList();
        }
    }
}
