using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using appventas.Models;

namespace appventas.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            var listcontactos = new List<Contacto>();
            listcontactos.Add(new Contacto(){FirstName="Cristhian", LastName="Cruz", Email="cristhian_cruz@usmp.pe"});
            listcontactos.Add(new Contacto(){FirstName="Nestor", LastName="Cruz", Email="nestor_cruz@usmp.pe"});
            listcontactos.Add(new Contacto(){FirstName="George", LastName="Reyes", Email="iker_cruz@usmp.pe"});

         ViewData["Message"] = "";
            return View(listcontactos);
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)


        {
            objContacto.Status = "Registrado";
            ViewData["Message"] = "El contacto ya está "+ objContacto.Status;
            return View("Index");
        }

       
    }
}
