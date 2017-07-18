using Homework1.Models.ViewModels;
using Homework1.Repositories;
using Homework1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountService _accountSvc;
        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _accountSvc = new AccountService(unitOfWork);
        }
        [ChildActionOnly]
        public ActionResult Index()
        {           
            IList<MoneyViewModel> MVMS = _accountSvc.Get();
            return View(MVMS);
        }
        
        [HttpGet]
        public ActionResult Insert()
        {
            List<SelectListItem> typeDropList = new List<SelectListItem>()
            {
                new SelectListItem {
                    Text="請選擇",
                    Value="",
                    Selected=true
                },
                new SelectListItem {
                    Text="支出",
                    Value="1"
                },
                new SelectListItem {
                    Text="收入",
                    Value="2"
                }
            };
            ViewBag.TypeDropList = typeDropList;
            return View();
        }
        [HttpPost]
        public ActionResult Insert([Bind(Include = "Type,Cost,CostDate,Memo")] CreateMoneyViewModel CMVM)
        {
            _accountSvc.AddAccount(CMVM);
            _accountSvc.Save();
            return RedirectToAction("Insert");

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