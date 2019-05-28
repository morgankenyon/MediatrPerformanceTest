using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Net.Http;

namespace Benchmarker
{
    public class Runner
    {
        private static HttpClient client;

        static Runner()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5000/api/");
        }

        [Params(100)]
        public int N;

        [Benchmark(Baseline =true)]
        public void TestRegular()
        {
            for (int i = 0; i < N; i++)
            {
                var result = client.GetAsync("regular?message=helloworld").Result;
            }
        }

        [Benchmark]
        public void TestMediatr()
        {
            for (int i = 0; i < N; i++)
            {
                var result = client.GetAsync("mediatr?message=helloworld").Result;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Runner>();
        }
    }
}
