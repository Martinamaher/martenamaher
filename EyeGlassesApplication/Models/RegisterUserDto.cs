using System.ComponentModel.DataAnnotations;

public class RegisterUserDto
{
	[Required]
	public string UserName { get; set; }

	[Required]
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	[MinLength(6)]
	public string Password { get; set; }

	[Required]
	[Compare("Password", ErrorMessage = "Passwords do not match.")]
	public string ConfirmPassword { get; set; }
}