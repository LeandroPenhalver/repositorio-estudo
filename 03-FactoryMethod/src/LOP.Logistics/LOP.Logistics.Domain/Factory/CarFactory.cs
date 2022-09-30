using LOP.Logistics.Domain.Factory.Abstract;
using LOP.Logistics.Domain.Product;
using LOP.Logistics.Domain.Product.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Logistics.Domain.Factory
{
    public class CarFactory : TransportadorFactory
    {
        public override Transport CreateTransport()
        {
            return new Car();
        }
    }
}
