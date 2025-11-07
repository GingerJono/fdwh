using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Sandbox.Models.Exceptions;
using Sandbox.Models.Windowpane;

namespace Sandbox.Services
{
	public class ExceptionService
	{
		private readonly IConfiguration _configuration;

		public ExceptionService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task<IEnumerable<ExceptionRecord>> GetExceptions()
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var result = await connection.QueryAsync<ExceptionRecord>(
					"Exceptions.spGetExceptionsList",
					commandType: CommandType.StoredProcedure
				);

				if (result != null)
				{
					return result.ToList();
				}
				else
				{
					throw new Exception("No exceptions found.");
				}
			}
		}

		public async Task UpdateExceptionStatusAsync(int exceptionId, string user, string notes, string newTargetStatus)
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("ExceptionsConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				parameters.Add("@ExceptionID", exceptionId);
				parameters.Add("@User", user);
				parameters.Add("@Notes", notes);
				parameters.Add("@NewTargetStatus", newTargetStatus);

				await connection.ExecuteAsync(
					"Exceptions.spUpdateExceptionStatus",
					parameters,
					commandType: CommandType.StoredProcedure
				);
			}
		}

	}
}
