using System;
using System.ComponentModel.DataAnnotations;

namespace Common.ViewModel
{
    public class VendaViewModel
    {
        public virtual int VendaId { get; set; }

        public string NumeroNotaFiscal { get; set; }

        public DateTime DataNF { get; set; }

        public string NomeCliente { get; set; }

        public decimal ValorVenda { get; set; }

        public decimal ValorCompra { get; set; }

        public decimal PercentualImposto { get; set; }

        public decimal ValorFrete1 { get; set; }

        public decimal ValorFrete2 { get; set; }

        public decimal PercentualCustoOperacional { get; set; }

        public decimal ValorOutrasDespesas { get; set; }

        public decimal ValorCustoTotal { get; set; }

        public decimal PercentualComissao { get; set; }

        public decimal ValorComissao { get; set; }

        public decimal PercentualLucro { get; set; }

        public decimal ValorLucro { get; set; }

        public string Descricao { get; set; }


        /// *** Aux 

        private string _valorVendaString;
        public string ValorVendaString
        {
            get
            {
                return string.Format("{0:C}", ValorVenda);
            }
            set
            {
                _valorVendaString = value;

                decimal.TryParse(_valorVendaString, out var parsedValue);

                // Assign value
                ValorVenda = parsedValue;
            }
        }

        private string _valorCompraString;
        public string ValorCompraString
        {
            get
            {
                return string.Format("{0:C}", ValorCompra);
            }
            set
            {
                _valorCompraString = value;

                decimal.TryParse(_valorCompraString, out var parsedValue);

                // Assign value
                ValorCompra = parsedValue;
            }
        }

        private string _valorFrete1String;
        public string ValorFrete1String
        {
            get
            {
                return string.Format("{0:C}", ValorFrete1);
            }
            set
            {
                _valorFrete1String = value;

                decimal.TryParse(_valorFrete1String, out var parsedValue);

                // Assign value
                ValorFrete1 = parsedValue;
            }
        }

        private string _valorFrete2String;
        public string ValorFrete2String
        {
            get
            {
                return string.Format("{0:C}", ValorFrete2);
            }
            set
            {
                _valorFrete2String = value;

                decimal.TryParse(_valorFrete2String, out var parsedValue);

                // Assign value
                ValorFrete2 = parsedValue;
            }
        }

        private string _valorOutrasDespesasString;
        public string ValorOutrasDespesasString
        {
            get
            {
                return string.Format("{0:C}", ValorOutrasDespesas);
            }
            set
            {
                _valorOutrasDespesasString = value;

                decimal.TryParse(_valorOutrasDespesasString, out var parsedValue);

                // Assign value
                ValorOutrasDespesas = parsedValue;
            }
        }

        private string _valorComissaoString;
        public string ValorComissaoString
        {
            get 
            { 
                return string.Format("{0:C}", ValorComissao);
            }
            set
            {
                _valorComissaoString = value;

                decimal.TryParse(_valorComissaoString, out var parsedValue);

                // Assign value
                ValorComissao = parsedValue;
            }
        }

        private string _valorCustoTotalString;
        public string ValorCustoTotalString
        {
            get
            {
                return string.Format("{0:C}", ValorCustoTotal);
            }
            set
            {
                _valorCustoTotalString = value;

                decimal.TryParse(_valorCustoTotalString, out var parsedValue);

                // Assign value
                ValorCustoTotal = parsedValue;
            }
        }

        private string _valorLucroString;
        public string ValorLucroString
        {
            get
            {
                return string.Format("{0:C}", ValorLucro);
            }
            set
            {
                _valorLucroString = value;

                decimal.TryParse(_valorLucroString, out var parsedValue);

                // Assign value
                ValorLucro = parsedValue;
            }
        }
    }
}
