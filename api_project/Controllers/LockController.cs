using api_project.Services;
using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//install entity frameworks - dapper

namespace api_project.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    public class LockController : ControllerBase
    {
        private readonly LockService lock_Service;

        public LockController(LockService lockService)
        {
            lock_Service = lockService;
        }
        
        [Route("GetEntity")]
        [HttpGet]
        public async Task<IActionResult> GetEntity()
        {
            try
            {
                var res = await lock_Service.Get();

                return Ok(res);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("GetDapper")]
        public async Task<IActionResult> GetDapper()
        {
            try
            {
                var res = await lock_Service.GetDapper();

                return Ok(res);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
