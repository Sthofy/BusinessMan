using SQLite;
using BusinessMan.Models;

namespace BusinessMan.Data
{
    public class SqlDatabase
    {
        SQLiteAsyncConnection _connection;
        public SqlDatabase() { }

        async Task Init()
        {
            if (_connection is not null)
                return;

            _connection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            await _connection.CreateTableAsync<User>();
        }

        public async Task<User> GetUserAsync()
        {
            await Init();
            return await _connection.Table<User>().FirstOrDefaultAsync();
        }

        public async Task<int> SavetUserAsync(User user)
        {
            await Init();

            if (user.Id != 0)
            {
                return await _connection.UpdateAsync(user);
            }

            return await _connection.InsertAsync(user);
        }

        public async Task<int> RemoveUserAsync(User user)
        {
            await Init();
            return await _connection.DeleteAsync(user);
        }
    }
}
