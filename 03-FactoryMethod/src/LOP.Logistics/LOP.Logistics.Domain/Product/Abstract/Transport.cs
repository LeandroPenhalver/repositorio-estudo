namespace LOP.Logistics.Domain.Product.Abstract
{
    public abstract class Transport
    {
        public abstract string CarregarEncomenda(int quantidade);

        public abstract string FazerEntrega(string endereco);
    }
}
