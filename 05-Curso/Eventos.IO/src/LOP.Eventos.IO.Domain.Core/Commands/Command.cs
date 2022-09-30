using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timestamp { get; set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
