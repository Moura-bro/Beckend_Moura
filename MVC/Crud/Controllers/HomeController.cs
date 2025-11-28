using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Crud.Models;

namespace Crud.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    //Acao Padrao inicial 
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();
    }

    public IActionResult ListaNomes()
    {
        string[] nomes = ["Eduardo", "Joao" , "Rafael","Gomes" , "Salgado"];

        ViewBag.Teste = "Ola eu vim da Mochila";
        ViewBag.nomes = nomes;
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
