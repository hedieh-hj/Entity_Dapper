using Microsoft.Data.SqlClient;
using System.Data;

namespace minimal_api.DataBase
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
