using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EyeGlassesApplication.Models
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }

		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		[Required]
		[MaxLength(150)]
		public string Email { get; set; }

		[Required]
		[MaxLength(255)]
		public string Password { get; set; }

		[Required]
		[MaxLength(20)]
		public string PhoneNumber { get; set; }

		[Required]
		public DateTime DateOfBirth { get; set; }

		public DateTime DateCreated { get; set; }

		[Required]
		public bool IsActive { get; set; }

		// العلاقة مع المدفوعات
		public ICollection<Payment> Payments { get; set; } = new List<Payment>();

		// علاقة Many-to-Many مع AdminRole من خلال جدول AdminAdminRole
		public ICollection<AdminAdminRole> AdminAdminRoles { get; set; }

		public Admin()
		{
			DateCreated = DateTime.Now;
			IsActive = true;
			AdminAdminRoles = new List<AdminAdminRole>();
		}
	}
}