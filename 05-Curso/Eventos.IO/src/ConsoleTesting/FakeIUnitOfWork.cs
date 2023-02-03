using LOP.Eventos.IO.Domain.Core.Commands;
using LOP.Eventos.IO.Domain.Interfaces;

public class FakeIUnitOfWork : IUnitOfWork
{
    public CommandResponse Commit()
    {
        return new CommandResponse(true);
    }

    public void Dispose()
    {
        //
    }
}
