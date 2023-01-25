using LOP.LojaOnline.Domain.AbstractProduct;
using LOP.LojaOnline.Domain.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Domain.ConcreteFactory
{
    public class MobiliaVitoriano : MobiliaFactory
    {
        public override CadeiraAbstract CriarCadeira(MobiliaType mobiliaType)
        {
            return CadeiraCreator.CriarCadeira(mobiliaType);
        }

        public override MesaCentroAbstract CriarMesaCentro(MobiliaType mobiliaType)
        {
            return MesaCentroCreator.CriarMesaCentro(mobiliaType);
        }

        public override SofaAbstract CriarSofa(MobiliaType mobiliaType)
        {
            return SofaCreator.CriarSofa(mobiliaType);
        }
    }
}
