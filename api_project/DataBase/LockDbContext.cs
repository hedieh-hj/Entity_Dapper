using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace api_project.DataBase
{
    public class LockDbContext
    {
        public IDbConnection Connection { get; }

        public LockDbContext(string _connection)
        {
            Connection = new SqlConnection(_connection);
        }
    }
}
