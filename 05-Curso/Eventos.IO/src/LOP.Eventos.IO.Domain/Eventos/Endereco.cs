using FluentValidation;
using LOP.Eventos.IO.Domain.Core.Models;

namespace LOP.Eventos.IO.Domain.Eventos
{
    public class Endereco : Entity<Endereco>
    {
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public Guid? EventoId { get; private set; }

        // EF Propriedades de navegação
        public virtual Evento Evento { get; private set; }

        // Construtor para o EF
        protected Endereco(){ }

        public Endereco(Guid id, string logradouro, string numero, string complemento, string bairro, string cep, string cidade, string estado, Guid? eventoId)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Estado = estado;
            EventoId = eventoId;
            Cidade = cidade;
        }

        public override bool EhValido()
        {
            ValidarLogradouro();
            ValidarNumero();
            ValidarBairro();
            ValidarCEP();
            ValidarCidade();
            ValidarEstado();

            ValidationResult = Validate(this);

            return ValidationResult.IsValid;
        }

        #region Validações
        private void ValidarEstado()
        {
            RuleFor(x => x.Estado)
                .NotEmpty().WithMessage("O Estado precisa ser fornecido.")
                .Length(2, 150).WithMessage("O Estado precisa ter entre 2 a 150 caracteres.");
        }

        private void ValidarCidade()
        {
            RuleFor(x => x.Cidade)
                .NotEmpty().WithMessage("A Cidade precisa ser fornecido.")
                .Length(2, 150).WithMessage("A Cidade precisa ter entre 2 a 150 caracteres.");
        }

        private void ValidarCEP()
        {
            RuleFor(x => x.CEP)
                .NotEmpty().WithMessage("O CEP precisa ser fornecido.")
                .Length(8).WithMessage("O CEP precisa ter 8 caracteres.");
        }

        private void ValidarBairro()
        {
            RuleFor(x => x.Bairro)
                .NotEmpty().WithMessage("O Bairro precisa ser fornecido.")
                .Length(2, 150).WithMessage("O Bairro precisa ter entre 2 a 150 caracteres.");
        }

        private void ValidarNumero()
        {
            RuleFor(x => x.Numero)
                .NotEmpty().WithMessage("O Número deve ser preenchido.")
                .Length(1, 10).WithMessage("O Número precisa ter entre 1 a 10 caracteres.");
        }

        private void ValidarLogradouro()
        {
            RuleFor(x => x.Logradouro)
                .NotEmpty().WithMessage("O Logradouro precisa ser fornecido.")
                .Length(2, 150).WithMessage("O Logradouro precisa ter entre 2 a 150 caracteres.");
        }

        #endregion
    }
}