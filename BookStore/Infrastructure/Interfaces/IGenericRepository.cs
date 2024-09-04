

namespace BookStore.Infrastructure.Interfaces
{
    public interface IGenericRepository
    {
        Task<bool> Execute(string sql, object parameter);
        Task<T?> Get<T>(string sql, object parameter) where T : class;
        Task<IEnumerable<T>> GetList<T>(string sql, object parameter) where T : class;
    }
}
