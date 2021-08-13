using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_02.Services
{
    class Paypal : IServicoPagamentoOnline
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JurosMensais = 0.01;

        public double Juros(double quantia, int meses)
        {
            return quantia * JurosMensais * meses;
        }

        public double TaxaPagamento(double quantia)
        {
            return quantia * PorcentagemTaxa;
        }
    }
}
