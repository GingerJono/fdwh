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
        public string? FXRateApplicationDate { get; set; }
        public string? FXTreatment { get; set; }
        public required string ORIPolicyReference { get; set; }
        public string? PolicyDescription { get; set; }
        public string? ContractCurrency { get; set; }
        public DateTime Inception { get; set; }
        public DateTime Expiry { get; set; }
        public string? BasisOfCover { get; set; }
        public decimal? OrderPercent { get; set; }
        public string? OfWholeOrOrder { get; set; }
        public decimal? Limit { get; set; }
        public decimal? DeductibleRetention { get; set; }
        public string? BrokerPseudonym { get; set; }
        public decimal Premium { get; set; }
        public string? PolicyType { get; set; }
        public string? SecurityLeader { get; set; }
        public int InuringPriority { get; set; }
        public string? CededPremiumCalculation { get; set; }

        public string? DMSLink { get; set; }

        // Single List for inclusions and exclusions
        public List<ORIFilterItem> Filters { get; set; } = new();
        public List<ORIFilterItem> RemovedFilters { get; set; } = new(); // Track deleted filters

        // New Lists for Policy Allocations
        public List<ORIPolicyAllocationClass> PolicyAllocationsClass { get; set; } = new();
        public List<ORIPolicyAllocationYOA> PolicyAllocationsYOA { get; set; } = new();
        public List<ORIPolicyAllocationClass> RemovedPolicyAllocationsClass { get; set; } = new();
        public List<ORIPolicyAllocationYOA> RemovedPolicyAllocationsYOA { get; set; } = new();
        public List<Narrative> Narratives { get; set; } = new();
        public List<ORIPolicyReinstatementModel> Reinstatements { get; set; } = new();
        public List<PolicySecurity> PolicySecurities { get; set; } = new();

        // Class/Year of Account Allocation Splits
        public List<ClassYearOfAccountSplits> ClassYearOfAccountSplits { get; set; } = new();

        // Agg Deductibles
        public List<AggDeductibleModel> AggDeductibles { get; set; } = new();

    }

    public class ORIFilterItemDefinition
    {
        public string? Code { get; set; }  // "DomicileCountry", "InwardPolicyReference", etc.
        public string? DisplayName { get; set; }  // "Domicile Country", "Inward Policy Reference"
    }

    // New Model to represent a row in the new Filters table
    public class ORIFilterItem
    {
        public string? InclusionExclusion { get; set; }  // "Inclusion" or "Exclusion"
        public string? IncludedOrExcludedItem { get; set; } // Predefined object
        public string? IncludedOrExcludedValue { get; set; } // Actual value e.g., "US", "001810H19AA"
        public string? Note { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }

    }


    public class Narrative
    {
        public int Sequence_no { get; set; }
        public string? Notes { get; set; } // Add this for the note
        public DateTime? Date_entered { get; set; }
        public string? underwriter_initials { get; set; } // Add this for the note
    }

    public class PolicySecurity
    {
        public required string LORS { get; set; }
        public decimal Share { get; set; }
        public string? SecurityStatus { get; set; }
        public string? SecurityName { get; set; }
    }
    public class DomicileCountry
    {
        public string? Code { get; set; } // e.g., "US"
        public string? Name { get; set; } // e.g., "United States"
    }
    public class ClassItem
    {
        public string? ClassCode { get; set; }
        public string? Description { get; set; }
    }
    public class Peril
    {
        public string? Name { get; set; }
    }

    public class ReservingClass
    {
        public string? ClassCode { get; set; }
        public string? ReservingClassCode { get; set; }
        public string? ReservingClassName { get; set; }
    }

    public class RiskCode
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
    }

    public class StatCode
    {
        public string? Code { get; set; }
        public string? Description { get; set; }
    }

    // New classes to represent the allocation tables
    public class ORIPolicyAllocationClass
    {
        public string? Class { get; set; }
        public decimal Allocation { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }
    }

    public class ORIPolicyAllocationYOA
    {
        public int YearOfAccount { get; set; }
        public decimal Allocation { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? LastUpdatedBy { get; set; }
    }

    public class ClassYearOfAccountSplits
    {
        public string? Class { get; set; }
        public Dictionary<int, decimal> YearOfAccountSplits { get; set; } = new();
    }

}

