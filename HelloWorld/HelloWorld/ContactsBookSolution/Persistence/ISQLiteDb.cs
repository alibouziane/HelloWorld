using SQLite;

namespace HelloWorld.ContactsBookSolution.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

