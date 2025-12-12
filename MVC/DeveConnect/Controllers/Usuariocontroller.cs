using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DeveConnect.Contexts;
using DeveConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeveConnect.Controllers
{
    //Cadastro de Usuario
    public class Usuariocontroller : Controller
    {
        private readonly DeveConnectContext _context;
        private readonly ILogger<Usuariocontroller> _logger;

        public Usuariocontroller(ILogger<Usuariocontroller> logger,  DeveConnectContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection from)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
              NomeCompleto = from["NomeCompleto"].ToString(),
              NomeUsuario = from["NomeUsuario"].ToString(), 
              Email = from["Email"].ToString(),
              Senha = from["Senha"].ToString()
            };

            if (from.Files.Count > 0)
            {
                // se selecionou uma imagem entra dentro do if
                IFormFile file = from.Files[0];
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imagens");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);


                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;

            }
            else
            {
                novoUsuario.FotoPerfilUrl = ""; // sem imagem
            }

            try
            {
               _context.TbUsuario.Add(novoUsuario);

               await _context.SaveChangesAsync();

               TempData["UsuarioNovoCadastrado"] = "cadastrado";
               ViewBag.UsuarioNovoCadastrado = "";

               return RedirectToAction("Index", "Home");

            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View();
            }


            
        }
        public IActionResult Perfil()
        {
            return View();
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}