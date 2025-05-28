namespace Sandbox.Helpers
{
	public class SandboxContext
	{
		public string WebServerName { get; init; } = Environment.MachineName;
		public string DatabaseServer { get; set; } = "";
		public string DatabaseName { get; set; } = "";
		public string UserName { get; set; } = "";
		public string? UserNameOverride { get; set; }

		public string EffectiveUserName => string.IsNullOrEmpty(UserNameOverride) ? UserName : UserNameOverride;
	}
}
