using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorSWAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddStarWarsClient();
            builder.Services.AddHttpClient(
                "StarWarsClient",
                client =>{
                    client.BaseAddress= new Uri("http://localhost:5000/graphql");
                });

            await builder.Build().RunAsync();
        }
    }
}
