using System;

namespace Uppfinaren_1._0.Models.Data;

public class InMemoryArtworkRepository : IArtworkRepository
{
    private List<Artwork> _artworks = new List<Artwork>();
    private int _nextId = 1;

    public void Add(Artwork artwork)
    {
        artwork.Id = _nextId++;
        _artworks.Add(artwork);
    }

    public Artwork? GetById(int id)
    {
        return _artworks.FirstOrDefault(a => a.Id == id);
    }

    public IEnumerable<Artwork> GetAll()
    {
        return _artworks;
    }
    public void InitializeArtworks(IEnumerable<Artwork> initialArtworks)
    {
        foreach (var artwork in initialArtworks)
        {
            Add(artwork);
        }
    }
}
