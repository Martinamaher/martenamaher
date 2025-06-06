using EyeGlassesApplication.Data;
using EyeGlassesApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EyeGlassesApplication.Services
{
	public class AuthService : IAuthService
	{
		private readonly ApplicationDbContext _context;
		private readonly IConfiguration _configuration;

		public AuthService(ApplicationDbContext context, IConfiguration configuration)
		{
			_context = context;
			_configuration = configuration;
		}

		public async Task<(bool IsSuccess, string Message)> RegisterUserDtoAsync(RegisterUserDto dto)
		{
			if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
				return (false, "Email is already registered.");

			if (await _context.Users.AnyAsync(u => u.UserName == dto.UserName))
				return (false, "Username is already taken.");

			var user = new User
			{
				UserName = dto.UserName,
				Email = dto.Email,
				Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
				Register_Date = DateTime.Now,
				IsActive = true
			};

			_context.Users.Add(user);
			await _context.SaveChangesAsync();

			return (true, "User registered successfully.");
		}

		public async Task<string> LoginAsync(string email, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

			if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
				return null;

			return GenerateJwtToken(user);
		}

		private string GenerateJwtToken(User user)
		{
			var claims = new[]
			{
				new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
				new Claim(ClaimTypes.Email, user.Email),
				new Claim(ClaimTypes.Name, user.UserName),
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				issuer: _configuration["JwtSettings:Issuer"],
				audience: _configuration["JwtSettings:Audience"],
				claims: claims,
				expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["JwtSettings:DurationInMinutes"])),
				signingCredentials: creds
			);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
