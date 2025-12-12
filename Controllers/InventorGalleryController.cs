using Microsoft.AspNetCore.Mvc;
using System.Text.Json; 
using Uppfinaren_1._0.Models.Data;
using Uppfinaren_1._0.Models;

namespace Uppfinaren_1._0.Controllers
{
    public class InventorGalleryController : Controller
    {
        public readonly InMemoryInventorRepository _inventorRepository;

        public InventorGalleryController()
        {
            _inventorRepository = new InMemoryInventorRepository();
        }

        public IActionResult Index()
        {
            var inventors = _inventorRepository.GetAll();
            return View(inventors);
        }
        public ActionResult Info(int id)
        {
            var inventor = _inventorRepository.GetById(id);
            return View(inventor);
        }


    }
}
