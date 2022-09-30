using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.GuinchoProduct;
using LOP.GuinchoSocorro.Domain.Type;
using System;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.Creator
{
    /// <summary>
    /// Only creator
    /// </summary>
    public class GuinchoCreator
    {
        public static GuinchoAbstract Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);
                case Porte.Medio:
                    return new GuinchoMedio(porte);
                case Porte.Grande:
                    return new GuinchoGrande(porte);
                default:
                    throw new NotImplementedException("Guincho não implementado");
            }
        }
    }
}
