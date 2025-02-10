using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Sandbox.Models.Windowpane
{
    public class WindowpaneViewXModel
    {
        [Key]
        public string? ID { get; set; }
    }
}