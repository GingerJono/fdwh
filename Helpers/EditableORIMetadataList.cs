namespace Sandbox.Helpers
{
	public class EditableORIMetadataList<T>
	{
		public List<T> Current { get; set; } = new();
		public List<T> Added { get; set; } = new();
		public List<T> Removed { get; set; } = new();
	}
}
