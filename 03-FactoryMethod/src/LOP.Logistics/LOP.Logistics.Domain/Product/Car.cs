using LOP.Logistics.Domain.Product.Abstract;

namespace LOP.Logistics.Domain.Product
{
    public class Car : Transport
    {
        public override string CarregarEncomenda(int quantidade)
        {
            return $"Carregando {this.GetType()} com {quantidade} de itens para entrega.";
        }

        public override string FazerEntrega(string endereco)
        {
            return $"Iniciando entrega. Endereço {endereco}";
        }
    }
}
