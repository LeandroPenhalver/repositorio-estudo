using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Commands
{
    public class RegistrarEventoCommand : BaseEventoCommand
    {
        public RegistrarEventoCommand(
            string nome,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valor,
            bool online,
            string nomeEmpresa)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;
        }
    }
}
