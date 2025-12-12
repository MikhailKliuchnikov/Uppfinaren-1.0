using System;

namespace Uppfinaren_1._0.Models.Data;

public class InMemoryInventorRepository : IInventorRepository
{
    private readonly List<Inventor> _inventors = new List<Inventor>
    {
        new Inventor(
            1,
            "Dr. Eggman",
            "A brilliant but evil scientist known for his robotic creations and relentless pursuit of world domination.",
            "img/inventors/Eggman.png",
            "DrEggman@evilrobotics.com",
            "555-1234",
            "123 Robot Lane, Tech City",
            "N/A"
        ), 
        new Inventor(
            2,
            "Dr. Robotnick",
            "A brilliant but evil scientist known for his robotic creations and relentless pursuit of world domination.",
            "img/inventors/Robotnik.png",
            "DrRobotnick@evilrobotics.com",
            "555-1234",
            "123 Robot Lane, Tech City",
            "N/A"
        ),
        new Inventor(
            3,
            "Dr. Nefarious",
            "Dr. Nefarious is a mad scientist who acts largely out of vengeance and hatred, particularly for his nemeses. In his various quests for galactic domination, he has manipulated many into doing his bidding, but his personal assistant Lawrence has been his main ally throughout. Dr. Nefarious has a disdain for organic life-forms, which he refers to as 'squishies', though he sometimes allies with and deploys them depending on his needs.",
            "/img/inventors/DrNefarious.png",
            "NefariousGenius@ihatesquishies.com",
            "1234-123",
            "Solana Galaxy, Biobliterator",
            "Secret robot chat, nickname: 'Very smart and attractive robot1885'"
        )
    };
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

}
