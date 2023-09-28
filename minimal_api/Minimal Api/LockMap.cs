using Microsoft.AspNetCore.Mvc;
using minimal_api.Services;

//install entity frameworks - dapper

namespace minimal_api.Minimal_Api
{
    public static class LockMap
    {
        public static void Get(this WebApplication app) 
        {
            app.MapGet("/Api/Lock/GetEntity", async ([FromServices] LockService lock_service) => 
            {
                var res = await lock_service.GetEntity();
                
                return Results.Ok(res);

            }).WithName("GetEntity");


            app.MapGet("/Api/Lock/GetDapper", async ([FromServices] LockService lock_service) =>
            {
                var res = await lock_service.GetDapper();

                return Results.Ok(res);

            }).WithName("GetDapper");
        }
    }
}
