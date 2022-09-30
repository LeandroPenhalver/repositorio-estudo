using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.VeiculoProduct
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class VeiculoMedio : VeiculoAbstract
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
