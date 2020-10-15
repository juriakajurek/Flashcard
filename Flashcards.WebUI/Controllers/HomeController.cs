using Flashcards.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Flashcards.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        void btnStart_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null) // just to be on the safe side
                return;
            Response.Write("<script>alert('Data inserted successfully')</script>");
        }


        public ActionResult ChooseLevel()
        {
            return View();

        }


        public ActionResult Game(GameViewModel model)
        {
            return View(model);
        }

        public ActionResult Index()
        {



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}