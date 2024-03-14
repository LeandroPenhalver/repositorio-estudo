using LOP.LojaOnline.Domain.AbstractProduct;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.ArteDeco;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.Moderno;
using LOP.LojaOnline.Domain.AbstractProduct.ConcreteProduct.Vitoriano;

namespace LOP.LojaOnline.Domain.Creator
{
    public class SofaCreator
    {
        public static SofaAbstract CriarSofa(MobiliaType mobiliaType)
        {
            switch (mobiliaType)
            {
                case MobiliaType.ArtDeco:
                    return new SofaArteDeco(mobiliaType);
                case MobiliaType.Vitoriano:
                    return new SofaVitoriano(mobiliaType);
                case MobiliaType.Moderno:
                    return new SofaModerno(mobiliaType);
                default:
                    throw new NotImplementedException("O tipo de sofa não existe.");
            }
        }
    }
}
