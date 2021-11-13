using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class Icon
    {
        public int Id { get; set; }
        public string NombreIcono { get; set; }

        [Display(Name = "Icono")]
        public string CodigoIcono { get; set; }
    }
}
