using LOP.Eventos.IO.Domain.CommandHandlers;
using LOP.Eventos.IO.Domain.Core.Events;
using LOP.Eventos.IO.Domain.Eventos.Commands;
using LOP.Eventos.IO.Domain.Eventos.Repository;
using LOP.Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.CommandHandlers
{
    public class EventoCommandHandler :
        CommandHandler
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<RemoverEventoCommand>
    {
        private readonly IEventoRepository _repository;

        public EventoCommandHandler(
            IEventoRepository repository,
            IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = repository;
        }

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = new Evento(message.Nome, message.DataInicio, message.DataFim, message.Gratuito, message.Valor, message.Online, message.NomeEmpresa);


            // Classe se auto validando.
            if (!evento.ValidationResult.IsValid)
            {
                NotificarValidacoesErro(evento.ValidationResult);
                return;
            }

            // Validações de negócio para saber se irá persistir os dados no banco.

            _repository.Add(evento);
        }

        public void Handle(RemoverEventoCommand message)
        {
            throw new NotImplementedException();    
        }

        public void Handle(AtualizarEventoCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
