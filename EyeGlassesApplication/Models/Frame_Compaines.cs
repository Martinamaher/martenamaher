using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class FrameCompany
{
	[Key]
	public int FrameCompanyID { get; set; }

	[Required]
	[MaxLength(150)]
	public string CompanyName { get; set; }

	[Required]
	[MaxLength(255)]
	public string Address { get; set; }

	[Required]
	[MaxLength(100)]
	public string ContactPerson { get; set; }

	[Required]
	[MaxLength(20)]
	public string PhoneNumber { get; set; }

	[Required]
	[MaxLength(150)]
	public string Email { get; set; }

	public DateTime DateCreated { get; set; }

	[Required]
	public bool IsActive { get; set; }

	// Navigation Property: Relationship with Frames
	public ICollection<FrameCompany> Frame_Compaines { get; set; }

	// Constructor to set default values
	public FrameCompany()
	{
		DateCreated = DateTime.Now;
		IsActive = true;  // Default to active when created
	}
}
