using LOP.Eventos.IO.Domain.Core.Models;

namespace LOP.Eventos.IO.Domain.Eventos
{
    public class Categoria : Entity<Categoria>
    {
        public string Nome { get; private set; }

        public Categoria(Guid id)
        {
            Id = id;

            Validar();
        }
        // EF Propriedade de navegação
        public virtual ICollection<EventArgs> Events { get; private set; }

        // Construtor para o EF
        protected Categoria(){}
        protected override void Validar()
        {
            ValidationResult = Validate(this);
        }
    }
}