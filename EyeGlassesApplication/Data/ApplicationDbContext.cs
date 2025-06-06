using Microsoft.EntityFrameworkCore;
using EyeGlassesApplication.Models;

namespace EyeGlassesApplication.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdminRole> AdminRoles { get; set; }
		public DbSet<AdminAdminRole> AdminAdminRoles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Order_Details> OrderDetails { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Inventory> Inventories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Discount> Discounts { get; set; }
		public DbSet<LenseCompany> LenseCompanies { get; set; }
		public DbSet<Lens> Lenses { get; set; }
		public DbSet<FrameCompany> FrameCompanies { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// علاقة Many-to-Many بين Admin و AdminRole
			modelBuilder.Entity<AdminAdminRole>()
				.HasKey(ar => new { ar.AdminID, ar.AdminRoleID });

			modelBuilder.Entity<AdminAdminRole>()
				.HasOne(ar => ar.Admin)
				.WithMany(a => a.AdminAdminRoles)
				.HasForeignKey(ar => ar.AdminID);

			modelBuilder.Entity<AdminAdminRole>()
				.HasOne(ar => ar.AdminRole)
				.WithMany(r => r.AdminAdminRoles)
				.HasForeignKey(ar => ar.AdminRoleID);

			// دقة الحقول المالية
			modelBuilder.Entity<Lens>()
				.Property(l => l.Price)
				.HasPrecision(18, 2);

			modelBuilder.Entity<Discount>()
				.Property(d => d.DiscountPercentage)
				.HasPrecision(5, 2);

			modelBuilder.Entity<Product>()
				.Property(p => p.Price)
				.HasPrecision(18, 2);

			// منع multiple cascade paths بين Product و Admin
			modelBuilder.Entity<Product>()
				.HasOne(p => p.CreatedBy)
				.WithMany()
				.HasForeignKey(p => p.CreatedByAdmin)
				.OnDelete(DeleteBehavior.Restrict); // ⛔ منع الحذف التلقائي

			modelBuilder.Entity<Product>()
				.HasOne(p => p.UpdatedBy)
				.WithMany()
				.HasForeignKey(p => p.UpdatedByAdmin)
				.OnDelete(DeleteBehavior.Restrict); // ⛔ منع الحذف التلقائي
		}
	}
}