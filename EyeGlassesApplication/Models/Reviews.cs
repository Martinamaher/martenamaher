using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EyeGlassesApplication.Models;

namespace EyeGlassesApplication.Models
{
	public class Review
	{
		[Key]
		public int ReviewID { get; set; }

		[Required]
		[ForeignKey(nameof(Product))]
		public int ProductID { get; set; }

		[Required]
		[ForeignKey(nameof(User))]
		public int UserID { get; set; }

		[Required]
		[Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
		public int Rating { get; set; }

		[MaxLength(1000)]
		public string Comment { get; set; }

		[Required]
		public DateTime ReviewDate { get; set; } = DateTime.Now;

		// Navigation properties
		public Product Product { get; set; }
		public User User { get; set; }
	}
}