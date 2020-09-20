using Entities.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorProducts.Server.HubConfig
{
	public class ChartHub : Hub
	{
		public async Task AcceptChartData(List<ChartDto> data) => 
			await Clients.All.SendAsync("ExchangeChartData", data);
	}
}
