using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.Creator;
using LOP.GuinchoSocorro.Domain.Type;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.ConcretFactory
{
    /// <summary>
    /// Classe Concreta da fabrica
    /// </summary>
    public class SocorroVeiculoPequeno : AutoSocorroFactory
    {
        public override GuinchoAbstract CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Pequeno);
        }

        public override VeiculoAbstract CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Criar(modelo, porte);
        }
    }
}
