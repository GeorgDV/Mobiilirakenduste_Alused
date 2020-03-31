using InstagramApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            _dbContext.CreateTableAsync<Post>().Wait();
            _dbContext.CreateTableAsync<User>().Wait();
        }


        //POSTS TABLE METHODS
        public async Task<List<Post>> GetPostsAsync()
        {
            return await _dbContext.Table<Post>().ToListAsync();
        }

        public async Task<Post> GetPostAsync(int id)
        {
            return await _dbContext.Table<Post>()
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync();
        }

        public async Task<int> SavePostAsync(Post Post)
        {
            if (Post.Id != 0)
            {
                return await _dbContext.UpdateAsync(Post);
            }
            else
            {
                return await _dbContext.InsertAsync(Post);
            }
        }

        public async Task<int> DeletePostAsync(Post Post)
        {
            return await _dbContext.DeleteAsync(Post);
        }



        //USERS TABLE METHODS
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
