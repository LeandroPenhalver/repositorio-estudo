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
    public class HerbivoroCreator
    {
        public static HerbivoroAbstract Create(ContinenteType type)
        {
            switch (type)
            {
                case ContinenteType.Africa:
                    return new Gnu();
                case ContinenteType.America:
                    return new Bisao();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
