using Microsoft.AspNetCore.Mvc;
using Session_1.Interface;
using Session_1.Models;
using System.Diagnostics;

namespace Session_1.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServices services;

        public ServiceController(IServices services)
        {
            this.services = services;
        }

        public IActionResult Index()
        {
            try
            {
                string myValue = services.GetValue("MySettingKey");
                // var view = new ServiceVM { SettingValue = myValue };
                // return View();
                // return Content(myValue);
                return View("Index", myValue);
            }
            catch (InvalidOperationException ex)
            {

                return RedirectToAction("Error", "Index");
            }
        }
    }
}