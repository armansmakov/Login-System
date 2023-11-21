using Microsoft.AspNetCore.Identity;

namespace PetProject.Models.Entities
{
    public class LoginInfo
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}
