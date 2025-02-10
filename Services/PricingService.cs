using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Sandbox.Models;
using System.Data;
using System.Text;
using System.Web;
using Sandbox.Models.Windowpane;
using Sandbox.Helpers;
using Microsoft.AspNetCore.Mvc.Routing;
using Sandbox.Models.Pricing;


namespace Sandbox.Services
{
	public class PricingService
	{
		private readonly IConfiguration _configuration;

		public PricingService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

	}
}