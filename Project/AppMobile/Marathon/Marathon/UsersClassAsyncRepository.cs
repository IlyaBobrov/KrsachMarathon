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
            await database.CreateTableAsync<User>();
        }
        public async Task<List<User>> GetItemsAsync()
        {
            return await database.Table<User>().ToListAsync();

        }
        public async Task<User> GetItemAsync(int id)
        {
            return await database.GetAsync<User>(id);
        }
        public async Task<int> DeleteItemAsync(User item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(User item)
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