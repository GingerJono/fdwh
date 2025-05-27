namespace Sandbox.Models.Windowpane
{
    public class MyAccountsModel
    {
        public List<MyProgram> Programs { get; set; } = new List<MyProgram>();
        public List<Policy> Policies { get; set; } = new List<Policy>();
    }

    public class MyProgram
	{
		public string ProgramRef { get; set; }
		public DateTime Inception { get; set; }
		public string Assured { get; set; }
		public decimal GrossEPI { get; set; }
		public int LayerCount { get; set; }
	}
    public class Policy
	{
		public string ProgramRef { get; set; }
		public string PolicyRef { get; set; }
		public DateTime Inception { get; set; }
		public string Assured { get; set; }
		public decimal GrossEPI { get; set; }
	}
}
