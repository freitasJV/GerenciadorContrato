using System;
using System.Globalization;

namespace GerenciadorContrato.Entities
{
    class Parcela
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime date, double amount)
        {
            Data = date;
            Valor = amount;
        }

        public override string ToString()
        {
            return $"{Data.ToString("dd/MM/yyyy")} - {Valor.ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
}
