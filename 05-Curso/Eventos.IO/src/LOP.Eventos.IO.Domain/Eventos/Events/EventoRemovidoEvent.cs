using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Events
{
    public class EventoRemovidoEvent : BaseEventoEvent
    {
        public EventoRemovidoEvent(Guid id)
        {
            Id = id;

            AggregateId = id;
        }
    }
}
