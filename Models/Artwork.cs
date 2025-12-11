using System;

namespace Uppfinaren_1._0.Models;

public class Artwork
{
    public int Id { get; set; }
    public string ? Title { get; set; } = "Very cool invention";
    public Inventor inventor { get; set; }
    public string ? Description { get; set; } = "A humble invention of a brilliant mind.";
    public string ? ImageUrl { get; set; } = "";
    public string ? Category { get; set; } = "Invention";
    public Artwork(string title, Inventor inventor)
    {
        Title = title;
        this.inventor = inventor;
    } 
}
