using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	[Table("Products")]
	public class Product
	{
		[Key]
		[Column("id")]
		public int ProductID { get; set; }

		[Required]
		[Column("name")]
		[MaxLength(150)]
		public string ProductName { get; set; }

		[Column("description")]
		public string Description { get; set; }

		[Column("price")]
		public decimal Price { get; set; }

		[Column("stock")]
		public int Stock { get; set; }

		[Column("image_url")]
		public string ImageUrl { get; set; }

		[Required]
		[Column("lense_company_id")]
		public int LenseCompanyId { get; set; }

		[Required]
		[Column("frame_company_id")]
		public int FrameCompanyID { get; set; }

		[Required]
		[Column("created_by_admin")]
		public int CreatedByAdmin { get; set; }

		[Required]
		[Column("updated_by_admin")]
		public int UpdatedByAdmin { get; set; }

		[Column("created_at")]
		public DateTime CreatedAt { get; set; }

		[Column("discount_id")]
		public int? DiscountId { get; set; }

		// Navigation Properties
		[ForeignKey("LenseCompanyId")]
		public LenseCompany LenseCompany { get; set; }

		[ForeignKey("FrameCompanyID")]
		public FrameCompany FrameCompany { get; set; }

		[ForeignKey("CreatedByAdmin")]
		public Admin CreatedBy { get; set; }

		[ForeignKey("UpdatedByAdmin")]
		public Admin UpdatedBy { get; set; }

		[ForeignKey("DiscountId")]
		public Discount Discount { get; set; }
	}
}
