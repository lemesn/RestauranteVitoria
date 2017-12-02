using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VitoriaRestaurante.Models;
using VitoriaRestaurante.Repositorios;

namespace VitoriaRestaurante.Controllers
{//http://localhost:53236/Home/Cliente?nome=rafael&restaurante=chiqtop&comentario=uallmuitobom
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Cliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var repositorio = new Repositorio();
                repositorio.Cadastre(cliente);
                return RedirectToAction(nameof(Lista));
            }
            else
            {
                return View(cliente);
            }
            
        }
         
        public IActionResult Lista()
        {
            var repositorio = new Repositorio();
            var listaDeCliente = repositorio.Liste();
            return View(listaDeCliente);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Restaurants()
        {
            return View();
        }

        public IActionResult Cuisine()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Dishes()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Prices()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Location()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Reviews()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
