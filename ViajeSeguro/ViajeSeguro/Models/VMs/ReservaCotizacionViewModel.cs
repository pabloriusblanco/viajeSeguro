using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViajeSeguro.Models
{
    public class ReservaCotizacionViewModel
    {
        public Reserva Reserva { get; set; }
        public List<Cotizacion> Cotizaciones { get; set; } = new List<Cotizacion>();
    }
}
