using LOP.Eventos.IO.Domain.Core.Bus;
using LOP.Eventos.IO.Domain.Core.Commands;
using LOP.Eventos.IO.Domain.Core.Events;
using LOP.Eventos.IO.Domain.Core.Notifications;
using LOP.Eventos.IO.Domain.Eventos.Commands;
using LOP.Eventos.IO.Domain.Eventos.Events;

internal class FakeBus : IBus
{
    public void RaiseEvent<T>(T theEvent) where T : Event
    {
        Publish(theEvent);
    }

    public void SendCommand<T>(T theCommand) where T : Command
    {
        Publish(theCommand);   
    }

    private static void Publish<T>(T message) where T : Message
    {
        var messageType = message.MessageType;

        if (messageType.Equals("DomainNotification"))
        {
            var notificaiton = new DomainNotificationHandler();
            ((IDomainNotificationHandler<T>)notificaiton).Handle(message);
        }

        if (messageType.Equals("RegistrarEventoCommand") ||
            messageType.Equals("AtualizarEventoCommand") ||
            messageType.Equals("RemoverEventoCommand") )
        {
            var obj = new EventoCommandHandler(new FakeRepository(), new FakeIUnitOfWork(), new FakeBus(), new DomainNotificationHandler());

            ((IHandler<T>)obj).Handle(message);
        }

        if (messageType.Equals("EventoRegistradoEvent") ||
            messageType.Equals("EventoAtualizadoEvent") ||
            messageType.Equals("EventoRemovidoEvent"))
        {
            var obj = new EventoEventHandler();

            ((IHandler<T>)obj).Handle(message);
        }
    }
}
