using System;
using System.ComponentModel.DataAnnotations;

namespace EyeGlassesApplication.Models
{
	public class User
	{
		[Key]
		public int ID { get; set; }  // يتطابق مع العمود ID في قاعدة البيانات

		[Required]
		[MaxLength(20)]
		public string F_Name { get; set; }  // الاسم الأول

		[Required]
		[MaxLength(20)]
		public string L_Name { get; set; }  // الاسم الأخير

		[Required]
		[MaxLength(100)]
		public string Password { get; set; }  // كلمة المرور (يفضل تشفيرها عند التخزين)

		[Required]
		[MaxLength(20)]
		public string Phone { get; set; }  // رقم الهاتف

		[Required]
		[MaxLength(200)]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }  // البريد الإلكتروني

		public string Address { get; set; }  // العنوان (نص طويل)

		[Required]
		public DateTime Register_Date { get; set; } = DateTime.Now;  // تاريخ التسجيل (قيمة افتراضية اليوم)

		[Required]
		public bool IsActive { get; set; } = true;  // حالة التفعيل (افتراضيًا مفعل)

		// يمكنك إضافة خواص ملاحية هنا لو أردت الربط مع جداول أخرى مثل الطلبات مثلاً.
	}
}