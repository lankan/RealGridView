using System.Collections.Generic;
using System.Web.Mvc;
using EditableWebgrid.Models;

namespace EditableWebgrid.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            List<UserModel> users = UserModel.getUsers();
            return View(users);
        }

        public JsonResult ChangeUser(UserModel model)
        {
            // Update model to db


            string message = "Success";
            return Json(message, JsonRequestBehavior.AllowGet);
        }

    }
}
