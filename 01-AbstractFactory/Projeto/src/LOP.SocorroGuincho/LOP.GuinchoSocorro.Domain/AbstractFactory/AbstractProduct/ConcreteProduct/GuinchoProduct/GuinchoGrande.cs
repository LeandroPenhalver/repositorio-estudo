using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.GuinchoProduct
{
    public class GuinchoGrande : GuinchoAbstract
    {
        public GuinchoGrande(Porte porte) : base(porte)
        {
        }
    }
}
