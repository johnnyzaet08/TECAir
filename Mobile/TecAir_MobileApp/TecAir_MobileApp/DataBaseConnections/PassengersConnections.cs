using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TecAir_MobileApp.DataBaseModels;

namespace TecAir_MobileApp.DataBaseConnections
{
    internal class PassengersConnections
    {

        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.sqliteTEC.db");

        public PassengersConnections()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Passengers>();
        }

        public List<Passengers> List()
        {
            return _database.Table<Passengers>().ToList();
        }
    }
}

