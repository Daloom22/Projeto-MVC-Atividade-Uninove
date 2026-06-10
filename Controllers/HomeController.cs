using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_MVC_Atividade_Uninove.Models;

namespace Projeto_MVC_Atividade_Uninove.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
