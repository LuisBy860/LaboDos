using LaboDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboDos.Servicio
{
    interface IPersona
    {
        void Save(Persona c);

        List <Persona> ListDataPersona();
    }
}