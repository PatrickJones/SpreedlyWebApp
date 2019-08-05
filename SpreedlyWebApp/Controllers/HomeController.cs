using SpreedlyWebApp.Spreedly;
using SpreedlyWebApp.Spreedly.SpreedlyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SpreedlyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> About()
        {
            ViewBag.Message = "Your application description page.";

            var sp = new SpreedlyPaymentProcessor();
            await sp.SendTransaction(new SpreedlyTransactionRequest { Amount = 300, CurrencyCode = "USD", RetainOnSuccess = true, PaymentMethodToken = "XZ1f00uScJYvGLI8L8HIxtZQlki" });


            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}