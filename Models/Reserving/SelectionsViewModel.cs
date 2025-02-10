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
	public class SelectionsViewModel
	{
		public SelectionsModel RsvClassYOAModel {  get; set; }
		public SelectionsModel ClassYOAModel { get; set; }
		public SelectionsModel YOAModel { get; set; }
	}
}