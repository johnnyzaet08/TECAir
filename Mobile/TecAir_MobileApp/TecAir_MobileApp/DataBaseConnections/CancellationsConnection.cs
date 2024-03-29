﻿using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TecAir_MobileApp.DataBaseModels;

namespace TecAir_MobileApp.DataBaseConnections
{
    internal class CancellationsConnection
    {

    
    private readonly SQLiteConnection _database;

    public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.sqliteTEC.db");

    public CancellationsConnection()
    {
        _database = new SQLiteConnection(DbPath);
        _database.CreateTable<Cancellations>();
    }

    public List<Cancellations> List()
    {
        return _database.Table<Cancellations>().ToList();
    }
}
}
