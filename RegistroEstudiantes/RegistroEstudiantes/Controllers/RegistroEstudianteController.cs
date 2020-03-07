using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RegistroEstudiantes.Controllers
{
    public class RegistroEstudianteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}