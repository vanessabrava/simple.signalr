using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Simple.SignalR.Socket.Configurations;

namespace Simple.SignalR.Socket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseKestrel()
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((hostingContext, config) => hostingContext.ConfigAppSettingsFiles(config));
    }
}
