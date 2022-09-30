using LOP.GuinchoSocorro.Domain.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.GuinchoSocorro.Domain.AbstractFactory.AbstractProduct
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public abstract class VeiculoAbstract
    {
        public Porte Porte { get; set; }

        public string Modelo { get; set; }

        public VeiculoAbstract(string modelo, Porte porte)
        {
            Porte = porte;
            Modelo = modelo;
        }
    }
}
