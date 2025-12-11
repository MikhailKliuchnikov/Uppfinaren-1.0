using System.Text.Json;
using Uppfinaren_1._0.Models.Data;

public partial class Program
{
    private static void Main(string[] args)
    {
        // Initialize the in-memory artwork repository with data from JSON file
        var artworkRepository = new InMemoryArtworkRepository();
        string artworkJsonPath = "Models/Data/artworks.json";
        if (File.Exists(artworkJsonPath))
        {
            string json = File.ReadAllText(artworkJsonPath);
            var artworkData = JsonSerializer.Deserialize<ArtworkData>(json);
            if (artworkData != null)
            {
                artworkRepository.InitializeArtworks(artworkData.Artworks);
            }
        }

        // Initialize the in-memory inventor repository with data from JSON file
        var inventorRepository = new InMemoryInventorRepository();
        string inventorJsonPath = "Models/Data/inventors.json";
        if (File.Exists(inventorJsonPath))
        {
            string json = File.ReadAllText(inventorJsonPath);
            var inventorData = JsonSerializer.Deserialize<InventorData>(json);
            if (inventorData != null)
            {
                inventorRepository.InitializInventors(inventorData.Inventors);
            }
        }


        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddSingleton<IInventorRepository>(inventorRepository);
        builder.Services.AddSingleton<IArtworkRepository>(artworkRepository);
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();


        app.Run();
    }
}