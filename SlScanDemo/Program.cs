using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlScanDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            args[0] = "8sj+R0eymxz/IEDKWaCLc+DaSLHvRweLzbAeIc1/G6nSGQ8mf2xkqKRCMdVpMPup0TdmPVXfq9m48/MZxUhVmg==";
            args[1] = "sp=r&st=2021-07-12T11:42:40Z&se=2021-07-12T19:42:40Z&spr=https&sv=2020-08-04&sr=c&sig=feJgisg4SL%2BQ1yaQfRDSsDnHuvlyHPaRv2fh27%2BrWas%3D"; // sas token
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
