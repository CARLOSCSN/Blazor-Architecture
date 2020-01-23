using Common.ViewModel;
using FluentValidation;

namespace Common.Validation
{
    public class VendaValidator : AbstractValidator<VendaViewModel>
    {
        public VendaValidator()
        {
            //RuleFor(p => p.Summary).NotEmpty().WithMessage("You must enter a name");
            //RuleFor(p => p.Summary).MaximumLength(50).WithMessage("Name cannot be longer than 50 characters");
        }
    }
}
