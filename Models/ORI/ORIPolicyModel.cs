using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Collections.Generic;
using Sandbox.Helpers;

namespace Sandbox.Models.ORI
{
	public class ORIPolicyModel
	{
		public string ORIPillar { get; set; }
		public DateTime? FXRateApplicationDate { get; set; }
		public string FXTreatment { get; set; }
		public bool AllowBlocks { get; set; }
		public string ORIPolicyReference { get; set; }
		public string PolicyDescription { get; set; }
		public string ContractCurrency { get; set; }
		public DateTime? Inception { get; set; }
		public DateTime? Expiry { get; set; }
		public string BasisOfCoverCode { get; set; }
		public string BasisOfCover { get; set; }
		public decimal? OrderPercent { get; set; }
		public string OfWholeOrOrder { get; set; }
		public decimal? Limit { get; set; }
		public decimal? DeductibleRetention { get; set; }
		public decimal? Aggregate { get; set; }

		// Single List for inclusions and exclusions
		public List<ORIFilterItem> Filters { get; set; } = new();
	}

	// New Model to represent a row in the new Filters table
	public class ORIFilterItem
	{
		public string InclusionExclusion { get; set; }  // "Inclusion" or "Exclusion"
		public string IncludedOrExcludedItem { get; set; } // "DomicileCountry", "InwardPolicyReference", etc.
		public string IncludedOrExcludedValue { get; set; } // Actual value e.g., "US", "001810H19AA"
		public string Note { get; set; }
	}

	public class Narrative
	{
		public int Sequence_no { get; set; }
		public string Notes { get; set; } // Add this for the note
		public DateTime? Date_entered { get; set; }
		public string underwriter_initials { get; set; } // Add this for the note
	}

	public class ExcludedDomicileCountry
	{
		public string DomicileCountry { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class ExcludedInwardPolicyReference
	{
		public string InwardPolicyReference { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class ExcludedPlacementUMR
	{
		public string PlacementUMR { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class ExcludedReservingClass
	{
		public string ReservingClass { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class ExcludedRiskCode
	{
		public string RiskCode { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class ExcludedStatCode2
	{
		public string StatCode2 { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedClass
	{
		public string Class { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedDomicileCountry
	{
		public string DomicileCountry { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedInwardPolicyReference
	{
		public string InwardPolicyReference { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedPeril
	{
		public string Peril { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedPlacementUMR
	{
		public string PlacementUMR { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedReservingClass
	{
		public string ReservingClass { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedRiskCodes
	{
		public string PolicyMainRiskCode { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedStatCode1
	{
		public string StatCode1 { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class IncludedStatCode2
	{
		public string StatCode2 { get; set; }
		public string? Note { get; set; } // Add this for the note
	}

	public class PolicySecurity
	{
		public string LORS { get; set; }
		public decimal Share { get; set; }
		public string SecurityStatus { get; set; }
		public string SecurityName { get; set; }
	}
	public class DomicileCountry
	{
		public string Code { get; set; } // e.g., "US"
		public string Name { get; set; } // e.g., "United States"
	}
	public class ClassItem
	{
		public string ClassCode { get; set; }
		public string Description { get; set; }
	}
	public class Peril
	{
		public string Name { get; set; }
	}

	public class ReservingClass
	{
		public string ClassCode { get; set; }       
		public string ReservingClassCode { get; set; } 
		public string ReservingClassName { get; set; }          
	}

	public class RiskCode
	{
		public string Code { get; set; }
		public string Description { get; set; }
	}

	public class StatCode
	{
		public string Code { get; set; }
		public string Description { get; set; }
	}


}