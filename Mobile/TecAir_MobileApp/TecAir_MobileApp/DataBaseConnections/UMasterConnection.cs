using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TecAir_MobileApp.DataBaseModels;

namespace TecAir_MobileApp.DataBaseConnections
{
    internal class UMasterConnection
    {
        private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.sqliteTEC.db");

        public UMasterConnection()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<User_Master>();
        }

        public List<User_Master> List()
        {
            return _database.Table<User_Master>().ToList();
        }
    }
}
