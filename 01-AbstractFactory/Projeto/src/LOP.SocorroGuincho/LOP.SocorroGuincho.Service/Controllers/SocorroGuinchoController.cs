using LOP.GuinchoSocorro.Domain;
using LOP.GuinchoSocorro.Domain.AbstractFactory;
using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct.ConcreteProduct.GuinchoProduct;
using LOP.GuinchoSocorro.Domain.AbstractFactory.Creator;
using LOP.SocorroGuincho.Service.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOP.SocorroGuincho.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocorroGuinchoController : ControllerBase
    {
        [Route("SocorrerCarro")]
        [HttpPost]
        public string SocorrerCarro([FromForm] SocorreCarroDTO socorro)
        {
            var veiculo = VeiculoCreator.Criar(socorro.Modelo, socorro.Porte);

            return AutoSocorro.CriarAutoSocorro(veiculo).RealizarSocorro();
        }
    }
}
