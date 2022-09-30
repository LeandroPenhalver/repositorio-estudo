using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.Creator;
using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.ConcretFactory
{
    /// <summary>
    /// Classe Concreta da fabrica
    /// </summary>
    internal class SocorroVeiculoGrande : AutoSocorroFactory
    {
        public override GuinchoAbstract CriarGuincho()
        {
            return GuinchoCreator.Criar(Porte.Grande);
        }

        public override VeiculoAbstract CriarVeiculo(string modelo, Porte tipoAutomovel)
        {
            return VeiculoCreator.Criar(modelo, tipoAutomovel);
        }
    }
}
