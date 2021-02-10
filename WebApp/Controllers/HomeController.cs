using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        IRepository _repository;

        public HomeController()
        {
            _repository = new WebApp.Repository.Repository();// TODO: Insted od DI  
        }

        [HttpPost]
        public ActionResult SwitchLanguage(bool english)
        {
            string culture = english ? "en" : "pl";

            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            Session["CurrentCulture"] = culture;
            return View("Index");
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(NicknameAndEmailViewModel viewModel)
        {
            _repository.Add(viewModel);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult List()
        {
            return View(_repository.List());
        }


    }
}