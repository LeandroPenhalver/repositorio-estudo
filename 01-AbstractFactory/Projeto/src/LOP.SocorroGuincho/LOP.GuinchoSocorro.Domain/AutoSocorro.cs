using LOP.GuinchoSocorro.Domain.AbstractFactory;
using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.ConcretFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain
{
    public class AutoSocorro
    {
        private readonly GuinchoAbstract _guincho;
        private readonly VeiculoAbstract _veiculo;
        public AutoSocorro(AutoSocorroFactory factory, VeiculoAbstract veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public string RealizarSocorro()
        {
            return _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(VeiculoAbstract veiculo)
        {
            switch (veiculo.Porte)
            {
                case Type.Porte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequeno(), veiculo);
                case Type.Porte.Medio:
                    return new AutoSocorro(new SocorroVeiculoMedio(), veiculo);
                case Type.Porte.Grande:
                    return new AutoSocorro(new SocorroVeiculoGrande(), veiculo);
                default:
                    throw new NotImplementedException("Não existente");
            }
        }
    }
}
