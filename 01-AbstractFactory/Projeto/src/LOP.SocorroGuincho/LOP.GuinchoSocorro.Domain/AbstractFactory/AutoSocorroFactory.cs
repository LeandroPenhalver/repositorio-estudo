using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.Type;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory
{
    /// <summary>
    /// AbstractFactory
    /// </summary>
    public abstract class AutoSocorroFactory
    {
        /// <summary>
        /// Cria uma instância de guincho
        /// </summary>
        /// <returns></returns>
        public abstract GuinchoAbstract CriarGuincho();
        
        /// <summary>
        /// Cria uma instância de automovel
        /// </summary>
        /// <param name="modelo">Modelo do carro que está sendo criado</param>
        /// <param name="tipoAutomovel">Tipo do carro que será criado (Pequeno, Médio, Grande)</param>
        /// <returns></returns>
        public abstract VeiculoAbstract CriarVeiculo(string modelo, Porte tipoAutomovel);
    }
}
