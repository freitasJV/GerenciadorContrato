namespace GerenciadorContrato.Services
{
    interface IPagamentoService
    {
        double Pagamento(double valor);
        double Juros(double valor, int meses);
    }
}
