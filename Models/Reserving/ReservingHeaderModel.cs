using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sandbox.Models.Reserving
{
	public class ReservingHeaderModel
	{
		[Required]
		public required int ReservingHeaderID { get; set; }

		public List<SelectionsModel> SelectionsModels { get; set; } = new List<SelectionsModel>();

		public ReservingHeaderModel()
		{
		}

		public static ReservingHeaderModel CompareTwoModels(ReservingHeaderModel comparator, ReservingHeaderModel baseline)
		{
			var diffModel = new ReservingHeaderModel
			{
				ReservingHeaderID = baseline.ReservingHeaderID,
				SelectionsModels = new List<SelectionsModel>()
			};

			// Compare SelectionsModels from both comparator and baseline
			for (int i = 0; i < comparator.SelectionsModels.Count; i++)
			{
				// Just a basic example; you'd want more thorough checks here.
				if (i < baseline.SelectionsModels.Count)
				{
					var diffSelectionsModel = SelectionsModel.CalculateDifference(comparator.SelectionsModels[i], baseline.SelectionsModels[i]);
					diffModel.SelectionsModels.Add(diffSelectionsModel);
				}
			}

			return diffModel;
		}
	}
}
