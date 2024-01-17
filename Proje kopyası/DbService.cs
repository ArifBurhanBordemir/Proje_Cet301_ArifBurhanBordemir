using System;
using SQLite;

namespace Proje
{ 
    public class DbService
    {
        private const string DB_NAME = "local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public DbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Events>();
        }

        public async Task<List<Events>> GetEvents()
        {
            return await _connection.Table<Events>().ToListAsync();
        }

        public async Task Create(Events events)
        {
             await _connection.InsertAsync(events);
        }

        public async Task Update(Events events)
        {
             await _connection.UpdateAsync(events);
        }

        public async Task Delete(Events events)
        {
             await _connection.DeleteAsync(events);
        }
    }
}
