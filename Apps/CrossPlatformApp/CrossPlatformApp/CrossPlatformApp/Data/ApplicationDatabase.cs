using CrossPlatformApp.Models;
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

        public ApplicationDatabase (string dbPath)
        {
            _dbContext = new SQLiteAsyncConnection(dbPath);
            _dbContext.CreateTableAsync<Note>().Wait();
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            return await _dbContext.Table<Note>().ToListAsync();
        }

        public async Task<Note> GetNoteAsync(int id)
        {
            return await _dbContext.Table<Note>()
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync();
        }

        public async Task<int> SaveNoteAsync(Note note)
        {
            if (note.Id != 0)
            {
                return await _dbContext.UpdateAsync(note);
            }
            else
            {
                return await _dbContext.InsertAsync(note);
            }
        }

        public async Task<int> DeleteNoteAsync(Note note)
        {
            return await _dbContext.DeleteAsync(note);
        }

    }
}
