using BookStoreShoppingCartMVUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStoreShoppingCartMVUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRespository _homeRespository;

        public HomeController(ILogger<HomeController> logger, IHomeRespository homeRespository)
        {
            _logger = logger;
            _homeRespository = homeRespository;
        }

        public async Task<IActionResult> Index(string sterm = "", int genreId = 0)
        {

            IEnumerable<Book> books = await _homeRespository.GetBooks(sterm, genreId);
            IEnumerable<Genre> genres = await _homeRespository.Genres();
            BookDisplayModel bookModel = new BookDisplayModel
            {
                Books = books,
                Genres = genres,
                STerm = sterm,
                GenreId=genreId
            };
            return View(bookModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}