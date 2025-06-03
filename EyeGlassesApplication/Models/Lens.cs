using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	public class Lens
	{
		[Key]
		public int LensID { get; set; }

		[Required]
		[MaxLength(100)]
		public string LensType { get; set; }  // مثال: Single Vision, Progressive

		[Required]
		[MaxLength(100)]
		public string Material { get; set; }  // مثال: Polycarbonate, Glass

		[Required]
		public decimal Price { get; set; }

		[Required]
		public int LenseCompanyID { get; set; }

		// العلاقة مع LenseCompany
		[ForeignKey("LenseCompanyID")]
		public LenseCompany LenseCompany { get; set; }

		public DateTime DateAdded { get; set; }

		public Lens()
		{
			DateAdded = DateTime.Now;
		}
	}
}
