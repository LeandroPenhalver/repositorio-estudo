using AbstractFactory.Creators;
using AbstractFactory.Entidades;
using AbstractFactory.FabricaAbstrata;
using AbstractFactory.ProdutoConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FabricaConcreta
{
    public class AmericaFactory : ContinenteFactory
    {
        public override CarnivoroAbstract CreateCarnivoro()
        {
            return CarnivoroCreator.Create(Type.ContinenteType.America);
        }

        public override HerbivoroAbstract CreateHerbivoro()
        {
            return HerbivoroCreator.Create(Type.ContinenteType.America);
        }
    }
}
