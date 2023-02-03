using LOP.Eventos.IO.Domain.Eventos;
using LOP.Eventos.IO.Domain.Eventos.Repository;
using System.Linq.Expressions;

public class FakeRepository : IEventoRepository
{
    public void Add(Evento entity)
    {
        //throw new NotImplementedException();
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
    }

    public IEnumerable<Evento> Find(Expression<Func<Evento, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Evento> GetAll()
    {
        throw new NotImplementedException();
    }

    public Evento GetById(Guid id)
    {
        return new Evento("Evento Fake", DateTime.Now, DateTime.Now, true, 0, true, "LOP");
    }

    public void Remove(Guid id)
    {
        //
    }

    public int SaveChanges()
    {
        throw new NotImplementedException();
    }

    public void Update(Evento entity)
    {
        //
    }
}