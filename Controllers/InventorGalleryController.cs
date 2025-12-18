using Microsoft.AspNetCore.Mvc;
using Uppfinaren_1._0.Models;

namespace Uppfinaren_1._0.Controllers
{
    public class InventorGalleryController : Controller
    {
        private readonly AppDbContext _context;
        public InventorGalleryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inventors = _context.Inventors.ToList();
            return View(inventors);
        }
        public ActionResult Info(int id)
        {
            var inventor = _context.Inventors.FirstOrDefault(i => i.Id == id);
            if (inventor == null) return NotFound();
            inventor.Inventions = _context.Artworks.Where(a => a.InventorId == id).ToList();
            return View(inventor);
        }
    }
}
