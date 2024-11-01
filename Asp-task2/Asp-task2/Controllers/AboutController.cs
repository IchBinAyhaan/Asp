using Asp_task2.Data;
using Asp_task2.Models.About;
using Microsoft.AspNetCore.Mvc;

namespace Asp_task2.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var teamMembers = _context.TeamMembers.ToList();
            var teamMembersList = new List<TeamMemberVM>();
            foreach(var teamMember in teamMembers)
            {
                var teamMemberVM = new TeamMemberVM
                {
                    Name = teamMember.Name,
                    Surname = teamMember.Surname,
                    PhotoPath = teamMember.Photopath,
                    Positions = teamMember.Position
                    
                };
                teamMembersList.Add(teamMemberVM);
            }
            var chooseUss = _context.ChooseUss.ToList();
            var chooseUsList = new List<ChooseUsVm>();
            foreach (var chooseUs in chooseUss)
            {
                var chooseUsVm = new ChooseUsVm
                {   
                    Icon = chooseUs.Icon,
                    Head = chooseUs.Head,
                    Text = chooseUs.Text

                };
                chooseUsList.Add(chooseUsVm);
            }
            var model = new AboutIndexVM
            {
                TeamMembers = teamMembersList,
                ChooseUss = chooseUsList
            };
            return View(model);
        }
    }
}
