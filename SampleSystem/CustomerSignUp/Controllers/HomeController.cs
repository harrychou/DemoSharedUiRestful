using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CustomerSignUp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:2000/");

            //HttpResponseMessage response = client.GetAsync("OfferCatalog/New").Result;  

            //if (response.IsSuccessStatusCode)
            //{
            //    var html = response.Content.ReadAsStringAsync().Result;
            //    ViewBag.InitialHtml = html;
            //}

            return View();
        }

    }
}
