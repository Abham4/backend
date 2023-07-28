using Microsoft.AspNetCore.Identity;
namespace firstnet.Domain
{
    public class UserModel:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}