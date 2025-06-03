using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EyeGlassesApplication.Models;
namespace EyeGlassesApplication.Models
{
	public class LenseCompany
	{
		[Key]
		public int LenseCompanyID { get; set; }

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

		// Navigation Property: علاقة بالشركة - العدسات
		public ICollection<Lens> Lenses { get; set; }

		// Constructor to set default values
		public LenseCompany()
		{
			DateCreated = DateTime.Now;
			IsActive = true;
			Lenses = new List<Lens>();
		}
	}
}