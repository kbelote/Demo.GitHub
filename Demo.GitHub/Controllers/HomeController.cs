using System.Web.Mvc;

namespace Demo.GitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

             int i = 10;
            var newFile = string.Empty;
            for (int j = 0; j < i; j++)
            {
                newFile += " " + j;
            }

            while(i > 0 )            {
                newFile += " " + i;
                i--;
            }

            for (int j = 0; j < i; j++)
            {
                newFile += " " + j;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}