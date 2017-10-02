using Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Data
{
    public class DepoDataBaseGeneric
    {
        static object locker = new object();

        SQLiteConnection database;

        public DepoDataBaseGeneric()
        {
            database = DependencyService.Get<IDatabase>().DBConnect;

            database.CreateTable<Item>();
            database.CreateTable<VoteItem>();
            database.CreateTable<LoginData>();
        }

        public IEnumerable<T> GetObjects<T>() where T : IObject, new()
        {
            lock (locker)
            {
                return (from i in database.Table<T>() select i).ToList();
            }
        }

        public IEnumerable<T> GetFirstObjects<T>() where T : IObject, new()
        {
            lock (locker)
            {
                return database.Query<T>("SELECT * FROM Item WHERE Name = 'First'");
            }
        }

        public T GetObject<T>(int id) where T : IObject, new()
        {
            lock (locker)
            {
                return database.Table<T>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveObject<T>(T obj) where T : IObject
        {
            lock (locker)
            {
                if (obj.ID != 0)
                {
                    database.Update(obj);
                    return obj.ID;
                }
                else
                {
                    return database.Insert(obj);
                }
            }
        }

        public int DeleteObject<T>(int id) where T : IObject, new()
        {
            lock (locker)
            {
                return database.Delete<T>(id);
            }
        }

        public void DeleteAllObjects<T>()
        {
            lock (locker)
            {
                database.DropTable<T>();
                database.CreateTable<T>();
            }
        }

    }
}
