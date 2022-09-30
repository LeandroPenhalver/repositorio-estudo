using AbstractFactory.Entidades;
using AbstractFactory.ProdutoConcreto;
using AbstractFactory.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Creators
{
    public class CarnivoroCreator
    {
        public static CarnivoroAbstract Create(ContinenteType type)
        {
            switch (type)
            {
                case ContinenteType.Africa:
                    return new Leao();
                case ContinenteType.America:
                    return new Lobo();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
