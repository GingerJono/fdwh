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
		public IEnumerable<Narrative> Narratives { get; set; }

		public EditableORIMetadataList<ExcludedDomicileCountry> ExcludedDomicileCountries { get; set; }
		public EditableORIMetadataList<ExcludedInwardPolicyReference> ExcludedInwardPolicyReferences { get; set; }
		public EditableORIMetadataList<ExcludedPlacementUMR> ExcludedPlacementUMRs { get; set; }
		public EditableORIMetadataList<ExcludedReservingClass> ExcludedReservingClasses { get; set; }
		public EditableORIMetadataList<ExcludedRiskCode> ExcludedRiskCodes { get; set; }
		public EditableORIMetadataList<ExcludedStatCode2> ExcludedStatCode2s { get; set; }
		public EditableORIMetadataList<IncludedClass> IncludedClasses { get; set; }
		public EditableORIMetadataList<IncludedDomicileCountry> IncludedDomicileCountries { get; set; }
		public EditableORIMetadataList<IncludedInwardPolicyReference> IncludedInwardPolicyReferences { get; set; }
		public EditableORIMetadataList<IncludedPeril> IncludedPerils { get; set; }
		public EditableORIMetadataList<IncludedPlacementUMR> IncludedPlacementUMRs { get; set; }
		public EditableORIMetadataList<IncludedReservingClass> IncludedReservingClasses { get; set; }
		public EditableORIMetadataList<IncludedRiskCodes> IncludedRiskCodes { get; set; }
		public EditableORIMetadataList<IncludedStatCode1> IncludedStatCode1s { get; set; }
		public EditableORIMetadataList<IncludedStatCode2> IncludedStatCode2s { get; set; }

		// Securities
		public IEnumerable<PolicySecurity> Securities { get; set; }

		public List<ClassItem> Classes { get; set; } = new();
		public List<DomicileCountry> DomicileCountries { get; set; } = new();
		public List<Peril> Perils { get; set; } = new();
		public List<ReservingClass> ReservingClasses { get; set; } = new();
		public List<RiskCode> RiskCodes { get; set; } = new();
		public List<StatCode> StatCode1s { get; set; } = new();
		public List<StatCode> StatCode2s { get; set; } = new();
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