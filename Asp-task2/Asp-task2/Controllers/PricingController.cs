using Asp_task2.Data;
using Asp_task2.Models.Pricing;
using Microsoft.AspNetCore.Mvc;

namespace Asp_task2.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pricingCards = _context.PricingCards.ToList();
            var pricingCardsList = new List<PricingCardVM>();
            foreach (var pricingCard in pricingCards)
            {
                var pricingCardVM = new PricingCardVM
                {
                    HeaderName = pricingCard.HeaderName,
                    Price = pricingCard.Price,
                    Parag1 = pricingCard.Parag1,
                    Parag2 = pricingCard.Parag2,
                    Parag3 = pricingCard.Parag3,
                    Parag4 = pricingCard.Parag4
                


                };
                pricingCardsList.Add(pricingCardVM);
            }
            var model = new PricingIndexVM
            {
                PricingCards = pricingCardsList,
            };
            return View(model);
        }
    }
}
