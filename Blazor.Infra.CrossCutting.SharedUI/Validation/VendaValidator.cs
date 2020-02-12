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
                .WithMessage("Campo Obrigatório")
                .Matches(@"^\d{4}$")
                .WithMessage("Nota Fiscal deve ter 4 caracteres numericos");

            RuleFor(p => p.DataNF)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");

            RuleFor(p => p.NomeCliente)
                .NotEmpty()
                .WithMessage("Campo Obrigatório")
                .MinimumLength(5)
                .WithMessage("Nome deve ter um minimo de 5 caracteres")
                .MaximumLength(70)
                .WithMessage("Nome deve ter um minimo de 70 caracteres");

            RuleFor(p => p.ValorVenda)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");
        }
    }
}
