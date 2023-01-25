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
    public class CadeiraCreator
    {
        public static CadeiraAbstract CriarCadeira(MobiliaType mobiliaType)
        {
            switch (mobiliaType)
            {
                case MobiliaType.ArtDeco:
                    return new CadeiraArteDeco(mobiliaType);
                case MobiliaType.Vitoriano:
                    return new CadeiraVitoriano(mobiliaType);
                case MobiliaType.Moderno:
                    return new CadeiraModerno(mobiliaType);
                default:
                    throw new NotImplementedException("O tipo de cadeira não existe.");
            }
        }
    }
}
