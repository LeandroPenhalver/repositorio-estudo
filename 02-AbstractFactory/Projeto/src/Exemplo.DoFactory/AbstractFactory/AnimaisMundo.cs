using AbstractFactory.Entidades;
using AbstractFactory.FabricaAbstrata;
using AbstractFactory.FabricaConcreta;
using AbstractFactory.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AnimaisMundo
    {
        private readonly HerbivoroAbstract _herbivoro;
        private readonly CarnivoroAbstract _carnivoro;

        public AnimaisMundo(ContinenteFactory continenteFactory)
        {
            _carnivoro = continenteFactory.CreateCarnivoro();
            _herbivoro = continenteFactory.CreateHerbivoro();
        }

        public static AnimaisMundo CriarAnimais(ContinenteType type)
        {
            switch (type)
            {
                case ContinenteType.Africa:
                    return new AnimaisMundo(new AfricaFactory());
                case ContinenteType.America:
                    return new AnimaisMundo(new AmericaFactory());
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
