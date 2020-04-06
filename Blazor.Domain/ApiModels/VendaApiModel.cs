using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.ViewModel;
using Domain.Converters;
using Domain.Entities;
using Newtonsoft.Json;

namespace Domain.ApiModels
{
    public class VendaApiModel : VendaViewModel, IConvertModel<VendaApiModel, Venda>
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override int VendaId { get; set; }

        public Venda Convert() => new Venda
        {
            VendaId = VendaId,
            NumeroNotaFiscal = NumeroNotaFiscal,
            DataNF = DataNF,
            NomeCliente = NomeCliente,
            ValorVenda = ValorVenda,
            ValorCompra = ValorCompra,
            PercentualImposto = PercentualImposto,
            ValorFrete1 = ValorFrete1,
            ValorFrete2 = ValorFrete2,
            PercentualCustoOperacional = PercentualCustoOperacional,
            ValorOutrasDespesas = ValorOutrasDespesas,
            ValorCustoTotal = ValorCustoTotal,
            PercentualComissao = PercentualComissao,
            ValorComissao = ValorComissao,
            PercentualLucro = PercentualLucro,
            ValorLucro = ValorLucro,
            Descricao = Descricao
        };
    }
}