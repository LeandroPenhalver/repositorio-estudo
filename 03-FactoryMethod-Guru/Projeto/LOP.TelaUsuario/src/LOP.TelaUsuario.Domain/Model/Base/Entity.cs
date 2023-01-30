using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.TelaUsuario.Domain.Model.Base
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
