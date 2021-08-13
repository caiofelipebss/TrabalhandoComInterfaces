using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_02.Services
{
    interface IServicoPagamentoOnline
    {
        double TaxaPagamento(double quantia);
        double Juros(double quantia, int meses);
    }
}
