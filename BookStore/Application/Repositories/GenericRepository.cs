using BookStore.Infrastructure.Interfaces;
using System.Data.SqlClient;
using Dapper;

namespace BookStore.Application.Repositories
{
    public class GenericRepository(IConfiguration configuration) : IGenericRepository
    {
        //public GenericRepository(IConfiguration configuration)
        //{
        //    _connectionString = configuration.GetConnectionString("Default") ?? throw new NullReferenceException();
        //}

        public readonly string _connectionString = configuration.GetConnectionString("Default") ?? throw new NullReferenceException();

        public async Task<T?> Get<T>(string sql, object parameter) where T : class
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryFirstOrDefaultAsync<T?>(sql, parameter);
        }

        public async Task<IEnumerable<T>> GetList<T>(string sql, object parameter) where T : class
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<T>(sql, parameter);
        }

        public async Task<bool> Execute(string sql, object parameter)
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.ExecuteAsync(sql, parameter) > 0;
        }
    }
}
