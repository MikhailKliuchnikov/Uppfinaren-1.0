# Uppfinnaren 1.0

## Disclaimer: Jag ber om ursäkt men jag orkar inte just nu att formulera allt på svenska. Låt mig veta om det är olämpligt att skriva denna dokument på engelska och nästa gång kommer jag lösa det

Nevertheless:

## What is inside this README?

1. README part that explains the project, it's structure and how I used MVC design pattern in order to complete the task.
2. Instruction how to install and start the app
3. Written reflection on my decisions during this project, what have I done to prepare the app for future development. Which problems I encountered and why have I made those choices I made.

## 1. README part that explains the project

The app is the first app I have written by myself ASP.NET framework.
It is build using MVC (Module, View, Controller) design pattern.

The app is a database of some fiction supervillians-mad scientists and their inventions.

Two main classes-objects are **Artwork** (or invention) and **Inventor**.
They represent the data types the project will be working with. They use Id for sorting, and the rest fields such as Name, Description and etc are appropriate fields: image, contact info etc.

Module:
It has a fake data repositories: *"InMemoryArtwork/InventorRepository"*. Where the data about mad scientists and inventions is hardcoded.
(The data structure in both Artwork and Inventor is extremely similair so I will be talking about them at the same time)

Those repositories implement *IArtwork/InventorRepository* interfaces which both have methods: **Add()**, **GetAll()**, **GetById(int id)**.
Those methods represent the database logic for searching and manipulating information.

Controller:
HomeController has a classic implementation of ASP.NET and only has **Index()** that gives user a choice of two other controllers.

Artwork/Inventor controllers display **Index()** and **Info()** in both cases Index leads to a general page showcasing all **Inventors/Inventions** and **Info()** leads to a detailed page of **Inventor/Invention**.

View:
In **/Views** I have different folders for Home, **InventorGallery** and **ArtworkGallery**, which are named accordingly to be found by **ArtworkGalleryController** and **InventorGalleryController** later.

Both **Artwork/Inventor Gallery** have two files named **Index** and **Vies** accordingly to methods in their controllers in order to be found.

In **Index** of both Galleries **Model** is used to represent a list of objects which are printed out later with Razor CSHTML through a foreach loop, creating a **div** for each object filled dynamically with information to represent a short version of an object - a **card**.
By clicking on the **Name** one opens **Info()** for the appropriate object. That is done through providing datasets:
`<a asp-action="Info" asp-route-id="@inventor.Id">@inventor.Name</a>`

where:

><asp-action="Info">

in order to provide information to framework which method is expected to be executed

><asp-route-id="@inventor.Name">

in order to provide a dynamically generated Id to ensure each separate link leads to appropriate object page.

## 2. Installatiomn

In order to install and start this project one would have to have VSC or any other coding envoroment installed with C#, ASP.NET.
Simply go to the terminal, navigate yourself whenver you would like to install the project and write:
> git clone `https://github.com/MikhailKliuchnikov/Uppfinaren-1.0`

After that the app will be appeared in the folder you were in.
Continuing in your Terminal, write:

> dotnet build

and after it has been completed:

> dotnet watch

This should start the app on the local server and open an according page in your web-browser.
If its not, you can yourself navigate to that page by copying the localhost: address you have in your terminal.

Now the app should work.

## 3. Reflection

> 1. Tillsammans med projektet så skall du bifoga en skriftlig reflektion där du beskriver de val du har tagit under ditt arbete för att förbereda applikationen för vidare utveckling. Vilka problem du stött på och varför du har tagit de beslut du har tagit.

When I first heard that the application will be expanding I understood that in order to do the future scale in a nice way one has to use the OOP princips in a good way. Therefore I have from the beginning created two main classes: Inventor (Could be many) and Artwork(Could also be many). And made application around those classes first. So in the future would be possible to add logic without changing the "hardcoded" data (if both objects would be just plain objects ).

I also thought that in case the app will be expanding, then using a hardcoded DB in a fake-repository like Janne did in his video would not be the perfect way: what if we will have 100 inventors and 100000 artworks?
I would go insane hardcoding them in a fake repo.

So my idea at first was to implement a separate json files with objects Inventor and Artwork.
So I would have a mini-database on a side and in case I want to add/change something with objects I would not have touched the code itself.

That idea with Json files worked out pretty bad, but I managed to learn a few things.
First: json and C# are possible to use together, but they would not be friends in real life. Java Script Online Notation is called JavaScript for a reason. C# apparently is made for other causes.

Second: ASP.NET is a complex framework, and although it is nice to understand how it works under the hood, in the current learning pattern it is not appropriate. I have been stuck with DependencyInjection and Sinelton type of it for quite a while before I realised that I overcomplicate the given task too much. As well as to properly transfer data from Json to C# fake repo/controller, I would need a separate class just to wrap it up. But on the good side I now know how to deserialise the json in c#. Cool!
This was the biggest trouble I have faced in development of this app.

I have taken decicions I've taken because MVC design pattern tells me so. I hope I explained the overall MVC structure in the README part of this README. I also like mad scientists so when the task is called "Uppfinnaren" I could not resist. After I managed to connect View Module and Controller together (and finally understood how they are working together), the rest was piece of cake: just dynamically generate some razor cshtml data and make it look somewhat structured. Razor is quite a cool feature.

I wanted very badly to style the page in my own way (mad-scientist style), but I unfortunately running of time so I have asked AI to make a simple and readable design for the page.

In general, I think it is rather a matter of habit: to work with ASP.NET and I am feeling very happy that I (at least as I think) understood this MVC design pattern, because when it works out as it should, I can definetly see why people want to use it as an instrument when designing their pages. It felt really comfortable (after it has been very uncomfortable in the beginning of the week).

I believe my application fullfils all the points in the Kravlista :)

Thank you so much for taking your time to read it all!
Have a nice day!
