using System;

namespace Uppfinaren_1._0.Models;

public class Artwork
{
    public int Id { get; set; }
    public string ? Title { get; set; } = "Very cool invention";
    public string Inventor { get; set; }
    public string ? Description { get; set; } = "A humble invention of a brilliant mind.";
    public string ? ImageUrl { get; set; } = "";
    public string ? Category { get; set; } = "Invention";
    public Artwork(int id, string title, string inventor, string description, string imageUrl, string category)
    {
        Id = id;
        Title = title;
        Inventor = inventor;
        Description = description;
        ImageUrl = imageUrl;
        Category = category;
    } 
}
