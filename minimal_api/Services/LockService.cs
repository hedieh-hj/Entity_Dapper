using Microsoft.EntityFrameworkCore;
using minimal_api.DataBase;
using minimal_api.Model;
using System.Diagnostics.Contracts;
using Dapper;

namespace minimal_api.Services
{
    public class LockService
    {
        private readonly MyDbContext _context;

        private readonly LockDbContext _lockDbContext;

        public LockService(MyDbContext context,
            LockDbContext lockDbContext)
        {
            _context = context;
            _lockDbContext = lockDbContext; 
        }

        public async Task<IEnumerable<Lock>?> GetEntity()
        {
            try
            {
                var res = await _context.Lock.ToListAsync();

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Lock>?> GetDapper()
        {
            try
            {
                var query = "SELECT * FROM LOCK";

                var res = await _lockDbContext.Connection.QueryAsync<Lock>(query);

                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
