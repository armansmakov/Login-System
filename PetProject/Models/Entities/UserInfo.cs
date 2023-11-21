using Microsoft.AspNetCore.Identity;

namespace PetProject.Models.Entities
{
    public class UserInfo
    {
        public int Id {  get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public int LoginId { get; set; }
        public LoginInfo LoginInfo { get; set; }

        public DateTime Birthday { get; set; }
    }
}
