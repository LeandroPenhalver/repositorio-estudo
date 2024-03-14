using Eventos.IO.Infra.Data.Context;
using LOP.Eventos.IO.Domain.Core.Commands;
using LOP.Eventos.IO.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.IO.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EventosContext _context;
        public UnitOfWork(EventosContext context)
        {
            _context = context;
        }
        public CommandResponse Commit()
        {
            var rowAffected = _context.SaveChanges();
            return new CommandResponse(rowAffected > 0);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
