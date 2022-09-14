using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using mvcLogin.Models.Data.ProjeContext;
using mvcLogin.Models.VM;

namespace mvcLogin.Controllers
{
   // [Authorize ]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Logın()
        {
            //kullanıcı oturum acmıs mı evet ıse dırek ındexe gıtsın
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");//eger kullanıcı zaten logın olduysa home controlera gonder.
            }
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]//formdan gelen kısılerı karsılastırır.
        public ActionResult Logın(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                using (PorojectContext db = new PorojectContext())
                {
                    var user = db.Users.FirstOrDefault(a => a.Email == model.Email && a.Password == model.Password);

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
          
            ViewBag.Massege = "kullanıcı adı soyadı parola hatalı";
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Logın");
        }
    }
}