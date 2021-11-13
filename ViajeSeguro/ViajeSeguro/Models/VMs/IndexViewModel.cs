using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using X.PagedList;

namespace ViajeSeguro.Models
{
    public class IndexViewModel
    {
        public IPagedList<Reserva> Reservas { get; set; }

    }
}
