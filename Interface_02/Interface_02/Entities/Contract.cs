using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_02.Entities
{
    class Contract
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotal { get; set; }       
        public List<ParcelaContrato> ParcelaContratos { get; set; }

        public Contract(int numeroContrato, DateTime dataContrato, double valorTotal)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorTotal = valorTotal;
            ParcelaContratos = new List<ParcelaContrato>();
        }     

        public void AddParcelaContrato(ParcelaContrato parcelaContrato)
        {
            ParcelaContratos.Add(parcelaContrato);
        }
    }
}
