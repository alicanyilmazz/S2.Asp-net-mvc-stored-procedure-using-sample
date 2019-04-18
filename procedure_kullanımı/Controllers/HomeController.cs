using procedure_kullanımı.Models;
using procedure_kullanımı.Models.Managers;
using procedure_kullanımı.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace procedure_kullanımı.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult homepage()
        {
            DatabaseContext db = new DatabaseContext();
            List<Persons> kisiler_listesi = db.db_context_kisiler.ToList(); //select * from kisiler //aynı zamanda database olusumunu tetikler bu select islemi

            HomePageViewModel model = new HomePageViewModel();
            model.kisiler_primitive_object = db.db_context_kisiler.ToList(); //database den liste şeklinde kişileri döner
            model.adresler_primitive_object= db.db_context_adresler.ToList(); //database den liste şeklinde adresleri döner
            ViewBag.control = true;

            return View(model);



        }

        //[HttpPost, ActionName("homepage")]
        [HttpPost]
        public ActionResult homepage(HomePageViewModel c)
        {
            DatabaseContext db = new DatabaseContext();
            List<my_procedure_class> result = db.EXECUTE_my_procedure(c.alt_sinir, c.ust_sinir);

            HomePageViewModel md = new HomePageViewModel();
            md.my_procedure_class_primitive_object = result.ToList();
            ViewBag.control = false;
            // md.my_procedure_class_primitive_object = result.ToList();

            return View(md);
        }
    }
}