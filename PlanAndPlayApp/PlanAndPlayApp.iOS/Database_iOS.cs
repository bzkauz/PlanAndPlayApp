using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using PlanAndPlayApp.iOS;
using Data;

[assembly: Dependency(typeof(Database_iOS))]
namespace PlanAndPlayApp.iOS
{
    public class Database_iOS : IDatabase
    {
        public Database_iOS() { }


        public SQLiteConnection DBConnect
        {
            get
            {
                var filename = "ItemsSQLite.db3";
                string folder =
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string libraryFolder = Path.Combine(folder, "..", "Library");
                var path = Path.Combine(libraryFolder, filename);
                var connection = new SQLiteConnection(path);
                return connection;
            }
        }

        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}



