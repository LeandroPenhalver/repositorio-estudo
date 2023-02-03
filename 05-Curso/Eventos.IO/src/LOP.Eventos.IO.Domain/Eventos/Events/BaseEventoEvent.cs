using LOP.Eventos.IO.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Eventos.IO.Domain.Eventos.Events
{
    public abstract class BaseEventoEvent : Event
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string DescricaoCurta { get; protected set; }
        public string DescricaoLonga { get; protected set; }
        public DateTime DataInicio { get; protected set; }
        public DateTime DataFim { get; protected set; }
        public bool Gratuito { get; protected set; }
        public decimal Valor { get; protected set; }
        public bool Online { get; protected set; }
        public string NomeEmpresa { get; protected set; }
    }
}
