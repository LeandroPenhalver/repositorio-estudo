using LOP.Eventos.IO.Domain.Core.Models;

namespace LOP.Eventos.IO.Domain.Organizadores
{
    public class Organizador : Entity<Organizador>
    {
        public Organizador(Guid id)
        {
            Id = id;
        }

        protected override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}