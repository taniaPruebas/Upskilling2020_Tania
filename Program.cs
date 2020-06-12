using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//using System.IO;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
                        
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    Console.WriteLine("#####################################################");
                    Console.WriteLine("Cat Dog Result  {0:D}\n", Cat_Dog_to_Evaluate(5, 6));
                    Console.WriteLine("#####################################################");
                });
        public static int Cat_Dog_to_Evaluate (int num1, int num2)
            {
              return num1+num2;
            }
    }
}
