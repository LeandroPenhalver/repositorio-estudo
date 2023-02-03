using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Events
{
    // Esse evento só vai dizer para o usuário se foi persistido o registro
    // é o evento de banco.

    // para cada tipo de persistencia existe um event separado.
    public class EventoRegistradoEvent : BaseEventoEvent
    {
        public EventoRegistradoEvent(
           Guid id,
           string nome,
           DateTime dataInicio,
           DateTime dataFim,
           bool gratuito,
           decimal valor,
           bool online,
           string nomeEmpresa)
        {
            Id = id;
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;

            AggregateId = id;
        }
    }
}
