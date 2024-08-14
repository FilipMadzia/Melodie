using Melodie.API.Data.Entities;
using Melodie.API.Dtos.Auth;
using Melodie.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Melodie.API.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class AuthController(
	IConfiguration _configuration,
	UserRepository _userRepository) : ControllerBase
{
	[HttpPost]
	public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
	{
		var userEntity = await _userRepository.GetByEmailAsync(loginDto.Email);

		if (userEntity == null || loginDto.Password != userEntity.Password)
			return Unauthorized();

		var issuer = _configuration["Jwt:Issuer"];
		var audience = _configuration["Jwt:Audience"];
		var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!);
		var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature);

		var subject = new ClaimsIdentity(
		[
			new Claim(JwtRegisteredClaimNames.Email, loginDto.Email)
		]);

		var expires = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["Jwt:ExpiresIn"]!));

		var tokenDescriptor = new SecurityTokenDescriptor
		{
			Subject = subject,
			Expires = expires,
			Issuer = issuer,
			Audience = audience,
			SigningCredentials = signingCredentials
		};

		var tokenHandler = new JwtSecurityTokenHandler();
		var token = tokenHandler.CreateToken(tokenDescriptor);
		var jwtToken = tokenHandler.WriteToken(token);

		return Ok(jwtToken);
	}
	[HttpPost]
	public async Task<IActionResult> Register([FromBody] RegisterDto RegisterDto)
	{
        var existingUser = await _userRepository.GetByEmailAsync(RegisterDto.Email);
        if (existingUser != null)
        {
            return Conflict("User already exist");
        }

        var newUser = new UserEntity
        {
            Email = RegisterDto.Email,
            Password = RegisterDto.Password,
        };

        await _userRepository.AddAsync(newUser);
		return(Ok(newUser));
    }
}