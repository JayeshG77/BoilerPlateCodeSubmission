using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Session5.DTOs;
using Session5.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Session5.Repository
{
    public class AuthManager:IAuthManager
    {
        readonly UserManager<User> _userManager;
        readonly IMapper _mapper;
        readonly IConfiguration _configuration;

        public AuthManager(UserManager<User> userManager, IMapper mapper, IConfiguration configuration)
        {
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<AuthResponseDto> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            bool isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);

            if (user == null || isValidUser == false)
            {
                return null;
            }
            var token = await GenrateToken(user);

            return new AuthResponseDto
            {
                Token = token,
                UserId = user.Id
            };
        }

        private async Task<string> GenrateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSetting:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            //roles for specified users
            var roles = await _userManager.GetRolesAsync(user);
            //get List of roles
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            //get already specified in database claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            //claims ->user information you want to pass with the token
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Email),
                //genrate new id everytime use Jti,Guid.Newguid() method
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Id)
            }
            .Union(userClaims).Union(roleClaims);

            //genrate token-write your token
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSetting:Issuer"],
                audience: _configuration["JwtSetting:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt64(_configuration["JwtSetting:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    

        public async Task<IEnumerable<IdentityError>> RegisterUserAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.UserName = userDto.Email;
            var result = await _userManager.CreateAsync(user, userDto.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }
            return result.Errors; 
        }

       
    }
}
