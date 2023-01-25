using LOP.LojaOnline.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LOP.LojaOnline.Service
{
    public class Inicializador
    {
        public Inicializador()
        {
            Iniciar();
        }

        private void Iniciar()
        {
            var repetirOperacao = false;

            Console.WriteLine("Seja bem vindo a nossa loja");

            do
            {
                var conjuntoMobilia = PegarConjuntoMobilia(ChamarMenu());

                Console.WriteLine($"O conjunto escolhido foi Cadeira: {conjuntoMobilia.Cadeira.TipoMobilia}, Mesa de Centro: {conjuntoMobilia.MesaCentro.TipoMobilia}, Sofa: {conjuntoMobilia.Sofa.TipoMobilia}");

                Console.WriteLine("Deseja Repetir a operação? (S/N)");

                var retornoResposta = Console.ReadLine();

                if (retornoResposta.ToUpper() == "S")
                    repetirOperacao = true;
                else
                    repetirOperacao = false;

            } while (repetirOperacao);

            Console.WriteLine("Obrigado pelo contato e volte sempre!!");
        }

        private ConjuntoMobiliaDTO PegarConjuntoMobilia(string tipoMobiliaResposta)
        {
            if (tipoMobiliaResposta == "01" || tipoMobiliaResposta == "1")
                return new ConjuntoMobiliaDTO(Domain.MobiliaType.Vitoriano);
            if (tipoMobiliaResposta == "02" || tipoMobiliaResposta == "2")
                return new ConjuntoMobiliaDTO(Domain.MobiliaType.Moderno);
            if (tipoMobiliaResposta == "03" || tipoMobiliaResposta == "3")
                return new ConjuntoMobiliaDTO(Domain.MobiliaType.ArtDeco);

            throw new NotImplementedException("Você não escolheu uma opção aceitavel");
            
        }

        private string ChamarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha o tipo de conjunto para sua sala que deseja comprar");
            Console.WriteLine("Temos três tipos de conjunto para decorar sua sala");
            Console.WriteLine("01 - Vitoriano");
            Console.WriteLine("02 - Moderno");
            Console.WriteLine("03 - ArteDeco");

            Console.Write("Responder:");
            return Console.ReadLine();
        }
    }
}
