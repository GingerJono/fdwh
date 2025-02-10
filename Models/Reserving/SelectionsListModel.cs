using Sandbox.Models.Reserving.Types;
using Sandbox.Models.Windowpane;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Sandbox.Models.Reserving
{
	public class SelectionsListModel
	{
		// The Unique Identifier
		[Required]
		public required int ReservingHeaderID { get; set; }
		[Required]
		public required string Class { get; set; }
		[Required]
		public required string ReservingClass { get; set; }
		[Required]
		public required int YOA { get; set; }

		// All in GBP CNV

		public double AccountedGGWP { get; set; }
		public double AccountedDeductions { get; set; }
		public double AccountedGNWP { get; set; }
		public double IncurredClaims { get; set; }
		public double IncurredGNLR { get; set; }

		// for displaying
		public bool IsSubtotal { get; set; }
		public bool IsGrandTotal { get; set; }
		public int Ord { get; set; }
	}
}