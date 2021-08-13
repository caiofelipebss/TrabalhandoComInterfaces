using System;
using System.Globalization;
using Interface_02.Entities;
using Interface_02.Services;

namespace Interface_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");
            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o número de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contract meuContrato = new Contract(numeroContrato, dataContrato, valorContrato);

            ServicoContrato servicoContrato = new ServicoContrato(new Paypal());
            servicoContrato.ContratoProcessado(meuContrato, meses);

            Console.WriteLine("Installments:");
            foreach (ParcelaContrato parcelaContrato in meuContrato.ParcelaContratos)
            {
                Console.WriteLine(parcelaContrato);
            }
        }
    }
}
