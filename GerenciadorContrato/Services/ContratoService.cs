using GerenciadorContrato.Entities;
using System;

namespace GerenciadorContrato.Services
{
    class ContratoService
    {
        private IPagamentoService _pagamentoService;

        public ContratoService(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double valorParcela = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valorPacelaAtualizado = valorParcela + _pagamentoService.Juros(valorParcela, i);
                double valorTotal = valorPacelaAtualizado + _pagamentoService.Pagamento(valorPacelaAtualizado);
                contrato.AddParcela(new Parcela(data, valorTotal));
            }
        }
    }
}
