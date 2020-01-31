using Common.ViewModel;
using FluentValidation;

namespace Common.Validation
{
    public class VendaValidator : AbstractValidator<VendaViewModel>
    {
        public VendaValidator()
        {
            RuleFor(p => p.NomeCliente).NotEmpty().WithMessage("Campo obrigatório");
            //RuleFor(p => p.Summary).MaximumLength(50).WithMessage("Name cannot be longer than 50 characters");
        }
    }
}
