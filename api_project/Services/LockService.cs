using api_project.DataBase;
using api_project.Model;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace api_project.Services
{
    public class LockService
    {
        private readonly MyDbContext _context;
        private readonly LockDbContext _lockDbContext;
        public LockService(MyDbContext context,
            LockDbContext lockDbContext)
        {
            _lockDbContext = lockDbContext;
            _context = context;
        }

        public async Task<IEnumerable<Lock>?> Get() 
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
