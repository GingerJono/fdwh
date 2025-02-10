using Sandbox.Models.Windowpane;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Sandbox.Models.Windowpane
{
	public class SearchClaimModel
	{
		public string? SearchString { get; set; }
		public string? ClaimRef { get; set; }
		public string? PolicyRef { get; set; }
		public string? Assured { get; set; }
		public string? UCR { get; set; }
		public string? Class { get; set; }
		public string? ReservingClass { get; set; }
		public string? LossDate { get; set; }
		public string? ClaimStatus { get; set; }
		public string? Narrative { get; set; }
	}


	public class SearchPolicyModel
	{
		public string? SearchString { get; set; }
		public string? PolicyRef { get; set; }
		public string? Assured { get; set; }
		public string? UMR { get; set; }
		public string? Class { get; set; }
		public string? ReservingClass { get; set; }
		public string? InceptionDate { get; set; }
		public string? RiskDescription { get; set; }
        public string? Status { get; set; }
    }
	public class SearchProgramModel
	{
		public string? SearchString { get; set; }
		public string? ProgramRef { get; set; }
		public string? Assured { get; set; }
		public string? Class { get; set; }
		public string? ReservingClass { get; set; }
		public string? InceptionDate { get; set; }
		public string? Status { get; set; }
	}


	public class WindowpaneSearchModel
    {
        public IEnumerable<SearchPolicyModel>? Policies { get; set; }
        public IEnumerable<SearchClaimModel>? Claims { get; set; }
        public IEnumerable<SearchProgramModel>? Programs { get; set; }
    }
}