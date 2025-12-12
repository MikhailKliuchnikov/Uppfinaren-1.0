using Microsoft.AspNetCore.Mvc;
using Uppfinaren_1._0.Models.Data;

namespace Uppfinaren_1._0.Controllers
{
    public class ArtworkGalleryController : Controller
    {
        private readonly InMemoryArtworkRepository _artworkRepository;

        public ArtworkGalleryController()
        {
            _artworkRepository = new InMemoryArtworkRepository();
        }

        public ActionResult Index()
        {
            return View(_artworkRepository.GetAll());
        }
        public ActionResult Info(int id)
        {
            var artwork = _artworkRepository.GetById(id);
            return View(artwork);
        }
    }
}
