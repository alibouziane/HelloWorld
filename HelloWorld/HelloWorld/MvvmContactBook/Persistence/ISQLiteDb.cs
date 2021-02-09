using SQLite;

namespace HelloWorld.MvvmContactBook.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

