using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPTB1.Models
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soA, string soB)
        {
            double soa = Convert.ToDouble(soA);
            double sob = Convert.ToDouble(soB);
            double ketqua = -sob / soa;
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}