using FluentValidation;
using TIBAutomation.InputParameter;

namespace TIBAutomation.InputParameterValidator
{
    public class SignInInputValidator : AbstractValidator<SignInInput>
    {
        public SignInInputValidator()
        {
            RuleFor(model => model.UserName).NotEmpty();
            RuleFor(model => model.Password).NotEmpty();
        }
    }
}
