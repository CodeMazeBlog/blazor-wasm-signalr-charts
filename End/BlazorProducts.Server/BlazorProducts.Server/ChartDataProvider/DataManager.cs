using Entities.Models;
using System;
using System.Collections.Generic;

namespace BlazorProducts.Server.ChartDataProvider
{
	public static class DataManager
	{
		public static List<ChartDto> GetData()
		{
			var r = new Random();
			return new List<ChartDto>()
			{
				new ChartDto { Value = r.Next(1, 40), Label = "Wall Clock" },
				new ChartDto { Value = r.Next(1, 40), Label = "Fitted T-Shirt" },
				new ChartDto { Value = r.Next(1, 40), Label = "Tall Mug" },
				new ChartDto { Value = r.Next(1, 40), Label = "Pullover Hoodie" }
			};
		}
	}
}
