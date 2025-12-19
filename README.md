# Uppfinnaren 2.0

## What is in this README?

1. Reflection, 1 part: Upsprung
2. Reflection, 2 part: Resultat

## Reflection, 1 part: Upsprung

The original app was build using MVC design pattern with use of ASP.NET framework. It used fake-repositories with hardcoded data and generated two pages with that data. It used different repositories for Artworks and Inventors, with very similair controllers **Index()** for main page and **Info()** for detailed page. Afterwards the controllers generated View through corresponding View files, where with help of **Razor CSHTML**, and  t.ex. **@model IEnumerable/Object** gotten correct data to be displayed on the pages.

### What was problematic to deal with in the 2.0 version?

- Since in the 2.0 version we would need separate pages for caterogies of products, it was a little bit humbling to re-write all the categories of evil inventions so they will not be as "Randomly and funny written" as they were before.
- Dependency injection syntax and logic were slightly complicated to understand, but since I was mostly following Janne's videos it was not a big problem: I simply had to ask more questions to myself which I find nice.
- Understanding of **when** and **where** to provide sorting by Category logic for View

### What was easier to deal with?

- Much easier to work with one AppDbContext than having two repositories and interfaces for them.
- Since the logic for filtering and sending appropriate View() and ViewBag objects was done, it was quite fun doing a dynamic page with Razor. My ArtworkGallery **Index()** has an optional parameter **Category** and if such parameter is **NOT** provided, it displays all the Inventions that exist. On the other hand if a **Category IS** provided, it filters out only those of appropriate category.

## Reflection, 2 part: Resultat

### File structure changes

- As the result of changing DB logic from fake-repos to InMemoryDb, model files Artwork/InventorRepositories and their Interfaces were deleted and AppDbContext was created with a cleverly overriden "OnModelCreating" function and both data for Artworks and Inventors.
- HomeView and Controller deleted since they did not provide anything to the app, and default page rerouted to ArtworkGallery in Program.cs.
- Added a new class InventionCategories.cs which serves as a "Caterogy database", which dynamically creates an sort option in the ArtworkGallery header.

### Main functional changes

#### ArtworkGalleryController.cs, Index() && ArtworkGallery View

The biggest change in functionality: **ArtworkGalleryController - Index(string? category = null)** now takes an optional string parameter as **category**, then stores all inventions in a **allArtworks** List-variable. Afterwards, creates a **filtered** variable, that checks if **category** parameter is null or present. If no such parameter (null or ""), then **filtered** variable takes **allArtworks** value. If there IS a **category** parameter, then  **filtered** sorts out **allArtworks** using LINQ/SQL method **allArtworks.Where(a => a.Category == category)** and sends it as **Model** in **View(filtered)** object.
Additionaly, it sends the list of all existing **Categories** from **InventionCategories.cs** in order to dynamically create header buttons in the view. As well as **ViewBag.SelectedCategory = category** to know which one has been chosen.

#### In ArtworkGallery View, the implementation of this logic continues

- First, the View loops the ViewBag.Categories and creates a header button for each of them. Dynamically creates a link that invokes **Index()** with a **asp-route-category="@categoryname"** which would recursively let one navigate the page.
- At the same time, it checks if one of those categories is the one that is also SelectedCategory, and gives it .active class for better UI.
- Secondly, the view loops through @model which has our filtered or not filtered objects and displays them in the page

### What I think can be done better

- Hard-coded ID's are a pain. I think one could create a system where ID's would dynamically be assigned to appropriate Inventors/Artworks, so it would not be hardcoded data.
- Caterogies could be assigned dymanically to appropriate objects as well. Now they are hard-coded and sorting happens by comparing strings, but it feels like in a bigger app one would've needed a system where instead of Category:"Robots"; one would use Category: InventionCategories.Categories[1];

Additionally, now there's cool bad-ass styling and hopefully no methods or code that are unused as you have mentioned in your response earlier!
Thank you for your time! :)
