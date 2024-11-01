using Asp_task2.Data;
using Asp_task2.Models.Contact;
using Asp_task2.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Asp_task2.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contactCards = _context.ContactCards.ToList();
            var contactCardsList = new List<ContactCardVM>();
            foreach (var contactCard in contactCards)
            {
                var contactCardVM = new ContactCardVM
                {
                    Head = contactCard.Head,
                    Icon = contactCard.Icon,
                    Number = contactCard.Number,
                    Text = contactCard.Text

                };
                contactCardsList.Add(contactCardVM);
            }
            var model = new ContactIndexVM
            {
                ContactCards = contactCardsList,
            };
            return View(model);
        }
    }
}
