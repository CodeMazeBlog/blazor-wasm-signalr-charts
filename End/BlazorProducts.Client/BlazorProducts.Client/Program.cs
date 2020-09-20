using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using BlazorProducts.Client.HttpRepository;

namespace BlazorProducts.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("app");

			builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5011/api/") });
			builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();

			await builder.Build().RunAsync();
		}
	}
}
