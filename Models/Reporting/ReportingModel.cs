using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Collections.Generic;

namespace Sandbox.Models.Reporting
{

	public class ReportingModel
    {
        public string ItemID { get; set; }
        public string ReportName { get; set; }
        public string SSRSPath { get; set; }
        public string URL { get; set; }
        public string Category { get; set; }
        public string FutureState { get; set; }
        public string Notes { get; set; }
		public string PrimaryUser { get; set; }
		public string LastRunBy { get; set; }
		public int RunsInLastMonth { get; set; }
        public int RunsInLastYear { get; set; }
        public int YourRunsInLastYear { get; set; }
        public int YourRunsInLastMonth { get; set; }
        public DateTime? LastRunByYou { get; set; }
    }
}