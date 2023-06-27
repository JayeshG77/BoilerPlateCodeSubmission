using Microsoft.AspNetCore.Identity;

namespace Session5.Model
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
