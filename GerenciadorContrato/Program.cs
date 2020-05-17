using GerenciadorContrato.Entities;
using GerenciadorContrato.Services;
using System;
using System.Globalization;

namespace GerenciadorContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato");
            Console.Write("Número: ");
            int ContratoNumber = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime ContratoDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double ContratoValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contrato myContract = new Contrato(ContratoNumber, ContratoDate, ContratoValue);

            ContratoService contratoService = new ContratoService(new PayPalService());
            contratoService.ProcessarContrato(myContract, months);

            Console.WriteLine("Parcelas:");
            foreach (Parcela installment in myContract.Parcelas)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
