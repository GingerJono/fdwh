namespace Sandbox.Models.Prism
{
    public class MetricModel
    {
        public int MetricOrder { get; set; }
        public string Metric { get; set; } = string.Empty;

        public static IReadOnlyList<MetricModel> AllMetrics { get; } = new List<MetricModel>
        {
            new() { MetricOrder = 1,  Metric = "01 Written Premium" },
            new() { MetricOrder = 2,  Metric = "03 Signed Premium" },
            new() { MetricOrder = 3,  Metric = "02 Earned Premium" },
            new() { MetricOrder = 4,  Metric = "04 Written Overrider" },
            new() { MetricOrder = 5,  Metric = "06 Signed Overrider" },
            new() { MetricOrder = 6,  Metric = "05 Earned Overrider" },
            new() { MetricOrder = 7,  Metric = "07 Written Profit Commission" },
            new() { MetricOrder = 8,  Metric = "09 Signed Profit Commission" },
            new() { MetricOrder = 9,  Metric = "08 Earned Profit Commission" },
            new() { MetricOrder = 10, Metric = "10 Actual Recoveries" },
            new() { MetricOrder = 11, Metric = "11 Paid Basis Recoveries" },
            new() { MetricOrder = 12, Metric = "12 Incurred Basis Recoveries" },
            new() { MetricOrder = 13, Metric = "13 Ultimate Basis Recoveries" },
            new() { MetricOrder = 14, Metric = "14 Actual RIPs" },
            new() { MetricOrder = 15, Metric = "15 Paid Basis RIPs" },
            new() { MetricOrder = 16, Metric = "16 Incurred Basis RIPs" },
            new() { MetricOrder = 17, Metric = "17 Ultimate Basis RIPs" },
        };
    }
}
