using SQLite;
using System;
using System.IO;


using Xamarin.Forms;


[assembly: Dependency(typeof(PlanAndPlayApp.Droid.Database_Android))]
namespace PlanAndPlayApp.Droid
{
    public class Database_Android : Data.IDatabase
    {
        public Database_Android() { }
        public  SQLiteConnection DBConnect()
        {
            var filename = "ItemsSQLite.db3";
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, filename);
            var connection = new SQLiteConnection(path);
            return connection;
        }
    }

}