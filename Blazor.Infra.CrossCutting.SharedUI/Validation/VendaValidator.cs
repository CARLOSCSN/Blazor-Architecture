using Common.ViewModel;
using FluentValidation;

namespace Common.Validation
{
    public class VendaValidator : AbstractValidator<VendaViewModel>
    {
        public VendaValidator()
        {
            RuleFor(p => p.NumeroNotaFiscal)
                .NotEmpty()
                .WithMessage("Campo obrigatório")
                .Matches(@"^\d{4}$")
                .WithMessage("Nota Fiscal deve ter 4 caracteres numericos");
        }
    }
}
