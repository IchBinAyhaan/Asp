using Asp_task2.Data;
using Asp_task2.Models.About;
using Asp_task2.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Asp_task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var homeWorks = _context.HomeWorks.ToList();
            var homeWorksList = new List<HomeWorkVM>();
            foreach (var homeWork in homeWorks)
            {
                var homeWorkVM = new HomeWorkVM
                {
                    Photo = homeWork.Photo,
                    Header = homeWork.Header,
                    Parag = homeWork.Parag

                };
                homeWorksList.Add(homeWorkVM);
            }
            var model = new HomeIndexVM
            {
                HomeWorks = homeWorksList,
            };
            return View(model);
        }
    }
}
