using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaboDos.Models.ViewModel
{
    public class PersonaViewModel
    {
        public int IdPersona { get; set; }

        [Display(Name = "Nombre ")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public string NombrePersona { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public Nullable<int> EdadPersona { get; set; }

        [Display(Name = "Descripcion ")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public string DescripcionPersona { get; set; }
    }
}