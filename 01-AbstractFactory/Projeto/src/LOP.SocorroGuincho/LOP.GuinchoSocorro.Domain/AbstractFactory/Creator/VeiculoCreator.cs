using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.VeiculoProduct;
using LOP.GuinchoSocorro.Domain.Type;
using System;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.Creator
{
    /// <summary>
    /// Apenas um creator um tipo de uma factory
    /// Desta forma esse código vai ficar encarregado de criar os objetos.
    /// </summary>
    public class VeiculoCreator
    {
        public static VeiculoAbstract Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                default:
                    throw new NotImplementedException("Veiculo não implementado");
            }
        }
    }
}
