using ConsoleTesting;
using LOP.Eventos.IO.Domain.Core.Events;
using LOP.Eventos.IO.Domain.Core.Models;
using LOP.Eventos.IO.Domain.Eventos;
using LOP.Eventos.IO.Domain.Eventos.Commands;
using System.Runtime.CompilerServices;

var bus = new FakeBus();

// Registro com sucesso.
var evento = new RegistrarEventoCommand("Teste Criação Evento", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0, true, "LOP");

InterfaceConsole.Inicio(evento);
bus.SendCommand(evento);
InterfaceConsole.Fim(evento);

// Registro com falha.
evento = new RegistrarEventoCommand("T", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 150, true, "T");

InterfaceConsole.Inicio(evento);
bus.SendCommand(evento);
InterfaceConsole.Fim(evento);

// Atualizar com sucesso.
var evento2 = new AtualizarEventoCommand(Guid.NewGuid(), "TTeste Criação Evento", "Teste", "Este é o teste maior", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), true, 0, true, "LOP");

InterfaceConsole.Inicio(evento2);
bus.SendCommand(evento2);
InterfaceConsole.Fim(evento2);

// Atualizar com falha.
var evento3 = new AtualizarEventoCommand(Guid.NewGuid(), "T", "", "", DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-2), true, 150, true, "T");

InterfaceConsole.Inicio(evento3);
bus.SendCommand(evento3);
InterfaceConsole.Fim(evento3);

// Remover com falha.
var evento4 = new RemoverEventoCommand(Guid.Empty);

InterfaceConsole.Inicio(evento4);
bus.SendCommand(evento4);
InterfaceConsole.Fim(evento4);

// Remover com sucesso.
var evento5 = new RemoverEventoCommand(Guid.NewGuid());

InterfaceConsole.Inicio(evento5);
bus.SendCommand(evento5);
InterfaceConsole.Fim(evento5);


Console.ReadKey();

