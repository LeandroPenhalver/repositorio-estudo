using AbstractFactory;
using AbstractFactory.FabricaAbstrata;
using AbstractFactory.FabricaConcreta;
using System;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var animaisAfricanos = new AnimaisMundo(new AfricaFactory());
        }
    }
}
