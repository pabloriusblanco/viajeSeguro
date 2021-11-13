using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class Plan
    {
        public int Id { get; set; }

        [Display(Name = "Código Plan")]
        public string CodigoPlan { get; set; }

        [Display(Name = "Nombre del Plan")]
        public string Nombre { get; set; }

        [Display(Name = "Ícono")]
        public Icon Icon { get; set; }
        public double PrecioBaseDia { get; set; }
    }
}
