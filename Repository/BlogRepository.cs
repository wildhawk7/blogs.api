using blogs.api.Models;
using Dapper;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;

namespace blogs.api.Repository
{
    public class BlogRepository
    {
        private readonly string _connectionString;

        public BlogRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Blogs>> GetBlogsAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            var sql = "SELECT * FROM Blogs";
            return await connection.QueryAsync<Blogs>(sql);
        }
    }
}
