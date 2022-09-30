using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public abstract class GuinchoAbstract
    {
        public Porte Porte { get; set; }
        protected GuinchoAbstract(Porte porte)
        {
            Porte = porte;
        }

        public virtual string Socorrer(VeiculoAbstract veiculo)
        {
            return $"Socorrendo {veiculo.Modelo} porte {veiculo.Porte}";
        }
    }
}
