
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
//using SQLite;
using PlanAndPlayApp.UWP;
using Data;
using SQLite;

[assembly: Dependency(typeof(Database_WinPhone))]

namespace PlanAndPlayApp.UWP
{
    public class Database_WinPhone : IDatabase
    {
        public Database_WinPhone() { }
        public SQLiteConnection DBConnect
        {
            get
            {
                var filename = "ItemsSQLite.db3";
                string folder =
                    ApplicationData.Current.LocalFolder.Path;
                var path = Path.Combine(folder, filename);
                var connection = new SQLiteConnection(path);
                return connection;
            }
        }

        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }


    }
}
