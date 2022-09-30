using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Commands
{
    public class RemoverEventoCommand : BaseEventoCommand
    {
        public RemoverEventoCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }
    }
}
