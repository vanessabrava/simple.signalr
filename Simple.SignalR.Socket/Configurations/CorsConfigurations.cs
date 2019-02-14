using Microsoft.Extensions.DependencyInjection;

namespace Simple.SignalR.Socket.Configurations
{
    /// <summary>
    /// Solution to address the --> "Access to XMLHttpRequest at 'http://localhost/ws/negotiate' from origin 'http://localhost:4200' has been blocked by CORS policy: Response to preflight request doesn't pass access control check: The value of the 'Access-Control-Allow-Origin' header in the response must not be the wildcard '*' when the request's credentials mode is 'include'. The credentials mode of requests initiated by the XMLHttpRequest is controlled by the withCredentials attribute."
    /// </summary>
    internal static class CorsConfigurations
    {
        public static IServiceCollection ConfigureCors(this IServiceCollection services, string corsPolicyName)
        {
            return
                services.AddCors(options =>
                {
                    options.AddPolicy(corsPolicyName,
                      builder => builder
                            .AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials());
                });
        }
    }
}
