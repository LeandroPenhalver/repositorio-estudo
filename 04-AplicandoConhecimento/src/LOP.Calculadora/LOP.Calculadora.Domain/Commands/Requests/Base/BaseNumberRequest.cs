using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Calculadora.Domain.Commands.Requests.Base
{
    public abstract class BaseNumberRequest
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
    }
}
