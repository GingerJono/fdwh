using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
//using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sandbox.Models.Windowpane;

namespace Sandbox.Helpers
{
    public static class SqlExtractor
    {
        public static async Task<Dictionary<string, string>> GetColumnarDataAsync(IConfiguration configuration, string connectionStringName, string storedProcedure, object parameters)
        {
            using var connection = new SqlConnection(configuration.GetConnectionString(connectionStringName));

            var result = await connection.QueryFirstOrDefaultAsync<dynamic>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            var data = new Dictionary<string, string>();

            if (result != null)
            {
                foreach (var pair in result)
                {
                    data.Add(pair.Key, pair.Value != null ? pair.Value.ToString() : "");
                }
            }

            return data;
		}
		public static Dictionary<string, string> GetColumnarData(IConfiguration configuration, string connectionStringName, string storedProcedure, object parameters)
		{
			using var connection = new SqlConnection(configuration.GetConnectionString(connectionStringName));

			var result = connection.QueryFirstOrDefault<dynamic>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
			var data = new Dictionary<string, string>();

			if (result != null)
			{
				foreach (var pair in result)
				{
					data.Add(pair.Key, pair.Value != null ? pair.Value.ToString() : "");
				}
			}

			return data;
		}

		public static async Task<List<Dictionary<string, object>>> GetTabularDataAsync(IConfiguration config, string connectionStringName, string sqlCommand, object? parameters = null)
		{
			using var connection = new SqlConnection(config.GetConnectionString(connectionStringName));
			var result = await connection.QueryAsync<dynamic>(sqlCommand, parameters, commandType: CommandType.StoredProcedure);
			return result
				.Select(row => ((IDictionary<string, object>)row)
				.ToDictionary(kvp => kvp.Key, kvp => kvp.Value))
				.ToList();
		}

		public static async Task<List<Tuple<string, string, string>>> GetPivotableDataAsync(IConfiguration config, string connectionStringName, string sqlCommand, object? parameters = null)
		{
			using var connection = new SqlConnection(config.GetConnectionString(connectionStringName));
			var result = await connection.QueryAsync<dynamic>(sqlCommand, parameters, commandType: CommandType.StoredProcedure);
			return result
				.Select(row =>
				{
					var dictRow = (IDictionary<string, object>)row;
					return new Tuple<string, string, string>(
						dictRow["RowValue"].ToString(),
						dictRow["ColumnValue"].ToString(),
						dictRow["OutputValue"].ToString());
				})
				.ToList();
		}

		public static async Task<IEnumerable<IGrouping<string, Dictionary<string, object>>>> GetTabTableDataAsync(IConfiguration config, string connectionStringName, string sqlCommand, string groupByColumnName, object? parameters = null)
		{
			using var connection = new SqlConnection(config.GetConnectionString(connectionStringName));
			var result = await connection.QueryAsync<dynamic>(sqlCommand, parameters, commandType: CommandType.StoredProcedure);
			var data = result
				.Select(row => ((IDictionary<string, object>)row)
				.ToDictionary(kvp => kvp.Key, kvp => kvp.Value))
				.ToList();

			return data.GroupBy(dict => dict.ContainsKey(groupByColumnName) ? dict[groupByColumnName].ToString() : string.Empty);
		}
		public static async Task<IEnumerable<ScatterCardData>> GetScatterCardDataAsync(IConfiguration config, string connectionStringName, string sqlCommand, object? parameters = null)
		{
			using var connection = new SqlConnection(config.GetConnectionString(connectionStringName));
			return await connection.QueryAsync<ScatterCardData>(sqlCommand, parameters, commandType: CommandType.StoredProcedure);
		}
	}
}
