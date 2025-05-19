namespace EyeGlassesApplication.Services
{
	public interface IAuthService
	{
		Task<string> LoginAsync(string email, string password);
	}
}
