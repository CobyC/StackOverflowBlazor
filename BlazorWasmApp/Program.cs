using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorWasmApp.Shared;
using Syncfusion.Blazor;

namespace BlazorWasmApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);            
            builder.RootComponents.Add<App>("app");
            //add Head to root components
            builder.RootComponents.Add<Head>("head");
            builder.Services.AddSyncfusionBlazor();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });           
            await builder.Build().RunAsync();
        }
    }
}
