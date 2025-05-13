using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review
{
	[Key]
	public int ReviewID { get; set; }

	[Required]
	[ForeignKey("Product")]
	public int ProductID { get; set; }

	[Required]
	[ForeignKey("User")]
	public int UserID { get; set; }

	[Required]
	[Range(1, 5)] // تقييم من 1 إلى 5
	public int Rating { get; set; }

	[MaxLength(1000)]
	public string Comment { get; set; }

	public DateTime ReviewDate { get; set; }

	// Navigation properties
	public Product Product { get; set; }
	public User User { get; set; }

	public Review()
	{
		ReviewDate = DateTime.Now;
	}
}