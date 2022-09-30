using LOP.Logistics.Domain.Product;
using LOP.Logistics.Domain.Product.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOP.Logistics.Domain.Factory.Abstract
{
    public abstract class TransportadorFactory
    {
        public abstract Transport CreateTransport();

        public static TransportadorFactory Transport(TransportType transportType)
        {
            switch (transportType)
            {
                case TransportType.Truck:
                    return new TruckFactory();
                case TransportType.Car:
                    return new CarFactory();
                default:
                    throw new ArgumentException("não implementado");
            }
        }
    }
}
