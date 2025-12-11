using System;

namespace Uppfinaren_1._0.Models.Data;

public interface IArtworkRepository
{
    void Add(Artwork artwork);
    Artwork? GetById(int id);
    IEnumerable<Artwork> GetAll();
}
