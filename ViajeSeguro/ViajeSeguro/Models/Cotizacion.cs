using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public virtual Reserva Reserva { get; set; }
        public int PasajeroId { get; set; }
        public virtual Pasajero Pasajero { get; set; }
        public int CantidadDiasViaje { get; set; }
        public double Total { get; set; }

    }
}
