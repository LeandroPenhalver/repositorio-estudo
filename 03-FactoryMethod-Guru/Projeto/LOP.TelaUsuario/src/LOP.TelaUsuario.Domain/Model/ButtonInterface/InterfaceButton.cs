using LOP.TelaUsuario.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.TelaUsuario.Domain.Model.ButtonInterface
{
    public abstract class InterfaceButton : Entity
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }
    }
}
