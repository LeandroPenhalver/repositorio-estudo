using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.GuinchoProduct
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class GuinchoMedio : GuinchoAbstract
    {
        public GuinchoMedio(Porte porte) : base(porte)
        {
        }
    }
}
