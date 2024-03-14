using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.PagamentoStrategy.Domain.Interface.Strategy
{
    public interface IPagamentoStrategy
    {
        bool EfetuarPagamento(Guid numeroConta);
    }
}
