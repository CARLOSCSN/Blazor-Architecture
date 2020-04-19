using Common.ViewModel;
using FluentValidation;
using System;

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
                //.OnFailure(x => x.DataNF = DateTime.Now);

            RuleFor(p => p.NomeCliente)
                .NotEmpty()
                .WithMessage("Campo Obrigatório")
                .MinimumLength(5)
                .WithMessage("Nome deve ter um minimo de 5 caracteres")
                .MaximumLength(70)
                .WithMessage("Nome deve ter um minimo de 70 caracteres");

            RuleFor(p => p.ValorVendaString)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");

            RuleFor(p => p.ValorCompraString)
                .NotEmpty()
                .WithMessage("Campo Obrigatório");

            RuleFor(p => p.PercentualImposto);
                //.LessThan(101)
                //.WithMessage("Valor Inválido")
                //.GreaterThan(-1)
                //.WithMessage("Valor Inválido");

            RuleFor(p => p.ValorFrete1String);

            RuleFor(p => p.ValorFrete2String);

            RuleFor(p => p.PercentualCustoOperacional);
                //.LessThan(101)
                //.WithMessage("Valor Inválido")
                //.GreaterThan(-1)
                //.WithMessage("Valor Inválido");

            RuleFor(p => p.ValorOutrasDespesasString);

            RuleFor(p => p.ValorCustoTotalString);

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
