using LOP.PagamentoStrategy.Domain.ConcreteStrategy;
using LOP.PagamentoStrategy.Service.PagamentoService;

Console.WriteLine("Estudo do padrão Strategy");
Console.WriteLine("Digite qualquer coisa para continuar");
Console.Read();

var debito = new PagamentoContext(new DebitoPagamentoStrategy());
Console.WriteLine($@"Status do pagamento: {debito.EfetuarPagamento(Guid.NewGuid()) == true: ""Concluído"" ? ""Erro no pagamento""}");

var pix = new PagamentoContext(new PixPagamentoStrategy());
Console.WriteLine($@"Status do pagamento: {pix.EfetuarPagamento(Guid.NewGuid()) == true: ""Concluído"" ? ""Erro no pagamento""}");

Console.Read();