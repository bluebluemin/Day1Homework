using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class ValidController : Controller
    {
        // GET: Valid
        public ActionResult Index(DateTime? costDate)
        {
            bool isValidate = costDate <= DateTime.Today;
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}