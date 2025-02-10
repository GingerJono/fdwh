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
using Sandbox.Models.Reporting;


namespace Sandbox.Services
{
	public class ReportingService
	{
		private readonly IConfiguration _configuration;

		public ReportingService(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public async Task<IEnumerable<ReportingModel>> GetSSRSReportsAsync(string userName)
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				parameters.Add("UserName", userName, DbType.String);

				var result = await connection.QueryAsync<ReportingModel>(
					"reporting.spGetSSRSReports",
					parameters,
					commandType: CommandType.StoredProcedure
				);

				return result.ToList();
			}
		}

	}
}