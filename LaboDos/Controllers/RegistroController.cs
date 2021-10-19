using LaboDos.Models;
using LaboDos.Models.ViewModel;
using LaboDos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaboDos.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Registrar()
        {

            //Persona persona = new Persona();
            //PersonaRepository personaRepository = new PersonaRepository();
            //persona.NombrePersona = "Progra apli 1";
            //persona.EdadPersona = 15;
            //persona.DescripcionPersona = "persona adulta altura promedio";
            //personaRepository.Save(persona);

            //var ListOfData = personaRepository.ListDataPersona();

            return View(); //razor page nos adactara


        }
        public ActionResult Registrars(PersonaViewModel personas)
        {
          
            if (ModelState.IsValid)
            {   
                return View("Registrar",personas);
            }
           else 
                return View("Registros");
             

        }
        public ActionResult Registro ()
        {
            return View ();
        }

        public ActionResult Registros(Persona personas)
        {           
            PersonaRepository personaRepository = new PersonaRepository();

            personaRepository.Save(personas);

            var ListOfData = personaRepository.ListDataPersona();

            return View(ListOfData); //razor page nos adactara
        }       
    }
}