using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //   return Content("Index");

        //}

        //public ActionResult asp()
        //{
        //    return Redirect("https://docs.google.com/presentation/d/1G9Gy4TRHWzYwDJ8jGJ_5aS7Vo_wqb3Zj/edit#slide=id.p4");

        //}

        //public ActionResult red()
        //{
        //    return RedirectToAction("asp");

        //}

        public IActionResult Index() { return View(); }

        public IActionResult AboutUs () { return View(); }

        public IActionResult Contact() { return View(); }

        public IActionResult Privacy() { return View(); }

    }
}
