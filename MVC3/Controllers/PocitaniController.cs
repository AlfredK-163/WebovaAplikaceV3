using Microsoft.AspNetCore.Mvc;
using MVC3.Models;

namespace MVC3.Controllers
{
    public class PocitaniController : Controller
    {
        public IActionResult Index()
        {
            var kuryr1 = new KuryrViewModel();
         
            return View(kuryr1);
        }

       public IActionResult VytvorKuryra(KuryrViewModel c)
        {
            c.vysledek = c.penezenka + c.dyska - c.nakupovani - c.tankovani - c.trzba;
            return View("Vysledek", c);

        }

       
    }
}
