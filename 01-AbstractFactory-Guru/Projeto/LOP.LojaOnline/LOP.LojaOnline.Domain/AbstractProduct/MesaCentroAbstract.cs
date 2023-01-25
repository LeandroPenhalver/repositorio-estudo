using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOP.LojaOnline.Domain.AbstractProduct.Base;

namespace LOP.LojaOnline.Domain.AbstractProduct
{
    public abstract class MesaCentroAbstract : MobiliaEntity
    {
        public MesaCentroAbstract(MobiliaType mobiliaType)
        {
            TipoMobilia = mobiliaType;
        }
    }
}
