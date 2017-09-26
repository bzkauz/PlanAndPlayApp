using System;
using SQLite;

namespace Data
{
    public interface IDatabase
    {
       
        SQLiteConnection DBConnect();
    }
}
