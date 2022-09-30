using LOP.Logistics.Domain;
using LOP.Logistics.Domain.Factory.Abstract;
using System;

namespace LOP.Logistics.Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var meuTransporte = TransportadorFactory
                .Transport(TransportType.Car)
                .CreateTransport();

            Console.WriteLine(meuTransporte.CarregarEncomenda(5));
            Console.WriteLine(meuTransporte.FazerEntrega("Avenida"));
        }
    }
}
