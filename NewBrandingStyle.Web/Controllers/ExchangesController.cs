using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Show(ExchangesModel exchanges)
        {
            var viewModel = new ExchangesAddViewModel
            {
                NumberOfCharsInName = exchanges.Name.Length,
                NumberOfCharsInDescription = exchanges.Description.Length,
                IsHidden = !exchanges.IsVisible

            };
            return View("ExchangesAdded", viewModel);
        }
    }
}
