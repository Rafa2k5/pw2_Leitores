using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto.Models;

namespace projeto.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult CadastroLeitor()
        {
            return View();
        }

        public IActionResult ConsultaLeitor()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}