using System;

namespace Uppfinaren_1._0.Models;

public class Inventor
{
    public int Id { get; set; }
    public string Name { get; set; } = "Inventor Name";
    public string Description { get; set; } = "Inventor has not provided a description.";
    public List<Artwork> Inventions { get; set; } = new List<Artwork>();
    public string ImageUrl { get; set; } = "Information not provided";
    public string Email { get; set; } = "Information not provided";
    public string PhoneNumber { get; set; } = "Information not provided";
    public string Address { get; set; } = "Information not provided";
    public string OtherWayToContact { get; set; } = "Information not provided";
    public Inventor(int id, string name, string description, string imageUrl, string email,
                    string phoneNumber, string address, string otherWayToContact)
    {
        Id = id;
        Name = name;
        Description = description;
        ImageUrl = imageUrl;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        OtherWayToContact = otherWayToContact;
    }
    public void AddInvention(Artwork invention)
    {
        Inventions.Add(invention);
    }
}
