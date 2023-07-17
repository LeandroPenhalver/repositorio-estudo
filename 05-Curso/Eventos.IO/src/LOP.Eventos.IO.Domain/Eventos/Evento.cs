using FluentValidation;
using LOP.Eventos.IO.Domain.Core.Models;
using LOP.Eventos.IO.Domain.Organizadores;

namespace LOP.Eventos.IO.Domain.Eventos
{
    public class Evento : Entity<Evento>
    {
        public Evento(
            string nome,
            DateTime dataInicio,
            DateTime dataFim,
            bool gratuito,
            decimal valor,
            bool online,
            string nomeEmpresa)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Gratuito = gratuito;
            Valor = valor;
            Online = online;
            NomeEmpresa = nomeEmpresa;

            Validar();
        }

        private Evento()
        {

        }

        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public ICollection<Tags> Tags { get; private set; }
        public Guid? CategoriaId { get; set; }
        public Guid? EnderecoId { get; set; }
        public Guid OrganizadorId { get; set; }

        // EF propriedades de navegação
        public virtual Categoria Categoria { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public virtual Organizador Organizador { get; private set; }

        public void AtribuirEndereco(Endereco endereco)
        {
            if (Online) return;

            if (!endereco.ValidationResult.IsValid)
            {
                foreach (var error in endereco.ValidationResult.Errors)
                {
                    ValidationResult.Errors.Add(error);

                    return;
                }
            }

            Endereco = endereco;
        }

        public void AtribuirCategoria(Categoria categoria)
        {
            if(!categoria.ValidationResult.IsValid)
            {
                foreach (var error in categoria.ValidationResult.Errors)
                {
                    ValidationResult.Errors.Add(error);
                }

                return;
            }

            Categoria = categoria;
        }

        public void ExcluirEvento()
        {
            // TODO: 
        }

        #region Validações
        /// <summary>
        /// A condição para o Fluent Validation (para gerar a mensagem de erro) só é apresentado
        /// quando o valor for falso, ou seja, temos a regra .NotEmpty para o campo nome, só
        /// será apresentado a mensagem se essa condição for false.
        /// </summary>
        protected override void Validar()
        {
            ValidarNome();
            ValidarValor();
            ValidarData();
            ValidarEndereco();
            ValidarNomeEmpresa();

            ValidationResult = Validate(this);
        }

        private void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O nome não pode ser vazio")
                .Length(2, 150)
                .WithMessage("O nome precisa ter entre 2 a 150 caracteres");
        }

        private void ValidarValor()
        {
            RuleFor(c => c.Valor)
                .InclusiveBetween(1, 50000)
                .When(c => !c.Gratuito)
                .WithMessage("O valor deve estar entre R$1,00 a R$50.000,00 quando o eventos não for gratuíto");

            RuleFor(c => c.Valor)
                .InclusiveBetween(0, 0)
                .When(c => c.Gratuito)
                .WithMessage("Se o evento é gratuído não pode conter valor");
        }

        private void ValidarData()
        {
            RuleFor(c => c.DataInicio)
                .LessThan(c => c.DataFim)
                .WithMessage("A data final do evento deve terminar depois da data inicial");

            RuleFor(c => c.DataInicio)
                .GreaterThan(DateTime.Now)
                .WithMessage("A data de inicial do evento não pode começar antes da data atual");

            RuleFor(c => c.DataInicio)
                .NotEqual(c => c.DataFim)
                .WithMessage("A data final do evento não pode ser igual a data de início do mesmo");
        }

        private void ValidarEndereco()
        {
            RuleFor(c => c.Endereco)
                .NotNull()
                .When(c => !c.Online)
                .WithMessage("O evento deve possuir um endereço físico quando não for um evento online")
                .Null()
                .When(c => c.Online)
                .WithMessage("Quando o evento for online não deve possuir um endereço físico");
        }

        private void ValidarNomeEmpresa()
        {
            RuleFor(c => c.NomeEmpresa)
                .NotEmpty()
                .WithMessage("O nome da empresa não pode ser vazio")
                .Length(2, 150)
                .WithMessage("O nome da empresa precisa ter entre 2 a 150 caracteres");
        }

        #endregion

        public static class EventoFactory
        {
            public static Evento NovoEventoCompleto(Guid id, string nome, string descricaoCurta, string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa, Guid? organizadorId, Endereco endereco, Categoria categoria)
            {
                var evento = new Evento()
                {
                    Id = id,
                    Nome = nome,
                    DescricaoCurta = descricaoCurta,
                    DescricaoLonga = descricaoLonga,
                    DataInicio = dataInicio,
                    DataFim = dataFim,
                    Gratuito = gratuito,
                    Valor = valor,
                    Online = online,
                    NomeEmpresa = nomeEmpresa,
                    Endereco = endereco,
                    Categoria = categoria
                };

                evento.Validar();

                if (organizadorId != null)
                    evento.Organizador = new Organizador(organizadorId.Value);

                if (evento.Online)
                    evento.Endereco = null;

                return evento;
            }
        }
    }
}
