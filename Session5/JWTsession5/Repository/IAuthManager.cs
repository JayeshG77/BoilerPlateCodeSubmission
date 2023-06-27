using Microsoft.AspNetCore.Identity;
using Session5.DTOs;

namespace Session5.Repository
{
    public interface IAuthManager
    {
        public Task<IEnumerable<IdentityError>> RegisterUserAsync(UserDto userDto);
        public Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
