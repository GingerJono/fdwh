namespace Sandbox.Models.Prism
{
    public class RunLogModel
    {
        public required int LogID { get; set; }
        public required int RunID { get; set; }
        public required DateTime LogTime { get; set; }
        public required string LogLevel { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
