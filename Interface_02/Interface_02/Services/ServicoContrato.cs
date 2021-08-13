using System;
using System.Collections.Generic;
using System.Text;
using Interface_02.Entities;

namespace Interface_02.Services
{
    class ServicoContrato
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ContratoProcessado(Contract contract, int meses)
        {
            double cotaBasica = contract.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime dataContrato = contract.DataContrato.AddMonths(i);
                double atualizaCota = cotaBasica + _servicoPagamentoOnline.Juros(cotaBasica, i);
                double cotaCheia = atualizaCota + _servicoPagamentoOnline.TaxaPagamento(atualizaCota);
                contract.AddParcelaContrato(new ParcelaContrato(dataContrato, cotaCheia));
            }
        }
    }
}
