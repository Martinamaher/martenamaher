using EyeGlassesApplication.Models;
using System.ComponentModel.DataAnnotations;

public class AdminRole
{
	[Key]
	public int AdminRoleID { get; set; }

	[Required]
	[MaxLength(50)]
	public string RoleName { get; set; }

	[MaxLength(255)]
	public string Description { get; set; }

	// Navigation Property: Relationship with Admin
	public ICollection<Admin> Admins { get; set; }

	// Constructor to set default values
	public AdminRole()
	{
		Admins = new List<Admin>();  // Initialize the collection of Admins
	}
}
