using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using Xamarin.Forms;


namespace Marathon
{
    public class UsersClassAsyncRepository
    {
        SQLiteAsyncConnection database;

        public UsersClassAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Marathon>();
        }
        public async Task<List<Marathon>> GetItemsAsync()
        {
            return await database.Table<Marathon>().ToListAsync();

        }
        public async Task<Marathon> GetItemAsync(int id)
        {
            return await database.GetAsync<Marathon>(id);
        }
        public async Task<int> DeleteItemAsync(Marathon item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Marathon item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}