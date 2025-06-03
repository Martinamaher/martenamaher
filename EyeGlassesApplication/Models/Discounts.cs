using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EyeGlassesApplication.Models
{
	public class Discount
	{
		[Key]
		public int DiscountID { get; set; }

		[Required]
		[MaxLength(100)]
		public string DiscountName { get; set; }

		[Required]
		public decimal DiscountPercentage { get; set; }

		[Required]
		public DateTime StartDate { get; set; }

		[Required]
		public DateTime EndDate { get; set; }

		// Navigation property: Products associated with this discount
		public ICollection<Product> Products { get; set; } = new List<Product>();
	}
}