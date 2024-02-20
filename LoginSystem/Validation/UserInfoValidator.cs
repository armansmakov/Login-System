using FluentValidation;
using LoginSystem.Models.Entities;


namespace LoginSystem.Validation
{
    public class UserInfoValidator : AbstractValidator<UserInfo>
    {
        public UserInfoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
        }
    }
}
