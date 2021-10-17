using LaboDos.Models;
using LaboDos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaboDos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Persona persona = new Persona();
            PersonaRepository personaRepository = new PersonaRepository();
            persona.NombrePersona = "Progra apli 1";
            persona.EdadPersona = 15;
            persona.DescripcionPersona = "persona adulta altura promedio";
            personaRepository.Save(persona);
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}