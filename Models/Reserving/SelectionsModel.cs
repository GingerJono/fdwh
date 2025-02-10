using Sandbox.Models.Reserving.Types;
using Sandbox.Models.Windowpane;
using Sandbox.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Reflection;
using System.Text.Json;

namespace Sandbox.Models.Reserving
{
	public class SelectionsModel
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

		// SELECTIONS

		// 1.0  Gross Written Premium

		public string? UltimateGGWPSelection { get; set; }
		private SettCcySet _ultimateGGWPSetValue = new("Ultimates GGWP");
		public SettCcySet UltimateGGWPSetValue
		{
			get { return _ultimateGGWPSetValue; }
			set
			{
				_ultimateGGWPSetValue = value;

			}
		}

		// 1.1  NCB, PC, Swings

		public string? NCBPCSwingSelection { get; set; }
		private SettCcySet _nCBPCSwingSetValue = new("_nCBPCSwingSetValue");
		public SettCcySet NCBPCSwingSetValue
		{
			get { return _nCBPCSwingSetValue; }
			set
			{
				_nCBPCSwingSetValue = value;
			}
		}

		// 1.2  Inwards RIPs

		public string? InwardsRIPsSelection { get; set; }
		private SettCcySet _inwardsRIPsSetValue = new("_inwardsRIPsSetValue");
		public SettCcySet InwardsRIPsSetValue
		{
			get { return _inwardsRIPsSetValue; }
			set
			{
				_inwardsRIPsSetValue = value;
			}
		}
		public double InwardsRIPsSetPercentageOfClaims { get; set; }

		// 1.2  Deductions

		public string? DeductionsSelection { get; set; }
		public double DeductionsSetPercentage { get; set; }

		private string _displayDeductionsSetPercentage;
		public string DisplayDeductionsSetPercentage
		{
			get => (DeductionsSetPercentage * 100).ToString();
			set
			{
				if (double.TryParse(value, out double parsedValue))
				{
					DeductionsSetPercentage = parsedValue / 100;
				}
				_displayDeductionsSetPercentage = value;
			}
		}

		// 1.3 Ultimate Loss Ratio

		public string? UltimateLossRatioSelection { get; set; }
		public double UltimateLossRatioSetValue { get; set; }

		// 1.4 Unearned Loss Ratio

		public double UnearnedLossRatioSetValue { get; set; }

		// 1.5 Non-Specific IBNRs

		public double NonSpecificIBNRCatSplit { get; set; }
		public double NonSpecificIBNRLargeSplit { get; set; }
		public double NonSpecificIBNRAttritionalSplit { get; set; }

		// SPECIFIC LOSSES

		public List<SpecificLossRsvClassYOA> SpecificLosses { get; set; } = new List<SpecificLossRsvClassYOA>();

		public Actuals Actuals { get; set; } = new();
		public Plan Plan { get; set; } = new();
		public double EarnedPercentage { get; set; }

		// CALCULATIONS - HIGH LEVEL
		public SettCcySet UltimateGGWP { get; set; } // Switch on UltimateSelection: Plan? use Plan, Written? take Written, Signed? take GNSP, SetValue? take Selected
		public double UltimateDeductions { get; set; } // Switch on DeductionsSelection: Plan? use Plan, Written? take Written, Signed? take 1-GNSP/GGSP, SetValue? take Selected
		public SettCcySet UltimateGNWP { get; set; } // UltimateGGWP * ( 1 - UltimateDeductions )
		public SettCcySet UltimateInwardsRIPs { get; set; } // Switch on InwardsRIPsSelection: Plan? use Plan, Signed? take 1-GNSP/GGSP, SetValue? take Selected
		public SettCcySet UltimateNCBPCSwing { get; set; } // Switch on DeductionsSelection: Plan? use Plan, Written? take Written, Signed? take SignedInwardsRIPs, SetValue? take Selected
		public double UltimateLossRatio { get; set; } // Switch on UltimateLossRatioSelection: Plan? use Plan, Incurred? take Incurred/GNSP, SetValue? take Selected

