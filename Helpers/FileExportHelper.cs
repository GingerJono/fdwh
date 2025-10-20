using System.IO.Compression;
using System.Text;
using Microsoft.JSInterop;
using Sandbox.Services; // where CsvExportService lives

namespace Sandbox.Helpers
{
    public static class FileExportHelper
    {
        public static async Task ExportToCsvAsync<T>(List<T> data, string filename, IJSRuntime js)
        {
            if (data == null || !data.Any())
            {
                Console.WriteLine($"[ExportToCsvAsync] No data found for export: {filename}");
                return;
            }

            var csv = CsvExportService.ToCsv(data); // static call
            var bytes = Encoding.UTF8.GetBytes(csv);

            using var stream = new MemoryStream(bytes);
            using var streamRef = new DotNetStreamReference(stream);

            await js.InvokeVoidAsync("downloadFileFromStream", filename, streamRef);
        }

        public static async Task ExportAllCsvsAsZipAsync(
            int runId,
            Dictionary<string, IEnumerable<object>> datasets,
            IJSRuntime js)
        {
            using var zipStream = new MemoryStream();

            using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create, leaveOpen: true))
            {
                foreach (var (name, data) in datasets)
                {
                    if (data == null || !data.Any())
                        continue;

                    var csv = CsvExportService.ToCsv(data.ToList()); // static call
                    var entry = archive.CreateEntry($"{name}_{runId}.csv");

                    using var entryStream = entry.Open();
                    using var writer = new StreamWriter(entryStream);
                    writer.Write(csv);
                }
            }

            zipStream.Position = 0;

            using var streamRef = new DotNetStreamReference(zipStream);
            await js.InvokeVoidAsync("downloadFileFromStream", $"Prism_Export_Run_{runId}.zip", streamRef);
        }
    }
}
