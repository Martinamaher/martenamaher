using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	public class FrameCompany
	{
		[Key]
		public int FrameCompanyID { get; set; }

		[Required]
		[MaxLength(150)]
		public string Name { get; set; }

		[Required]
		[MaxLength(20)]
		public string Phone { get; set; }

		[Required]
		[MaxLength(200)]
		[EmailAddress]
		public string ContactEmail { get; set; }

		[Required]
		[MaxLength(50)]
		public string City { get; set; }

		[Required]
		[MaxLength(50)]
		public string Country { get; set; }

		[Required]
		[MaxLength(50)]
		public string Street { get; set; }

		[Required]
		[MaxLength(30)]
		public string Material { get; set; }  // مادة الإطار مثل: Metal, Plastic

		[Required]
		[MaxLength(30)]
		public string Type { get; set; }  // نوع الإطار: Full-Rim, Half-Rim, Rimless

		[Required]
		[Column(TypeName = "decimal(10,2)")]
		public decimal Price { get; set; }

		// Admin الذي أضاف الشركة (اختياري)
		public int? AddedByAdminID { get; set; }

		[ForeignKey("AddedByAdminID")]
		public Admin AddedByAdminNavigation { get; set; }

		// Navigation Property - العلاقات مع المنتجات لو احتجت لاحقًا
		public ICollection<Product> Products { get; set; }

		// Constructor
		public FrameCompany()
		{
			Products = new List<Product>();
		}
	}
}