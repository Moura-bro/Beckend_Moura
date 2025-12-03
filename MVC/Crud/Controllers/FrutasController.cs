using Microsoft.AspNetCore.Mvc;
using Crud.Models;

namespace Crud.Controllers
{

    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;


        public static List<Frutas> ListaDeFrutas = new List<Frutas>
        {
            new Frutas{ Id =1  ,Nome = "Morango", Preco = 6.89f, Quantidade = 10, Categoria ="Tropical"  },
            new Frutas{ Id =2  ,Nome = "Abacate", Preco = 8.89f, Quantidade = 50, Categoria ="Tropical"  },
            new Frutas{ Id =3  ,Nome = "limao", Preco = 7.89f, Quantidade = 30, Categoria ="Tropical"  },
        };
        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.Frutas = ListaDeFrutas;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarFruta( Frutas frutasCadastradas)
        {
            frutasCadastradas.Id =ListaDeFrutas.Max(f => f.Id) + 1;

            ListaDeFrutas.Add(frutasCadastradas);

            return RedirectToAction(nameof (ListarFrutas));
        }


     


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}