using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TShirtLibrary
{
    public class TShirtDatabase
    {
        readonly SQLiteAsyncConnection database;
        public TShirtDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TShirt>().Wait();
        }
        public Task<List<TShirt>> GetItemsAsync()
        {
            return database.Table<TShirt>().ToListAsync();

        }
        public Task<List<TShirt>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TShirt>("SELECT * FROM [TShirt]");
        }
        public Task<TShirt> GetItemAsync(int id)
        {
            return database.Table<TShirt>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int>SaveItemAsync(TShirt item)
        {
            if(item.ID !=0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
           
        }

        
    }
}
