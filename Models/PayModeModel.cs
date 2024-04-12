using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
	internal class PayModeModel
	{
		[DisplayName("Pay mode Id")]
		public int Id { get; set; }

		[DisplayName("Pay mode Name")]
		[Required(ErrorMessage = "Pay mode name is required")]
		[StringLength(200, MinimumLength = 3, ErrorMessage = "Pay mode observation must be between 3 and 200 characters")]
		public string? Name { get; set; }

		public string? Observation { get; set; }	
	}
}
