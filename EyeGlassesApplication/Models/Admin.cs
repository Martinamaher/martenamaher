using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EyeGlassesApplication.Models
{
	public class Admin
	{
		// المعرف الفريد للمسؤول
		[Key]
		public int AdminID { get; set; }

		// اسم المسؤول
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		// لقب المسؤول
		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		// البريد الإلكتروني للمسؤول
		[Required]
		[MaxLength(150)]
		public string Email { get; set; }

		// كلمة المرور
		[Required]
		[MaxLength(255)]
		public string Password { get; set; }

		// رقم الهاتف
		[Required]
		[MaxLength(20)]
		public string PhoneNumber { get; set; }

		// تاريخ الميلاد
		[Required]
		public DateTime DateOfBirth { get; set; }

		// تاريخ الإنشاء
		public DateTime DateCreated { get; set; }

		// حالة النشاط (مفعل أو غير مفعل)
		[Required]
		public bool IsActive { get; set; }

		// خاصية المدفوعات - تعيينها كمجموعة فارغة في البداية
		public ICollection<Payment> Payments { get; set; } = new List<Payment>();

		// الخاصية الخاصة بعلاقة العديد إلى العديد مع AdminRole
		public ICollection<AdminRole> AdminRoles { get; set; }

		// منشئ لضبط القيم الافتراضية
		public Admin()
		{
			// تهيئة القيمة الافتراضية لتاريخ الإنشاء
			DateCreated = DateTime.Now;
			IsActive = true;  // افتراضياً، يكون الحساب مفعل عند الإنشاء
		}
	}
}
