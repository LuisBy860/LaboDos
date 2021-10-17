using LaboDos.Models;
using LaboDos.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboDos.Repository
{
    public class PersonaRepository : IPersona
    {
        AlmacenPersonaEntities bd = new AlmacenPersonaEntities();

        public void Save(Persona c)
        {
            bd.Persona.Add(c);
            bd.SaveChanges();


          
        }
        public List<Persona> ListDataPersona()
        {

            var ListofDataOfPersona = bd.Persona.ToList();

            return ListofDataOfPersona;
        }
    }
}