using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Models;

using Xamarin.Forms;


[assembly: Dependency(typeof(Services.VoteDataStore))]
namespace Services
{
    public class VoteDataStore : IVoteStore<VoteItem>
    {
        bool isInitialized;
        List<VoteItem> voteitems;

      

        public async Task<bool> UpdateItemAsync(VoteItem voteItem)
        {
            await InitializeAsync();

            var _voteItem = voteitems.Where((VoteItem arg) => arg.Id == voteItem.Id).FirstOrDefault();
            voteitems.Remove(_voteItem);
            voteitems.Add(voteItem);

            return await Task.FromResult(true);
        }

       

        public async Task<VoteItem> GetItemAsync(string id)
        {
            await InitializeAsync();

            return await Task.FromResult(voteitems.FirstOrDefault(s => s.Id == id));
        }

       

        public Task<bool> PullLatestAsync()
        {
            return Task.FromResult(true);
        }


        public Task<bool> SyncAsync()
        {
            return Task.FromResult(true);
        }

        public async Task InitializeAsync()
        {
            if (isInitialized)
                return;

            voteitems = new List<VoteItem>();
            var _voteitems = new List<VoteItem>
            {
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Training Do 8.6.2017 10:00 - 12:00", Description="Sportanlage 8704 Herrliberg"},
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Freundschaftsspeil So 11.6.2017 14:00 ", Description="Ballwil Lu"},
                //new Item { Id = Guid.NewGuid().ToString(), Text = "FC Ballwil", Description="Liga C starker Gegner Punkte 17 Rang 2 gegenwärtig"},
            };

            foreach (VoteItem item in voteitems)
            {
                voteitems.Add(item);
            }

            isInitialized = true;
        }

        public Task<IEnumerable<VoteItem>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }
    }
}
