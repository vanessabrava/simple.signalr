using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Simple.SignalR.Socket.Configurations
{
    internal static class AppSettingsConfigurations
    {
        public static WebHostBuilderContext ConfigAppSettingsFiles(this WebHostBuilderContext hostingContext, IConfigurationBuilder configuration)
        {
            configuration.AddJsonFile("appsettings/appsettings.json", optional: true, reloadOnChange: true);
            configuration.AddJsonFile($"appsettings/appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);

            configuration.AddEnvironmentVariables();

            return hostingContext;
        }
    }
}
