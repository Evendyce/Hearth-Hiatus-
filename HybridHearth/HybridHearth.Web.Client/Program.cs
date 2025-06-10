using HybridHearth.Shared.Services;
using HybridHearth.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HybridHearth.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add device-specific services used by the HybridHearth.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
