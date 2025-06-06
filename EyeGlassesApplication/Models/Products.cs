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
		[MaxLength(150)]
		[Column("name")]
		public string ProductName { get; set; }

		[Column("description")]
		public string Description { get; set; }

		[Required]
		[Column("price", TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		[Required]
		[Column("stock")]
		public int Stock { get; set; }

		[Column("image_url")]
		[MaxLength(255)]
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

		[Required]
		[Column("created_at")]
		public DateTime CreatedAt { get; set; } = DateTime.Now;

		[Column("discount_id")]
		public int? DiscountID { get; set; }

		// Navigation Properties

		[ForeignKey(nameof(LenseCompanyId))]
		public LenseCompany LenseCompany { get; set; }

		[ForeignKey(nameof(FrameCompanyID))]
		public FrameCompany FrameCompany { get; set; }

		[ForeignKey(nameof(CreatedByAdmin))]
		public Admin CreatedBy { get; set; }

		[ForeignKey(nameof(UpdatedByAdmin))]
		public Admin UpdatedBy { get; set; }

		[ForeignKey(nameof(DiscountID))]
		public Discount Discount { get; set; }
		public decimal Weight { get; set; }
	}

}
