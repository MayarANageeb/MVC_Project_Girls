using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class AccountController : Controller
    {


        //regieter
        //open view "link
        public IActionResult Registration()
        {
            return View();
        }

        //save data dabe Request ==>db
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Registration()   //not all property model + extra property for view Confirm + validation [][][]
        //{
        //    return View();
        //}
    }
}
