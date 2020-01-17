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
            await databaseM.CreateTableAsync<MarathonClass>();
        }
        public async Task<List<MarathonClass>> GetItemsAsync()
        {
            return await databaseM.Table<MarathonClass>().ToListAsync();

        }
        public async Task<MarathonClass> GetItemAsync(int id)
        {
            return await databaseM.GetAsync<MarathonClass>(id);
        }
        public async Task<int> DeleteItemAsync(MarathonClass item)
        {
            return await databaseM.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(MarathonClass item)
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
