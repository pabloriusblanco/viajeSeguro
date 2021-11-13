using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViajeSeguro.Models;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace ViajeSeguro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        #region InyeccionDependenciaHosting
        private readonly IWebHostEnvironment Hosting;
        private readonly ViajeSeguroDBContext database;
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment hosting, ViajeSeguroDBContext ctx)
        {
            _logger = logger;
            database = ctx;
            Hosting = hosting;
        }
        #endregion

        #region DBInizialicion
        static List<Reserva> ListaReserva = new List<Reserva>();
        private List<Reserva> GetReservas()
        {
            return database.Reservas
                .Include(x => x.Origen)
                .Include(x => x.Destino)
                .Include(x => x.Plan)
                .Include(x => x.Plan.Icon)
                .ToList();
            //return DBTest.IniciateListaReserva();
        }
        #endregion

        public IActionResult Index()
        {
            ListaReserva = GetReservas();
            var ListaReserva_last5 = ListaReserva.OrderByDescending(lista => lista.Id).Take(5).ToList();
            ViewBag.ReservasTotales = getTopCardsInfo("Totales");
            ViewBag.ReservasContradas = getTopCardsInfo("Contratadas");
            ViewBag.ReservasRechazadasCanceladas = getTopCardsInfo("CanceladasRechazadas");
            ViewBag.ReservasIngresos = getTopCardsInfo("Ingresos");
            return View(new IndexViewModel() { Reservas = ListaReserva_last5.ToPagedList() });
        }

        private double getTopCardsInfo(string cardName)
        {
            double respuesta = 0;
            var ListaReserva = GetReservas();

            switch (cardName)
            {
                case "Totales":
                    respuesta = ListaReserva.Count();
                    break;
                case "Contratadas":
                    respuesta = ListaReserva.Where(x=>x.Activa == true).Where(x=>x.EstadoPagoId == 3).Count();
                    break;
                case "CanceladasRechazadas":
                    respuesta = ListaReserva.Where(x => x.Activa == false).Count() + ListaReserva.Where(x => x.Activa == true).Where(x => x.EstadoPagoId == 1).Count();
                    break;
                case "Ingresos":
                    respuesta = Math.Round(ListaReserva.Where(x => x.Activa == true).Where(x => x.EstadoPagoId == 3).Sum(x => x.Total), 2);
                    break;
                default:
                    break;
            }

            return respuesta;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
