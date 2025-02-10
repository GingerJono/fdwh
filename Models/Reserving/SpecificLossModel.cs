using Sandbox.Models.Reserving.DataExtracts;
using Sandbox.Models.Reserving.Types;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Sandbox.Models.Reserving
{
	public class SpecificLoss
	{
		[Required]
		public required int ReservingHeaderID { get; set; }
		public required string Event { get; set; }
		public required string EventType { get; set; }

		// will be totalled from the RsvClassYOACombos
		public required SettCcySet PaidLF { get; set; }
		public required SettCcySet PaidExLF { get; set; }
		public required SettCcySet OS { get; set; }
		public required SettCcySet Incurred { get; set; }
		public required SettCcySet Ultimate { get; set; }
		public required SettCcySet IBNR { get; set; }

		public List<SpecificLossRsvClassYOA>? SpecificLossRsvClassYOAs { get; set; }
	}

	public class SpecificLossRsvClassYOA
	{
		[Required]
		public required int ReservingHeaderID { get; set; }
		[Required]
		public required string Event { get; set; }
		[Required]
		public required string Class { get; set; }
		[Required]
		public required string ReservingClass { get; set; }
		[Required]
		public required int YOA { get; set; }
		public required string EventType { get; set; }

		public SettCcySet PaidLF { get; set; }
		public SettCcySet PaidExLF { get; set; }
		public SettCcySet OS { get; set; }
		public SettCcySet Incurred { get; set; }

		public string? UltimateClaimsSelection { get; set; }
		private SettCcySet _ultimateClaimsSetValue = new("_ultimateClaimsSetValue");
		public SettCcySet UltimateClaimsSetValue
		{
			get { return _ultimateClaimsSetValue; }
			set
			{
				_ultimateClaimsSetValue = value;
			}
		}

		public string? UltimateRIPsSelection { get; set; }
		private SettCcySet _ultimateRIPsSetValue = new("_ultimateRIPsSetValue");
		public SettCcySet UltimateRIPsSetValue
		{
			get { return _ultimateRIPsSetValue; }
			set
			{
				_ultimateRIPsSetValue = value;
			}
		}
		public double UltimateRIPsSetPercentageOfClaims { get; set; }

		private SettCcySet _iBNRClaims = new("_iBNRClaims");
		public SettCcySet IBNRClaims
		{
			get { return _iBNRClaims; }
			set
			{
				_iBNRClaims = value;
			}
		}

		public bool IsNewlyAdded { get; set; } // New property to track if it's a new row when being added via EditSelection


		// CALCULATIONS - HIGH LEVEL
		public SettCcySet UltimateClaims { get; set; } // Switch on UltimateClaimsSelection: Incurred? Take Incurred Value, SetValue? take Selected
		public SettCcySet UltimateRIPs { get; set; } // Switch on UltimateRIPsSelection: Percentage? Claims * Percentage, SetValue? take Selected

		// METHODS

		public void UpdateCalcs()
		{
			// CALCULATIONS - Decisions
			UltimateClaims = UltimateClaimsSelection switch // Switch on UltimateClaimsSelection: Incurred? Take Incurred Value, SetValue? take Selected
			{
				"Set Value" => UltimateClaimsSetValue,
				"Incurred" => Incurred,
				_ => UltimateClaims
			};

			UltimateRIPs = UltimateRIPsSelection switch // Switch on UltimateRIPsSelection: Percentage? Claims * Percentage, SetValue? take Selected
			{
				"Set Value" => UltimateRIPsSetValue,
				"Percentage" => SettCcySet.ScaleSettCcySet(UltimateClaims,UltimateRIPsSetPercentageOfClaims/100,"UltimateRIPs set by Percentage"),
				_ => UltimateRIPs
			};

			PaidLF.UpdateSplits();
			PaidExLF.UpdateSplits();
			OS.UpdateSplits();
			Incurred.UpdateSplits();
			UltimateClaims.UpdateSplits();
			UltimateRIPs.UpdateSplits();
			UltimateClaimsSetValue.UpdateSplits();
			UltimateRIPsSetValue.UpdateSplits();
			IBNRClaims.UpdateSplits();
		}

		public static SpecificLossRsvClassYOA? Clone(SpecificLossRsvClassYOA original)
		{
			// Convert the current object to JSON string
			var json = JsonSerializer.Serialize(original);

			// Convert the JSON string back to a new object
			return JsonSerializer.Deserialize<SpecificLossRsvClassYOA>(json);
		}

		// Need one to update the Ultimates based on whatever gets selected

	}
}
