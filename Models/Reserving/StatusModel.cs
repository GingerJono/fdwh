using Sandbox.Models.Reserving.Types;
using Sandbox.Models.Windowpane;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Sandbox.Models.Reserving
{
	public class StatusModel
	{
		// The Unique Identifier
		[Required]
		public required int ReservingHeaderID { get; set; }
		public int Version { get; set; }
		public string Status { get; set; }
		public DateTime GeneratedOn { get; set; }
		public string GeneratedBy { get; set; }
		public int NumberOfEdits { get; set; }
		public DateTime LastEditedOn { get; set; }
		public string LastEditedBy { get; set; }
		public int FXRateSetID { get; set; }
		public double UltimatePremium { get; set; }
		public double UltimateClaims{ get; set; }
	}
}