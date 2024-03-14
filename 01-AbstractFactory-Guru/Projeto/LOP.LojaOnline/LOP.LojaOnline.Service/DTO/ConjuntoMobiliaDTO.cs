using LOP.LojaOnline.Domain;
using LOP.LojaOnline.Domain.AbstractProduct;
using LOP.LojaOnline.Domain.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Service.DTO
{
    public class ConjuntoMobiliaDTO
    {
        public CadeiraAbstract Cadeira { get; set; }
        public MesaCentroAbstract MesaCentro { get; set; }
        public SofaAbstract Sofa { get; set; }

        public ConjuntoMobiliaDTO(MobiliaType mobiliaType)
        {
            Cadeira = CadeiraCreator.CriarCadeira(mobiliaType);
            MesaCentro = MesaCentroCreator.CriarMesaCentro(mobiliaType);
            Sofa = SofaCreator.CriarSofa(mobiliaType);
        }
    }
}
