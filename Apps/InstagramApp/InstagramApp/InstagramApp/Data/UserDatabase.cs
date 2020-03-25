using System.Collections.Generic;
using SQLite;
using System.Threading.Tasks;
using InstagramApp.Models;

namespace InstagramApp.Data
{
    public class UserDatabase
    {
        SQLiteAsyncConnection _dbContext;

        public UserDatabase(string dbPath)
        {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<User>().Wait();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _dbContext.Table<User>()
                           .Where(x => x.UserId == id)
                           .FirstOrDefaultAsync();
        }

        public Task<User> GetUserByNameAndPassword(string username, string password)
        {
            return _dbContext.Table<User>()
                           .Where(x => x.UserName.Equals(username) && x.Password.Equals(password))
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
