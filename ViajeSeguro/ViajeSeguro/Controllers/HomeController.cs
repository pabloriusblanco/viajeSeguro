using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
                .Where(x => x.Activa == true)
                .ToList();
            //return DBTest.IniciateListaReserva();
        }
        #endregion

        public IActionResult Index()
        {
            ListaReserva = GetReservas();
            var ListaReserva_last5 = ListaReserva.OrderByDescending(x => x.FechaEmision);
            ViewBag.ReservasTotales = GetTopCardsInfo("Totales");
            ViewBag.ReservasContradas = GetTopCardsInfo("Contratadas");
            ViewBag.ReservasRechazadasCanceladas = GetTopCardsInfo("CanceladasRechazadas");
            ViewBag.ReservasIngresos = GetTopCardsInfo("Ingresos");
            ViewBag.ReservasRegion = GetAmountReservasByRegion();
            return View(new IndexViewModel() { Reservas = ListaReserva_last5.ToPagedList(1, 5) });
        }

        private Dictionary<string, int> GetAmountReservasByRegion()
        {
            var diccionarioRegionesCantidad = new Dictionary<string, int>()
            {
                {"NA", 0},
                {"CA", 0},
                {"SA", 0},
                {"EU", 0},
                {"AF", 0},
                {"AS", 0},
                {"OC", 0},
            };

            List<Reserva> listaActivasPagadas = GetReservas().Where(x => x.Activa == true).ToList();
            listaActivasPagadas.ForEach(x => {
                switch (x.OrigenId)
                {
                    case 1: //Norte America
                        diccionarioRegionesCantidad["NA"] += 1;
                        break;
                    case 2: //Central America
                        diccionarioRegionesCantidad["CA"] += 1;
                        break;
                    case 3: //South America
                        diccionarioRegionesCantidad["SA"] += 1;
                        break;
                    case 4: //Europe America
                        diccionarioRegionesCantidad["EU"] += 1;
                        break;
                    case 5: //Africa America
                        diccionarioRegionesCantidad["AF"] += 1;
                        break;
                    case 6: //Asia America
                        diccionarioRegionesCantidad["AS"] += 1;
                        break;
                    case 7: //Oceania America
                        diccionarioRegionesCantidad["OC"] += 1;
                        break;
                    default:
                        break;
                }

            });
            return diccionarioRegionesCantidad;
        }

        private double GetTopCardsInfo(string cardName)
        {
            double respuesta = 0;
            var ListaReserva = GetReservas();

            switch (cardName)
            {
                case "Totales":
                    respuesta = ListaReserva.Count;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
