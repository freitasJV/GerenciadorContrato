namespace GerenciadorContrato.Services
{
    class PayPalService : IPagamentoService
    {
        private const double TaxaDePagamento = 0.02;
        private const double JurosMes = 0.01;

        public double Juros(double valor, int meses)
        {
            return valor * JurosMes * meses;
        }

        public double Pagamento(double valor)
        {
            return valor * TaxaDePagamento;
        }
    }
}
