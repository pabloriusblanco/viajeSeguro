using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class EstadoPago
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

    }
}
