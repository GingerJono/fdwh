using System.Text;

namespace Sandbox.Services
{
    public static class CsvExportService
    {
        public static string ToCsv<T>(List<T> data)
        {
            if (data == null || !data.Any())
                return string.Empty;

            var sb = new StringBuilder();
            var properties = typeof(T).GetProperties();

            // Header
            sb.AppendLine(string.Join(",", properties.Select(p => p.Name)));

            // Rows
            foreach (var item in data)
            {
                var row = properties.Select(p =>
                {
                    var value = p.GetValue(item);
                    if (value == null) return "";
                    var s = value.ToString().Replace("\"", "\"\"");
                    return $"\"{s}\"";
                });

                sb.AppendLine(string.Join(",", row));
            }

            return sb.ToString();
        }
    }
}
