using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Com.Ctrip.Framework.Apollo;
using Com.Ctrip.Framework.Apollo.Logging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnet_apollo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            Com.Ctrip.Framework.Apollo.Logging.LogManager.Provider = new ConsoleLoggerProvider(Com.Ctrip.Framework.Apollo.Logging.LogLevel.Trace);
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(builder => builder
                        .AddApollo(builder.Build().GetSection("apollo"))
                        .AddDefault() //添加默认application Namespace
                )
                .UseStartup<Startup>();
        }
    }
}
