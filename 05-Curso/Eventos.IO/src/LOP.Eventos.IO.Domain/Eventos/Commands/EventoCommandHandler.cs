using LOP.Eventos.IO.Domain.CommandHandlers;
using LOP.Eventos.IO.Domain.Core.Bus;
using LOP.Eventos.IO.Domain.Core.Events;
using LOP.Eventos.IO.Domain.Core.Notifications;
using LOP.Eventos.IO.Domain.Eventos.Events;
using LOP.Eventos.IO.Domain.Eventos;
using LOP.Eventos.IO.Domain.Eventos.Repository;
using LOP.Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LOP.Eventos.IO.Domain.Eventos.Commands
{
    public class EventoCommandHandler :
        CommandHandler,
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<RemoverEventoCommand>
    {
        private readonly IEventoRepository _repository;
        private readonly IBus _bus;

        public EventoCommandHandler(
            IEventoRepository repository,
            IUnitOfWork unitOfWork,
            IBus bus,
            IDomainNotificationHandler<DomainNotification> notifications) : base(unitOfWork, bus, notifications)
        {
            _repository = repository;
            _bus = bus;
        }

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = Evento.EventoFactory.NovoEventoCompleto(message.Id, message.Nome, message.DescricaoCurta, message.DescricaoLonga, message.DataInicio, message.DataFim, message.Gratuito, message.Valor, message.Online, message.NomeEmpresa, message.OrganizadorId, message.Endereco, message.CategoriaId);

            // Classe se auto validando.
            if (!EventoValido(evento)) return;

            // TODO: 
            // Validações de negócio para saber se irá persistir os dados no banco.
            //   - Aquele organizador pode geristrar aquele evento

            _repository.Adicionar(evento);

            if (Commit())
            {
                Console.WriteLine("Evento salvo com sucesso.");
                _bus.RaiseEvent(new EventoRegistradoEvent(evento.Id, evento.Nome, evento.DataInicio, evento.DataFim, evento.Gratuito, evento.Valor, evento.Online, evento.NomeEmpresa));
            }
        }

        public void Handle(RemoverEventoCommand message)
        {
            if (!EventoExistente(message.Id, message.MessageType)) return;

            _repository.Remover(message.Id);

            if (Commit())
            {
                _bus.RaiseEvent(new EventoRemovidoEvent(message.Id));
            }
        }

        public void Handle(AtualizarEventoCommand message)
        {
            var eventoAtual = _repository.ObterPorId(message.Id);

            if (!EventoExistente(message.Id, message.MessageType)) return;

            // TODO: VALIDAR SE O ENDEREÇO PERTENCE  A PESSOA QUE ESTÁ EDITANDO.

            var evento = Evento.EventoFactory.NovoEventoCompleto(message.Id, message.Nome, message.DescricaoCurta, message.DescricaoLonga, message.DataInicio, message.DataFim, message.Gratuito, message.Valor, message.Online, message.NomeEmpresa, message.OrganizadorId, eventoAtual.Endereco, message.CategoriaId);

            if (!EventoValido(evento)) return;

            _repository.Atualizar(evento);

            if (Commit())
            {
                Console.WriteLine("Evento salvo com sucesso.");
                _bus.RaiseEvent(new EventoAtualizadoEvent(evento.Id, evento.Nome, evento.DescricaoCurta, evento.DescricaoLonga, evento.DataInicio, evento.DataFim, evento.Gratuito, evento.Valor, evento.Online, evento.NomeEmpresa));
            }
        }

        private bool EventoValido(Evento evento)
        {
            if (evento.EhValido()) return true;

            NotificarValidacoesErro(evento.ValidationResult);
            return false;
        }

        private bool EventoExistente(Guid id, string messageType)
        {
            var evento = _repository.ObterPorId(id);

            if (evento is not null) return true;

            _bus.RaiseEvent(new DomainNotification(messageType, "Evento não encontrado."));
            return false;
        }
    }
}
