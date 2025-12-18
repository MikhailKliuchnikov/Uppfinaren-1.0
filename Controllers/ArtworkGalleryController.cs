using Microsoft.AspNetCore.Mvc;
using Uppfinaren_1._0.Models;

namespace Uppfinaren_1._0.Controllers
{
    public class ArtworkGalleryController : Controller
    {
        private readonly AppDbContext _context;
        public ArtworkGalleryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? category = null)
        {
            var allArtworks = _context.Artworks.ToList();
            var filtered = string.IsNullOrEmpty(category)
                ? allArtworks
                : allArtworks.Where(a => a.Category == category);

            ViewBag.Categories = InventionCategories.Categories;
            ViewBag.SelectedCategory = category;
            return View(filtered);
        }
        public ActionResult Info(int id)
        {
            var artwork = _context.Artworks.FirstOrDefault(a => a.Id == id);
            return View(artwork);
        }
    }
}
