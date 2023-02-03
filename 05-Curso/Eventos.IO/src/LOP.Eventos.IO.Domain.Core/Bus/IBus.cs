using LOP.Eventos.IO.Domain.Core.Commands;
using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Core.Bus
{
    /// <summary>
    /// Essa interfac vai servir para o envio de comandos ou eventos
    /// Assim torna-se mais centralizado a manipulação dos comandos e eventos.
    /// </summary>
    public interface IBus
    {
        /// <summary>
        /// Comando são enviados.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="theCommand"></param>
        void SendCommand<T>(T theCommand) where T : Command;

        /// <summary>
        /// Eventos são disparado
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="theEvent"></param>
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
