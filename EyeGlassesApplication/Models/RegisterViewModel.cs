using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
	[Required]
	[Display(Name = "اسم المستخدم")]
	public string Username { get; set; }

	[Required]
	[EmailAddress]
	[Display(Name = "البريد الإلكتروني")]
	public string Email { get; set; }

	[Required]
	[DataType(DataType.Password)]
	[Display(Name = "كلمة المرور")]
	public string Password { get; set; }

	[DataType(DataType.Password)]
	[Display(Name = "تأكيد كلمة المرور")]
	[Compare("Password", ErrorMessage = "كلمة المرور وتأكيدها غير متطابقين")]
	public string ConfirmPassword { get; set; }
}
