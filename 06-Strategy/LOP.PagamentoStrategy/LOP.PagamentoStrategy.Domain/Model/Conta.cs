using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LOP.PagamentoStrategy.Domain.Model
{
    public class Conta
    {
        public double ValorConta { get; private set; }
        public Guid NumeroConta { get; private set; }
        public int MesReferencia {  get; private set; }
        public int DiaReferencia { get; private set; }

        public Conta(double valorConta, Guid numeroConta, int mesReferencia, int diaReferencia)
        {
            ValorConta = valorConta;
            NumeroConta = numeroConta;
            MesReferencia = mesReferencia;
            DiaReferencia = diaReferencia;
        }

        public void SetValorConta(double valorConta) 
            => ValorConta = valorConta;
    }
}
