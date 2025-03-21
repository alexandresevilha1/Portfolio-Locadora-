using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfólio_Locadora.Models;

namespace Portfólio_Locadora.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
