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

        public ActionResult Index()
        {
            return View(_context.Artworks.ToList());
        }
        public ActionResult Info(int id)
        {
            var artwork = _context.Artworks.FirstOrDefault(a => a.Id == id);
            return View(artwork);
        }
    }
}
