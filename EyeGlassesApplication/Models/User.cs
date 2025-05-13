using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class User
{
	[Key]
	public int UserID { get; set; }

	[Required]
	[MaxLength(100)]
	public string FirstName { get; set; }

	[Required]
	[MaxLength(100)]
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


	// Constructor to set default values
	public User()
	{
		DateCreated = DateTime.Now;
		IsActive = true;  // Default to active when created
	}
}
