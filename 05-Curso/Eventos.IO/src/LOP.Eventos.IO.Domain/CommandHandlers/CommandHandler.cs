using FluentValidation.Results;
using LOP.Eventos.IO.Domain.Core.Bus;
using LOP.Eventos.IO.Domain.Core.Notifications;
using LOP.Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.CommandHandlers
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        public CommandHandler(IUnitOfWork unitOfWork, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _unitOfWork = unitOfWork;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(erro.PropertyName, erro.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            if (_notifications.HasNotifications()) return false;

            var commandResponse = _unitOfWork.Commit();

            if (commandResponse.Success)
                return true;

            Console.WriteLine("Ocorreu um erro ao tentar salvar os dados no banco de dados");
            _bus.RaiseEvent(new DomainNotification("Commit()", "Ocorreu um erro ao tentar salvar os dados no banco de dados"));
            return false;
        }
    }
}
