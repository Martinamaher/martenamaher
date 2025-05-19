using Microsoft.EntityFrameworkCore;
using EyeGlassesApplication.Models;  // تأكد من إضافة الـ Models المناسبة هنا

namespace EyeGlassesApplication.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{ }

		// DbSets للموديلات المختلفة
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdminRole> AdminRoles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<FrameCompany> FrameCompanies { get; set; }
		public DbSet<LenseCompany> LenseCompanies { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Order_Details> Order_Details { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Inventory> Inventories { get; set; }
		public DbSet<Discount> Discounts { get; set; }

		// أي DbSets إضافية يمكن إضافتها هنا
	}
}