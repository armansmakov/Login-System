using FluentValidation;
using PetProject.Models.Entities;


namespace PetProject.Validation
{
    public class UserInfoValidator : AbstractValidator<UserInfo>
    {
        public UserInfoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty
        }
    }
}
