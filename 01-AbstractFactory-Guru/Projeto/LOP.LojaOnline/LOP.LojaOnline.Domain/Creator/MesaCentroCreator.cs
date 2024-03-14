using LOP.LojaOnline.Domain.AbstractProduct;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.ArteDeco;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.Moderno;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.Vitoriano;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Domain.Creator
{
    public class MesaCentroCreator
    {
        public static MesaCentroAbstract CriarMesaCentro(MobiliaType mobiliaType)
        {
            switch (mobiliaType)
            {
                case MobiliaType.ArtDeco:
                    return new MesaCentroArteDeco(mobiliaType);
                case MobiliaType.Vitoriano:
                    return new MesaCentroVitoriano(mobiliaType);
                case MobiliaType.Moderno:
                    return new MesaCentroModerno(mobiliaType);
                default:
                    throw new NotImplementedException("Tipo de Mesa de centro não existe.");
            }
        }
    }
}
