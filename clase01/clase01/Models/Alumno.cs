using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace clase01.Models
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [Display(Name = "N° de Documento")]
        public int Dni { get; set; }
    }
}
