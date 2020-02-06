using LoginFormApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrossPlatformApp.Data
{
    public class ApplicationDatabase
    {
        SQLiteAsyncConnection _dbContext;

        public ApplicationDatabase(string dbPath)
        {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<User>().Wait();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _dbContext.Table<User>()
                           .Where(x => x.UserId == id)
                           .FirstOrDefaultAsync();
        }

        public async Task<int> SaveUserAsync(User User)
        {
            if (User.UserId != 0)
            {
                return await _dbContext.UpdateAsync(User);
            }
            else
            {
                return await _dbContext.InsertAsync(User);
            }
        }

        public async Task<int> DeleteUserAsync(User User)
        {
            return await _dbContext.DeleteAsync(User);
        }

    }
}
