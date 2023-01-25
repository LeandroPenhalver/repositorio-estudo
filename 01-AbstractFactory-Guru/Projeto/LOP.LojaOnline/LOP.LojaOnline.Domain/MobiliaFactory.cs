using LOP.LojaOnline.Domain.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Domain
{
    public abstract class MobiliaFactory
    {
        public abstract CadeiraAbstract CriarCadeira(MobiliaType mobiliaType);
        public abstract MesaCentroAbstract CriarMesaCentro(MobiliaType mobiliaType);
        public abstract SofaAbstract CriarSofa(MobiliaType mobiliaType);
    }
}