		// CALCULATIONS - Premium
		public SettCcySet UnwrittenGGWP { get; set; } // Ultimate GGWP less Written GGWP
		public SettCcySet UnwrittenGNWP { get; set; } // Ultimate GNWP less Written GNWP
		public SettCcySet EarnedGGWP { get; set; } // GGWP * Earned %
		public SettCcySet EarnedGNWP { get; set; } // GNWP * Earned %
		public SettCcySet UnearnedGGWP { get; set; } // UltGGWP - EarnedGGWP
		public SettCcySet UnearnedGNWP { get; set; } // UltGNWP - EarnedGNWP
		public SettCcySet SpecificUltimateRIPs { get; set; } // From specifics
		public SettCcySet SpecificUltimateRIPsCat { get; set; } // From specifics
		public SettCcySet SpecificUltimateRIPsLarge { get; set; } // From specifics
		public SettCcySet FutureRIPs { get; set; } // TotalUltimateRIPs - SignedInwardsRIPs
		public double WrittenDeductions { get; set; } // 1 - (GNWP/GGWP)
		public double PlanDeductions { get; set; } // 1 - (PlanGNWP/PlanGGWP)

		// CALCULATIONS - Ultimates/IBNR/specifics
		public SettCcySet SpecificUltimateClaims { get; set; } // From specifics
		public SettCcySet SpecificIncurredClaims { get; set; } // From specifics
		public SettCcySet SpecificUltimateClaimsCat { get; set; } // From specifics
		public SettCcySet SpecificIncurredClaimsCat { get; set; } // From specifics
		public SettCcySet SpecificUltimateClaimsLarge { get; set; } // From specifics
		public SettCcySet SpecificIncurredClaimsLarge { get; set; } // From specifics
		public SettCcySet TotalUltimateClaims { get; set; } // UltGNWP * UltLossRatio
		public SettCcySet TotalPaidExLF { get; set; } // PaidExLFCat + PaidExLFLarge + PaidExLFAttr
		public SettCcySet TotalLF { get; set; } // LFCat + LFLarge + LFAttr
		public SettCcySet TotalPaid { get; set; } // PaidCat + PaidLarge + PaidAttr
		public SettCcySet TotalOS { get; set; } // OSCat + OSLarge + OSAttr
		public SettCcySet TotalIncurred { get; set; } // IncurredCat + IncurredLarge + IncurredAttr
		public SettCcySet TotalIBNR { get; set; } // UltimateClaims - IncurredClaims

		public SettCcySet SpecificIBNR { get; set; } // SpecificUltimateClaims - SpecificIncurred
		public SettCcySet NonSpecificIBNR { get; set; } // TotalIBNR - SpecificIBNR

		// CALCULATIONS - Cat
		public SettCcySet PaidCat { get; set; } // PaidExLFCat + LFCat
		public SettCcySet IncurredCat { get; set; } // PaidCat + OSCat
		public SettCcySet SpecificIBNRCat { get; set; } // from specifics
		public SettCcySet NonSpecificIBNRCat { get; set; } // NonSpecificIBNR * NonSpecificIBNRCatSplit
		public SettCcySet IBNRCat { get; set; } // SpecificIBNRCat + NonSpecificIBNRCat
		public SettCcySet UltimateCat { get; set; } // IncurredCat + IBNRCat
		public SettCcySet EarnedCatClaims { get; set; } // IncurredCat + SpecificIBNRCat

		// CALCULATIONS - Large
		public SettCcySet PaidLarge { get; set; } // PaidExLFLarge + LFLarge
		public SettCcySet IncurredLarge { get; set; } // PaidLarge + OSLarge
		public SettCcySet SpecificIBNRLarge { get; set; } // from specifics
		public SettCcySet NonSpecificIBNRLarge { get; set; } // NonSpecificIBNR * NonSpecificIBNRLargeSplit
		public SettCcySet IBNRLarge { get; set; } // SpecificIBNRLarge + NonSpecificIBNRLarge
		public SettCcySet UltimateLarge { get; set; } // IncurredLarge + IBNRLarge
		public SettCcySet EarnedLargeClaims { get; set; } // IncurredLarge + SpecificIBNRLarge

		// CALCULATIONS - Attritional
		public SettCcySet PaidAttr { get; set; } // PaidExLFAttr + LFAttr
		public SettCcySet IncurredAttr { get; set; } // PaidAttr + OSAttr
		public SettCcySet IBNRAttr { get; set; } // NonSpecificIBNR * NonSpecificIBNRAttrSplit
		public SettCcySet UltimateAttr { get; set; } // IncurredAttr + SpecificIBNRAttr + IBNRAttr ** OR ** TotalUltimateClaims - Incurred - IBNRLarge - IBNRCat
		public SettCcySet EarnedClaims { get; set; } // Incurred + Specific IBNR
		public SettCcySet IBNRandLF { get; set; } // TotalIBNR+LF


