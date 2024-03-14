using LOP.PagamentoStrategy.Domain.Interface.Strategy;
using LOP.PagamentoStrategy.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.PagamentoStrategy.Domain.ConcreteStrategy
{
    public class DebitoPagamentoStrategy : IPagamentoStrategy
    {
        public bool EfetuarPagamento(Guid numeroConta)
        {
            #region Simulação de requisição no banco
            var mesAtual = DateTime.Now.Month;
            var diaAtual = DateTime.Now.Day;
            var valorContaSemMulta = 250;

            var conta = new Conta(valorContaSemMulta, numeroConta, mesAtual, diaAtual);
            #endregion

            if (DateTime.Now.Month > conta.MesReferencia)
                conta.SetValorConta(IncluirMulta(conta.ValorConta));

            // Implementação do pagamento boleto
            var retornoPagamento = true;

            return retornoPagamento;
        }

        private double IncluirMulta(double valor)
        {
            return valor * 1.2;
        }
    }
}
