using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Engine.Areas.Identity.IdentityHostingStartup))]
namespace Engine.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}