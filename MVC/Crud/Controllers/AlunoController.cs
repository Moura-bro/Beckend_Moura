using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crud.Models;

namespace Crud.Controllers
{

    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        private readonly CrudMouraContext _context;

        public AlunoController (ILogger<AlunoController> logger , CrudMouraContext context)
        {
            _logger = logger;
            _context = context;
        }



        public static List<Aluno> ListaDeAluno = new List<Aluno>
        {
            new Aluno{ Id_Aluno =1  ,Nome = "Rafael", Idade = 16 ,Ra = "10", CPF = "34464579870" },
            new Aluno{ Id_Aluno =2  ,Nome = "Gomes", Idade = 17 ,Ra = "50", CPF = "34464579870" },
            new Aluno{ Id_Aluno =3  ,Nome = "Joao", Idade = 17 ,Ra = "30", CPF =  "34464579870"},
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarAlunos()
        {
            ViewBag.Aluno = ListaDeAluno;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarAlunos(Aluno Alunoscadastrado)
        {
            Alunoscadastrado.Id_Aluno = ListaDeAluno.Max(f => f.Id_Aluno) + 1;

            ListaDeAluno.Add(Alunoscadastrado);

            return RedirectToAction(nameof(ListarAlunos));
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}