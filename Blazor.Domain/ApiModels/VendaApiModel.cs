﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Converters;
using Domain.Entities;
using Newtonsoft.Json;

namespace Domain.ApiModels
{
    public class VendaApiModel : IConvertModel<VendaApiModel, Venda>
    {

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VendaId { get; set; }

        public string NumeroNotaFiscal { get; set; }

        public DateTime DataNF { get; set; }

        public string NomeCliente { get; set; }

        public decimal ValorVenda { get; set; }

        public decimal ValorCompra { get; set; }

        public double PercentualImposto { get; set; }

        public decimal ValorFrete1 { get; set; }

        public decimal ValorFrete2 { get; set; }

        public double PercentualCustoOperacional { get; set; }

        public decimal ValorOutrasDespesas { get; set; }

        public decimal ValorCustoTotal { get; set; }

        public double PercentualComissao { get; set; }

        public decimal ValorComissao { get; set; }

        public double PercentualLucro { get; set; }

        public decimal ValorLucro { get; set; }

        public string Descricao { get; set; }

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