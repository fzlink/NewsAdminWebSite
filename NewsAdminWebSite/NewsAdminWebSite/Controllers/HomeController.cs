using NewsAdminWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsAdminWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NewsDatabaseEntities db = new NewsDatabaseEntities();

            List<LoginViewModel> loginVMList = new List<LoginViewModel>();
            LoginViewModel loginVM = new LoginViewModel();
            foreach (Admin admin in db.Admins)
            {
                loginVM.Email = admin.Email;
                loginVM.Password = admin.Password;
                loginVMList.Add(loginVM);
            }
            foreach (Editor editor in db.Editors)
            {
                loginVM.Email = editor.Email;
                loginVM.Password = editor.Password;
                loginVMList.Add(loginVM);
            }
            return View(loginVMList);
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