using LOP.Eventos.IO.Domain.Core.Models;

namespace LOP.Eventos.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }

        public Categoria(Guid id)
        {
            Id = id;
        }
        // EF Propriedade de navegação
        public virtual ICollection<EventArgs> Eventos { get; private set; }

        // Construtor para o EF
        protected Categoria(){}
        public override bool EhValido()
        {
            return true;
        }
    }
}