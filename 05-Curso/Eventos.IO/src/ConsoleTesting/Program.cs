using LOP.Eventos.IO.Domain.Core.Models;
using LOP.Eventos.IO.Domain.Eventos;

var teste = new Evento("Novo ConsoleApp", DateTime.Now.AddMinutes(10), DateTime.Now.AddMinutes(40), true, 0, false, "LOP Enterprise");
Console.WriteLine(teste.ToString());
Console.WriteLine(teste.ValidationResult.IsValid);

if (!teste.ValidationResult.IsValid)
{
    foreach (var erro in teste.ValidationResult.Errors)
    {
        Console.WriteLine(erro.ErrorMessage);
    }
}
Console.ReadLine();

