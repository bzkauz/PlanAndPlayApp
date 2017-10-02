using SQLite;
using System;
using System.IO;

using SQLite;
using Xamarin.Forms;
using PlanAndPlayApp.Droid;
using Data;

[assembly: Dependency(typeof(Database_Android))]
namespace PlanAndPlayApp.Droid
{
    public class Database_Android : IDatabase
    {
        public Database_Android() { }

        public SQLiteConnection DBConnect
        {
            get
            {
                var filename = "ItemsSQLite.db3";
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                var path = Path.Combine(folder, filename);
                var connection = new SQLiteConnection(path);
                return connection;
            }
        }

        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }

}