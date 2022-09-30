using AbstractFactory.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FabricaAbstrata
{
    public abstract class ContinenteFactory
    {
        public abstract CarnivoroAbstract CreateCarnivoro();
        public abstract HerbivoroAbstract CreateHerbivoro();
    }
}
