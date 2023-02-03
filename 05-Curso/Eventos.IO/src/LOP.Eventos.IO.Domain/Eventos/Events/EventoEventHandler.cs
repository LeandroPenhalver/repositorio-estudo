using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Events
{
    /// <summary>
    /// Então está classe de evento pode ser persistido no banco para ter um histórico,
    /// pode enviar email quando foi alterado o evento caso seja dados sensíveis,
    /// pode ser usado como log
    /// 
    /// Enfim esse vai ser os logs de alteração, inclusão ou remoção de um evento
    /// sem essa classe os dados podem ser persistidos mas não terão histórico ou 
    /// algum controle de persistência, apenas serão feito as persistências
    /// da forma que muitas aplicações são feitas hoje.
    /// </summary>

    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoRemovidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento registrado com sucesso");
        }

        public void Handle(EventoRemovidoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento atualizado com sucesso");
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Evento removido com sucesso");
        }
    }
}
