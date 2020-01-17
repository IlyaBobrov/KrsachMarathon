using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace Marathon
{
    public class MarathonClassAsyncRepository
    {
        SQLiteAsyncConnection databaseM;
        public MarathonClassAsyncRepository(string databasePath)
        {
            databaseM = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await databaseM.CreateTableAsync<Marathon>();
        }
        public async Task<List<Marathon>> GetItemsAsync()
        {
            return await databaseM.Table<Marathon>().ToListAsync();

        }
        public async Task<Marathon> GetItemAsync(int id)
        {
            return await databaseM.GetAsync<Marathon>(id);
        }
        public async Task<int> DeleteItemAsync(Marathon item)
        {
            return await databaseM.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Marathon item)
        {
            if (item.Id != 0)
            {
                await databaseM.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await databaseM.InsertAsync(item);
            }
        }
    }
}
