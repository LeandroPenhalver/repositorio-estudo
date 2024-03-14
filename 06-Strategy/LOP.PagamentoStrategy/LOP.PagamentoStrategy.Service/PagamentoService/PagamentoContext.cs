using LOP.PagamentoStrategy.Domain.Interface.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.PagamentoStrategy.Service.PagamentoService
{
    public class PagamentoContext
    {
        private readonly IPagamentoStrategy _pagamento;

        public PagamentoContext(IPagamentoStrategy pagamento)
        {
            _pagamento = pagamento;
        }

        public bool EfetuarPagamento(Guid numeroConta)
        {
            return _pagamento.EfetuarPagamento(numeroConta);
        }
    }
}
