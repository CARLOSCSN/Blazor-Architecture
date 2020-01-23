﻿using System;

namespace Common.ViewModel
{
    public class VendaViewModel
    {
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

    }
}