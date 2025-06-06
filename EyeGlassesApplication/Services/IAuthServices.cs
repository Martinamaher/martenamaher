using EyeGlassesApplication.Models;
using System.Threading.Tasks;

namespace EyeGlassesApplication.Services
{
	public interface IAuthService
	{
		Task<string> LoginAsync(string email, string password);

		Task<(bool IsSuccess, string Message)> RegisterUserDtoAsync(RegisterUserDto registerUserDto);
	}
}