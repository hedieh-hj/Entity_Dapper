using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

//this project is for test benhmarking on controllers - connect to another project
namespace RequestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = BenchmarkRunner.Run<Demo>();
        }
    }

    [MemoryDiagnoser] //how much memroy do you use
    public class Demo
    {
        [Benchmark]
        public async Task<string> Get_ControllerApi_Entity()
        {
            var client = new HttpClient();

            var json = await client.GetStringAsync("https://localhost:7074/api/lock/GetEntity");

            return json;
        }

        [Benchmark]
        public async Task<string> Get_ControllerApi_Dapper()
        {
            var client = new HttpClient();

            var json = await client.GetStringAsync("https://localhost:7074/api/lock/Getdapper");

            return json;
        }

        [Benchmark]
        public async Task<string> Get_MinimalApi_Entity()
        {
            var client = new HttpClient();

            var res = await client.GetStringAsync("https://localhost:7183/api/lock/getentity");

            return res;
        }

        [Benchmark]
        public async Task<string> Get_MinimalApi_Dapper()
        {
            var client = new HttpClient();

            var res = await client.GetStringAsync("https://localhost:7183/api/lock/getdapper");

            return res;
        }
        
    }
}