		// LOSS RATIOS
		public double GGILR { get; set; } // Incurred / GGAP
		public double GNILR { get; set; } // Incurred / GNAP
		public double GGULR { get; set; } // Ultimate Claims / GGAP
		public double GNULR { get; set; } // Ultimate Claims / GNAP
		public double GGELR { get; set; } // (Incurred + Specific IBNR) / GGEP
		public double GNELR { get; set; } // (Incurred + Specific IBNR) / GNEP


		// CONSTRUCTOR!
		public SelectionsModel()
		{
		}

		public void UpdateCalcs()
		{
			// CALCULATIONS - Decisions
			// Do Ultimate GGWP first as it's simple.
			UltimateGGWP = UltimateGGWPSelection switch // Switch on UltimateSelection: Plan? use Plan, Written? take Written, Signed? take GNSP, SetValue? take Selected
			{
				"Set Value" => UltimateGGWPSetValue,
				"Written" => Actuals.GGWP,
				"Plan" => Plan.GGWP,
				"Signed" => Actuals.GGSP,
				_ => UltimateGGWP
			};

			// RECALCULATE the rest if we have a legitimate UltimateGGWP
			if (UltimateGGWP != null) // i.e. we have an UltimateGGWPSelection so time to recalc! (otherwise might be too soon to run calcs...)
			{
				UltimateDeductions = DeductionsSelection switch // Switch on DeductionsSelection: Plan? use Plan, Written? take Written, Signed? take 1-GNSP/GGSP, SetValue? take Selected
				{
					"Set Value" => DeductionsSetPercentage,
					"Written" => Actuals.GGWP.TotalValueInGBP != 0 ? 1 - Actuals.GNWP.TotalValueInGBP / Actuals.GGWP.TotalValueInGBP : 0,
					"Plan" => Plan.GGWP.TotalValueInGBP != 0 ? 1 - Plan.GNWP.TotalValueInGBP / Plan.GGWP.TotalValueInGBP : 0,
					"Signed" => Actuals.GGSP.TotalValueInGBP != 0 ? 1 - Actuals.GNSP.TotalValueInGBP / Actuals.GGSP.TotalValueInGBP : 0,
					_ => UltimateDeductions
				};
				UltimateGNWP = SettCcySet.ScaleSettCcySet(UltimateGGWP, (1 - UltimateDeductions), "UltimateGNWP"); // UltimateGGWP * ( 1 - UltimateDeductions )
				UltimateInwardsRIPs = InwardsRIPsSelection switch // Switch on InwardsRIPsSelection: Plan? use Plan, Signed? take Signed, SetValue? take Selected
				{
					"Set Value" => InwardsRIPsSetValue,
					"Plan" => Plan.InwardsRIPs,
					"Signed" => Actuals.SignedInwardsRIPs,
					_ => UltimateInwardsRIPs
				};
				UltimateNCBPCSwing = NCBPCSwingSelection switch // Switch on NCBPCSwing: Plan? use Plan, Signed? take Signed, SetValue? take Selected
				{
					"Set Value" => NCBPCSwingSetValue,
					"Plan" => Plan.NCBPCSwing,
					"Signed" => Actuals.SignedNCBPCSwing,
					_ => UltimateNCBPCSwing
				};

				// CALCULATIONS - Premium

				UnwrittenGGWP = SettCcySet.SubtractSettCcySets(UltimateGGWP, Actuals.GGWP, "UnwrittenGGWP"); // Ultimate GGWP less Written GGWP
				UnwrittenGNWP = SettCcySet.SubtractSettCcySets(UltimateGNWP, Actuals.GNWP, "UnwrittenGNWP"); ; // Ultimate GNWP less Written GNWP
				EarnedGGWP = SettCcySet.ScaleSettCcySet(Actuals.GGWP, EarnedPercentage, "EarnedGGWP"); // GGWP * Earned %
				EarnedGNWP = SettCcySet.ScaleSettCcySet(Actuals.GNWP, EarnedPercentage, "EarnedGNWP"); // GNWP * Earned %
				UnearnedGGWP = SettCcySet.SubtractSettCcySets(UltimateGGWP, EarnedGGWP, "UnearnedGGWP"); // UltGGWP - EarnedGGWP
				UnearnedGNWP = SettCcySet.SubtractSettCcySets(UltimateGNWP, EarnedGNWP, "UnearnedGNWP"); // UltGNWP - EarnedGNWP

				// CALCULATIONS - Specifics
				List<SettCcySet> AllSpecificUltimateClaims = SpecificLosses.Select(x => x.UltimateClaims).ToList();
				List<SettCcySet> AllSpecificUltimatesClaimsCat = SpecificLosses.Where(x => x.EventType == "Cat").Select(x => x.UltimateClaims).ToList();
				List<SettCcySet> AllSpecificUltimatesClaimsLarge = SpecificLosses.Where(x => x.EventType == "Large").Select(x => x.UltimateClaims).ToList();
				List<SettCcySet> AllSpecificIncurredClaims = SpecificLosses.Select(x => x.Incurred).ToList();
				List<SettCcySet> AllSpecificIncurredClaimsCat = SpecificLosses.Where(x => x.EventType == "Cat").Select(x => x.Incurred).ToList();
				List<SettCcySet> AllSpecificIncurredClaimsLarge = SpecificLosses.Where(x => x.EventType == "Large").Select(x => x.Incurred).ToList();
				SpecificUltimateClaims = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimateClaims, "SpecificUltimateClaims");
				SpecificUltimateClaimsCat = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimatesClaimsCat, "SpecificUltimateClaimsCat"); // From specifics
				SpecificUltimateClaimsLarge = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimatesClaimsLarge, "SpecificUltimateClaimsLarge"); // From specifics
				SpecificIncurredClaims = SettCcySet.AddMultipleSettCcySets(AllSpecificIncurredClaims, "SpecificIncurredClaims"); // From specifics
				SpecificIncurredClaimsCat = SettCcySet.AddMultipleSettCcySets(AllSpecificIncurredClaimsCat, "SpecificIncurredClaimsCat"); // From specifics
				SpecificIncurredClaimsLarge = SettCcySet.AddMultipleSettCcySets(AllSpecificIncurredClaimsLarge, "SpecificIncurredClaimsLarge"); // From specifics

				List<SettCcySet> AllSpecificUltimateRIPs = SpecificLosses.Select(x => x.UltimateRIPs).ToList();
				List<SettCcySet> AllSpecificUltimateRIPsCat = SpecificLosses.Select(x => x.UltimateRIPs).ToList();
				List<SettCcySet> AllSpecificUltimateRIPsLarge = SpecificLosses.Select(x => x.UltimateRIPs).ToList();
				SpecificUltimateRIPs = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimateRIPs, "SpecificUltimateRIPs");
				SpecificUltimateRIPsCat = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimateRIPsCat, "SpecificUltimateRIPsCat");
				SpecificUltimateRIPsLarge = SettCcySet.AddMultipleSettCcySets(AllSpecificUltimateRIPsLarge, "SpecificUltimateRIPsLarge");

				FutureRIPs = SettCcySet.SubtractSettCcySets(UltimateInwardsRIPs, Actuals.SignedInwardsRIPs, "FutureRIPs"); // TotalUltimateRIPs - SignedInwardsRIPs

				// Ultimate Loss Ratio selection needs to happen before calculation of Ultimate Losses (obv!)
				UltimateLossRatio = UltimateLossRatioSelection switch // Switch on UltimateLossRatioSelection: Plan? use Plan, Incurred? take Incurred/GNSP, SetValue? take Selected
				{
					"Set Value" => UltimateLossRatioSetValue,
					"Plan" => Plan.UltimateLossRatio, // if Plan GGWP = 0, 0 else Plan losses + 
					"Incurred" => Actuals.IncurredLossRatio,
					_ => UltimateLossRatio
				};

				// CALCULATIONS - Ultimates/IBNR
				TotalUltimateClaims = SettCcySet.ScaleSettCcySet(UltimateGNWP, UltimateLossRatio, "TotalUltimateClaims"); // UltGNWP * UltLossRatio
				TotalPaidExLF = Actuals.PaidExLFTotal; // PaidExLFCat + PaidExLFLarge + PaidExLFAttr
				TotalLF = Actuals.LFTotal; // LFat + LFLarge + LFAttr
				TotalPaid = Actuals.PaidTotal; // PaidCat + PaidLarge + PaidAttr
				TotalOS = Actuals.OSTotal; // OSCat + OSLarge + OSAttr
				TotalIncurred = Actuals.IncurredTotal; // IncurredCat + IncurredLarge + IncurredAttr
				TotalIBNR = SettCcySet.SubtractSettCcySets(TotalUltimateClaims, TotalIncurred, "TotalIBNR"); // UltimateClaims - IncurredClaims
				SpecificIBNR = SettCcySet.SubtractSettCcySets(SpecificUltimateClaims, SpecificIncurredClaims, "SpecificIBNR"); // SpecificUltimateClaims - SpecificIncurred
				NonSpecificIBNR = SettCcySet.SubtractSettCcySets(TotalIBNR, SpecificIBNR, "NonSpecificIBNR"); // TotalIBNR - SpecificIBNR
				IBNRandLF = SettCcySet.AddSettCcySets(TotalIBNR, TotalLF, "IBNRandLF"); // TotalIBNR + TotalLF

				// CALCULATIONS - Cat
				PaidCat = Actuals.PaidCat; // PaidExLFCat + LFCat
				IncurredCat = Actuals.IncurredCat; // PaidCat + OSCat
				SpecificIBNRCat = SettCcySet.SubtractSettCcySets(SpecificUltimateClaimsCat, SpecificIncurredClaimsCat, "SpecificIBNRCat"); // from specifics
				NonSpecificIBNRCat = SettCcySet.ScaleSettCcySet(NonSpecificIBNR, NonSpecificIBNRCatSplit, "NonSpecificIBNRCat"); // NonSpecificIBNR * NonSpecificIBNRCatSplit
				IBNRCat = SettCcySet.AddSettCcySets(SpecificIBNRCat, NonSpecificIBNRCat, "IBNRCat"); // SpecificIBNRCat + NonSpecificIBNRCat
				UltimateCat = SettCcySet.AddSettCcySets(IncurredCat, IBNRCat, "UltimateCat"); // IncurredCat + IBNRCat

				// CALCULATIONS - Large
				PaidLarge = Actuals.PaidLarge; // PaidExLFLarge  + LFLarge
				IncurredLarge = Actuals.IncurredLarge; // PaidLarge + OSLarge
				SpecificIBNRLarge = SettCcySet.SubtractSettCcySets(SpecificUltimateClaimsLarge, SpecificIncurredClaimsLarge, "SpecificIBNRLarge"); // from specifics
				NonSpecificIBNRLarge = SettCcySet.ScaleSettCcySet(NonSpecificIBNR, NonSpecificIBNRLargeSplit, "NonSpecificIBNRLarge"); // NonSpecificIBNR * NonSpecificIBNRLargeSplit
				IBNRLarge = SettCcySet.AddSettCcySets(SpecificIBNRLarge, NonSpecificIBNRLarge, "IBNRLarge"); // SpecificIBNRLarge + NonSpecificIBNRLarge
				UltimateLarge = SettCcySet.AddSettCcySets(IncurredLarge, IBNRLarge, "UltimateLarge"); // IncurredLarge + IBNRLarge

				// CALCULATIONS - Attritional
				PaidAttr = Actuals.PaidAttr; // PaidExLFAttr + LFAttr
				IncurredAttr = Actuals.IncurredAttr; // PaidAttr + OSAttr
				IBNRAttr = SettCcySet.ScaleSettCcySet(NonSpecificIBNR, NonSpecificIBNRAttritionalSplit, "IBNRAttr"); // NonSpecificIBNR * NonSpecificIBNRAttrSplit
				UltimateAttr = SettCcySet.AddSettCcySets(IncurredAttr, IBNRAttr, "UltimateAttr"); // IncurredAttr + IBNRAttr ** OR ** TotalUltimateClaims - Incurred - IBNRLarge - IBNRCat

				EarnedClaims = SettCcySet.AddSettCcySets(Actuals.IncurredTotal, SpecificIBNR, "");
				EarnedCatClaims = SettCcySet.AddSettCcySets(Actuals.IncurredCat, SpecificIBNRCat, "");
				EarnedLargeClaims = SettCcySet.AddSettCcySets(Actuals.IncurredLarge, SpecificIBNRLarge, "");

				// LOSS RATIOS
				GGILR = Actuals.GGSP.TotalValueInGBP != 0 ? Actuals.IncurredTotal.TotalValueInGBP / Actuals.GGSP.TotalValueInGBP : 0; // Incurred / GGAP
				GNILR = Actuals.GNSP.TotalValueInGBP != 0 ? Actuals.IncurredTotal.TotalValueInGBP / Actuals.GNSP.TotalValueInGBP : 0; // Incurred / GNAP
				GGULR = UltimateGGWP.TotalValueInGBP != 0 ? TotalUltimateClaims.TotalValueInGBP / UltimateGGWP.TotalValueInGBP : 0; // Ultimate Claims / Ultimate Premium
				GNULR = UltimateGNWP.TotalValueInGBP != 0 ? TotalUltimateClaims.TotalValueInGBP / UltimateGNWP.TotalValueInGBP : 0; ; // Ultimate Claims / Ultimate Premium
				GGELR = EarnedGGWP.TotalValueInGBP != 0 ? EarnedClaims.TotalValueInGBP / EarnedGGWP.TotalValueInGBP : 0; // (Incurred + Specific IBNR) / GGEP
				GNELR = EarnedGNWP.TotalValueInGBP != 0 ? EarnedClaims.TotalValueInGBP / EarnedGNWP.TotalValueInGBP : 0; // (Incurred + Specific IBNR) / GNEP




				// UPDATE ALL SPLITS
				UltimateGGWPSetValue.UpdateSplits();
				NCBPCSwingSetValue.UpdateSplits();
				InwardsRIPsSetValue.UpdateSplits();

				// Calculated fields
				UltimateGGWP.UpdateSplits();
				UltimateGNWP.UpdateSplits();
				UnwrittenGGWP.UpdateSplits();
				SpecificUltimateClaims.UpdateSplits();
				SpecificUltimateRIPs.UpdateSplits();

				// Specific Losses
				foreach (var specificLoss in SpecificLosses)
				{
					specificLoss.UpdateCalcs();
				}
			}
		}

		// Deep copy the model (Assumes SelectionsModel is serializable)
		public static SelectionsModel? CloneModel(SelectionsModel original)
		{
			// Use serialization to perform a deep copy
			var json = JsonSerializer.Serialize(original);
			return JsonSerializer.Deserialize<SelectionsModel>(json);
		}

		// Compare two models
		public static SelectionsModel CalculateDifference(SelectionsModel comparator, SelectionsModel baseline)
		{
			var diffModel = new SelectionsModel
			{
				ReservingHeaderID = baseline.ReservingHeaderID,
				Class = baseline.Class,
				ReservingClass = baseline.ReservingClass,
				YOA = baseline.YOA
			};

			// Get the type of the model
			Type modelType = typeof(SelectionsModel);

			// Loop through each property
			foreach (var property in modelType.GetProperties())
			{
				// Check if the property is of type SettCcySet and is not one of the identifiers (like ReservingHeaderID, Class, etc.)
				if (property.PropertyType == typeof(SettCcySet) && property.CanWrite)
				{
					var comparatorValue = property.GetValue(comparator) as SettCcySet;
					var baselineValue = property.GetValue(baseline) as SettCcySet;
					var diffValue = SettCcySet.SubtractSettCcySets(comparatorValue, baselineValue, "Diff value");
					property.SetValue(diffModel, diffValue);
				}
				// Check if the property is of type double and is not one of the identifiers
				else if (property.PropertyType == typeof(double) && property.CanWrite)
				{
					var comparatorValue = (double)property.GetValue(comparator);
					var baselineValue = (double)property.GetValue(baseline);
					var diffValue = comparatorValue - baselineValue;
					property.SetValue(diffModel, diffValue);
				}
			}

			return diffModel;
		}

		public static SelectionsModel AddModels(SelectionsModel model1, SelectionsModel model2)
		{
			var sumModel = new SelectionsModel
			{
				ReservingHeaderID = model1.ReservingHeaderID,  // Assuming we're using model1's IDs as reference
				Class = model1.Class,
				ReservingClass = model1.ReservingClass,
				YOA = model1.YOA
			};

			// Get the type of the model
			Type modelType = typeof(SelectionsModel);

			// Loop through each property
			foreach (var property in modelType.GetProperties())
			{
				// Check if the property is of type SettCcySet and is not one of the identifiers (like ReservingHeaderID, Class, etc.)
				if (property.PropertyType == typeof(SettCcySet) && property.CanWrite)
				{
					var model1Value = property.GetValue(model1) as SettCcySet;
					var model2Value = property.GetValue(model2) as SettCcySet;
					var sumValue = SettCcySet.AddSettCcySets(model1Value, model2Value, "Sum value");
					property.SetValue(sumModel, sumValue);
				}
				// Check if the property is of type double and is not one of the identifiers
				else if (property.PropertyType == typeof(double) && property.CanWrite)
				{
					var model1Value = (double)property.GetValue(model1);
					var model2Value = (double)property.GetValue(model2);
					var sumValue = model1Value + model2Value;
					property.SetValue(sumModel, sumValue);
				}
			}

			return sumModel;
		}

	}
}