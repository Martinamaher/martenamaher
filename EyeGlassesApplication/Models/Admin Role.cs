using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EyeGlassesApplication.Models
{
	public class AdminRole
	{
		[Key]
		public int AdminRoleID { get; set; }

		[Required]
		[StringLength(50)]
		public string RoleName { get; set; }

		[StringLength(255)]
		public string Description { get; set; }

		// علاقة Many-to-Many مع Admin من خلال جدول AdminAdminRole
		public ICollection<AdminAdminRole> AdminAdminRoles { get; set; }

		public AdminRole()
		{
			AdminAdminRoles = new List<AdminAdminRole>();
		}
	}
}