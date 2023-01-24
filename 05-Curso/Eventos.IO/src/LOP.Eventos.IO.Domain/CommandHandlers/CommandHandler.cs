using FluentValidation.Results;
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

        public CommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                Console.WriteLine($"{erro.ErrorMessage}; {erro.ErrorCode};");
            }
        }

        protected bool Commit()
        {
            var commandResponse = _unitOfWork.Commit();

            if (commandResponse.Successs) 
                return true;

            Console.WriteLine("Ocorreu um erro ao tentar salvar os dados no banco de dados");
            return false;
        }
    }
}
