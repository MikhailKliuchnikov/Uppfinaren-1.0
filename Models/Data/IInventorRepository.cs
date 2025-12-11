using System;

namespace Uppfinaren_1._0.Models.Data;

public interface IInventorRepository
{
    void Add(Inventor inventor);
    Inventor? GetById(int id);
    IEnumerable<Inventor> GetAll();
}
