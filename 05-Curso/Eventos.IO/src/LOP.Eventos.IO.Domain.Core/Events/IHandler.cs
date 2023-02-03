using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Core.Events
{
    // utilizando o IN para o T (genérico) estou querendo dizer que ele pode ser um tipo
    // menos derivado ainda atualizarcommand : basecommand : message.
    public interface IHandler<in T> where T : Message
    {
        void Handle(T message);
    }
}
