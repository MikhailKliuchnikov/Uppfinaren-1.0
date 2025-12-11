using System;

namespace Uppfinaren_1._0.Models.Data;

public class InMemoryInventorRepository : IInventorRepository
{
    private readonly List<Inventor> _inventors = new List<Inventor>();
    private int _nextId = 1;

    public void Add(Inventor inventor)
    {
        inventor.Id = _nextId++;
        _inventors.Add(inventor);
    }

    public Inventor? GetById(int id)
    {
        return _inventors.FirstOrDefault(i => i.Id == id);
    }

    public IEnumerable<Inventor> GetAll()
    {
        return _inventors;
    }
    public void InitializInventors(IEnumerable<Inventor> initialInventors)
    {
        foreach (var inventor in initialInventors)
        {
            Add(inventor);
        }
    }
}
