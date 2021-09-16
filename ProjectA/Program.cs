using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ProjectA
{
    class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hc, services) =>
                {
                    services.AddHostedService<ARunner>();
                })
                .Build()
                .Run();
        }
    }
}
