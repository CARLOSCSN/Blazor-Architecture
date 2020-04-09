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

            RuleFor(p => p.ValorCompra)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");

            RuleFor(p => p.PercentualImposto);
                //.LessThan(101)
                //.WithMessage("Valor Inválido")
                //.GreaterThan(-1)
                //.WithMessage("Valor Inválido");

            RuleFor(p => p.ValorFrete1)
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.ValorFrete2)
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.PercentualCustoOperacional);
                //.LessThan(101)
                //.WithMessage("Valor Inválido")
                //.GreaterThan(-1)
                //.WithMessage("Valor Inválido");

            RuleFor(p => p.ValorOutrasDespesas)
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.ValorCustoTotal)
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.PercentualComissao)
                .LessThan(101)
                .WithMessage("Valor Inválido")
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.ValorComissao)
                .GreaterThan(-1)
                .WithMessage("Valor Inválido");

            RuleFor(p => p.PercentualLucro);
                //.NotEmpty()
                //.WithMessage("Campo Obrigatório")
                //.LessThan(101)
                //.WithMessage("Valor Inválido")
                //.GreaterThan(-1)
                //.WithMessage("Valor Inválido");

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");
        }
    }
}
