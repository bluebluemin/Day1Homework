using Homework1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            List<MoneyViewModel> MVMS = new List<MoneyViewModel>() {
                    new MoneyViewModel() {
                    Type="支出",
                    Cost = 1000,
                    CostDate = new DateTime(2016,01,02),
                },
                    new MoneyViewModel() {
                    Type="支出",
                    Cost = 2000,
                    CostDate = new DateTime(2016,01,05),
                },
                    new MoneyViewModel() {
                    Type="收入",
                    Cost = 500,
                    CostDate = new DateTime(2016,01,12),
                },
                    new MoneyViewModel() {
                    Type="支出",
                    Cost = 1700,
                    CostDate = new DateTime(2016,01,18),
                }
            };
            return View(MVMS);
        }
        [ChildActionOnly]
        [HttpGet]
        public ActionResult Insert()
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