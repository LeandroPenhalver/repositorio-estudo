using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Domain.AbstractProduct.Base
{
    public abstract class MobiliaEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public MobiliaType TipoMobilia { get; set; }
    }
}
