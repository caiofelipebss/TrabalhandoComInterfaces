using System;
using System.Globalization;

namespace Interface_02.Entities
{
    class ParcelaContrato
    {
        public DateTime VencimentoContrato { get; set; }
        public double Quantia { get; set; }

        public ParcelaContrato(DateTime vencimentoContrato, double quantia)
        {
            VencimentoContrato = vencimentoContrato;
            Quantia = quantia;
        }

        public override string ToString()
        {
            return VencimentoContrato.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
