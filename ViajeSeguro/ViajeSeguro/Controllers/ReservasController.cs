using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using ViajeSeguro.Models;
using ViajeSeguro.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace ViajeSeguro.Controllers
{
    public class ReservasController : Controller
    {
        #region InyeccionDependenciaHosting
        private readonly IWebHostEnvironment Hosting;
        private readonly ViajeSeguroDBContext database;
        public ReservasController(IWebHostEnvironment hosting, ViajeSeguroDBContext ctx)
        {
            database = ctx;
            Hosting = hosting;
        }
        #endregion

        #region DBInizialicion
        static List<Reserva> ListaReserva;
        private static int pageSize = 5;
        public static int currentPage = 1;
        private List<Reserva> GetReservas()
        {
            return database.Reservas
                .Include(x => x.Origen)
                .Include(x => x.Destino)
                .Include(x => x.Plan)
                .Include(x => x.Plan.Icon)
                .ToList();
        }

        private List<Cotizacion> GetCotizaciones()
        {
            return database.Cotizacions
                .Include(x => x.Reserva)
                .Include(x => x.Pasajero)
                .ToList();
        }
        #endregion

        #region IndexView
        public IActionResult Index(int? pageNumber,string sortOrder, string Codigo, string Apellido, string Precio)
        {
             ListaReserva = GetReservas();

            //Evaluacion numeracion de pagina
            currentPage = pageNumber ?? currentPage;
            ViewBag.CodigoSortParm = sortOrder == "Codigo" ? "CodigoDesc" : "Codigo";
            ViewBag.TitularTarjeta = sortOrder == "TitularTarjeta" ? "TitularTarjetaDesc" : "TitularTarjeta";
            ViewBag.EstadoPago = sortOrder == "EstadoPago" ? "EstadoPagoDesc" : "EstadoPago";
            ViewBag.FechaIda = sortOrder == "FechaIda" ? "FechaIdaDesc" : "FechaIda";
            ViewBag.FechaVuelta = sortOrder == "FechaVuelta" ? "FechaVueltaDesc" : "FechaVuelta";
            ViewBag.PlanCodigo = sortOrder == "PlanCodigo" ? "PlanCodigoDesc" : "PlanCodigo";
            ViewBag.PlanNombre = sortOrder == "PlanNombre" ? "PlanNombreDesc" : "PlanNombre";
            ViewBag.Origen = sortOrder == "Origen" ? "OrigenDesc" : "Origen";
            ViewBag.Destino = sortOrder == "Destino" ? "DestinoDesc" : "Destino";
            ViewBag.Total = sortOrder == "Total" ? "TotalDesc" : "Total";
            

            #region CheckeoBusqueda
            if (!(String.IsNullOrEmpty(Codigo)) || !(String.IsNullOrEmpty(Apellido)) || !(String.IsNullOrEmpty(Precio)))
            {
                ListaReserva = FiltrarListaPorBusqueda(Codigo, Apellido, Precio);
            }
            #endregion
        
            return View( new IndexViewModel() { Reservas = GetListOrderByParam(ListaReserva, sortOrder).ToPagedList(currentPage, pageSize) });
        }

        public IActionResult BorrarFiltros()
        {
            ListaReserva = GetReservas();
            return RedirectToAction("Index");
        }

        private static List<Reserva> GetListOrderByParam(List<Reserva> ListaTemporal, string sortOrder)
        {
            switch (sortOrder)
            {
                case "Codigo":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Codigo).ToList();
                    break;
                case "CodigoDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Codigo).ToList();
                    break;
                case "TitularTarjeta":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.TitularTarjeta).ToList();
                    break;
                case "TitularTarjetaDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.TitularTarjeta).ToList();
                    break;
                case "EstadoPago":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.EstadoPago).ToList();
                    break;
                case "EstadoPagoDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.EstadoPago).ToList();
                    break;
                case "FechaIda":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.FechaIda).ToList();
                    break;
                case "FechaIdaDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.FechaIda).ToList();
                    break;
                case "FechaVuelta":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.FechaVuelta).ToList();
                    break;
                case "FechaVueltaDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.FechaVuelta).ToList();
                    break;
                case "PlanCodigo":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Plan.CodigoPlan).ToList();
                    break;
                case "PlanCodigoDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Plan.CodigoPlan).ToList();
                    break;
                case "PlanNombre":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Plan.Nombre).ToList();
                    break;
                case "PlanNombreDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Plan.Nombre).ToList();
                    break;
                case "Origen":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Origen.Nombre).ToList();
                    break;
                case "OrigenDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Origen.Nombre).ToList();
                    break;
                case "Destino":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Destino.Nombre).ToList();
                    break;
                case "DestinoDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Destino.Nombre).ToList();
                    break;
                case "Total":
                    ListaTemporal = ListaTemporal.OrderBy(lista => lista.Total).ToList();
                    break;
                case "TotalDesc":
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.Total).ToList();
                    break;
                default:
                    ListaTemporal = ListaTemporal.OrderByDescending(lista => lista.FechaEmision).ToList();
                    break;
            }

            return ListaTemporal;
        }

        private static List<Reserva> FiltrarListaPorBusqueda(string Codigo, string Apellido, string Precio)
        {
            if (!(String.IsNullOrEmpty(Codigo)))
            {
                ListaReserva = ListaReserva.Where(lista => lista.Codigo.ToUpper().Contains(Codigo.ToUpper())).ToList();
            }

            if (!(String.IsNullOrEmpty(Apellido)))
            {
                ListaReserva = ListaReserva.Where(lista => lista.TitularTarjeta.ToUpper().Contains(Apellido.ToUpper())).ToList();
            }

            if (!(String.IsNullOrEmpty(Precio)))
            {
                if (!Int32.TryParse(Precio, out int parsedPrecio))
                    throw new ArgumentException("Error al parsear.");
                ListaReserva = ListaReserva.Where(lista => lista.Total.Equals(parsedPrecio)).ToList();
            }

            return ListaReserva;
        }

        #endregion  

        #region Create
        public IActionResult Crear()
        {
            ViewBag.IconosPlanes = new SelectList(database.Icons.ToList(), "Id", "NombreIcono");
            ViewBag.Plans = new SelectList(database.Plans.ToList(), "Id", "Nombre");
            ViewBag.Regiones = new SelectList(database.Regions.ToList(), "Id", "Nombre");
            ViewBag.EstadoPago = new SelectList(database.EstadoPagos.ToList(), "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Crear(ReservaCotizacionViewModel ReservaCotizacionesForm)
        {
            if (ModelState.IsValid)
            {
                if (ValidarRepeticionDeCodigo(ReservaCotizacionesForm.Reserva.Codigo)
                    || !DateTime.TryParse(ReservaCotizacionesForm.Reserva.FechaIda_string, new CultureInfo("es-ES"), System.Globalization.DateTimeStyles.None, out DateTime fechaIda)
                    || !DateTime.TryParse(ReservaCotizacionesForm.Reserva.FechaVuelta_string, new CultureInfo("es-ES"), System.Globalization.DateTimeStyles.None, out DateTime fechaVuelta))
                {
                    ModelState.AddModelError("Codigo", "Hubo un en el codigo de la reserva o al seleccionar la fechas");
                }
                else
                {
                    //Crea instancias finales de modelo
                    Reserva ReservaNueva = getReservaFromSubmit(ReservaCotizacionesForm.Reserva, fechaIda, fechaVuelta);
                    List<Cotizacion> ListaCotizaciones = getListaCotizacionesfromSubmit(ReservaCotizacionesForm.Cotizaciones, ReservaNueva.Plan, ReservaNueva.CantidadDiasViaje, ReservaNueva);

                    //Ultimos datos después de que se checkeo la lista de Cotizaciones
                    ReservaNueva.Total = Math.Round(ListaCotizaciones.Sum(x => x.Total), 2);
                    ReservaNueva.CantidadPasajeros = ListaCotizaciones.Count();

                    //Salvar Reserva y obtiene ID
                    database.Reservas.Add(ReservaNueva);
                    database.SaveChanges();

                    ListaCotizaciones.ForEach(cotizacion => {
                        //Salvar Pasajero y obtiene ID
                        database.Pasajeros.Add(cotizacion.Pasajero);
                        database.SaveChanges();                        
                        cotizacion.ReservaId = ReservaNueva.Id;
                        cotizacion.PasajeroId = cotizacion.Pasajero.Id;
                        database.Cotizacions.Add(cotizacion);
                    });
                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            ViewBag.IconosPlanes = new SelectList(database.Icons.ToList(), "Id", "NombreIcono");
            ViewBag.Plans = new SelectList(database.Plans.ToList(), "Id", "Nombre");
            ViewBag.Regiones = new SelectList(database.Regions.ToList(), "Id", "Nombre");
            ViewBag.EstadoPago = new SelectList(database.EstadoPagos.ToList(), "Id", "Nombre");
            return View();
        }
        #endregion

        #region Edit
        public IActionResult Editar(int? id)
        {
            var detalleVM = new ReservaCotizacionViewModel();
            detalleVM.Reserva = GetReservas().Where(x => x.Id == id).FirstOrDefault();
            detalleVM.Cotizaciones = GetCotizaciones().Where(x => x.Reserva.Id == id).ToList();
            ViewBag.IconosPlanes = new SelectList(database.Icons.ToList(), "Id", "NombreIcono");
            ViewBag.Plans = new SelectList(database.Plans.ToList(), "Id", "Nombre");
            ViewBag.Regiones = new SelectList(database.Regions.ToList(), "Id", "Nombre");
            ViewBag.EstadoPago = new SelectList(database.EstadoPagos.ToList(), "Id", "Nombre");
            return View(detalleVM);
        }

        [HttpPost]
        public IActionResult Editar(ReservaCotizacionViewModel ReservaCotizacionesForm)
        {
            if (ModelState.IsValid)
            {
                if  (!DateTime.TryParse(ReservaCotizacionesForm.Reserva.FechaIda_string, new CultureInfo("es-ES"), System.Globalization.DateTimeStyles.None, out DateTime fechaIda)
                    || !DateTime.TryParse(ReservaCotizacionesForm.Reserva.FechaVuelta_string, new CultureInfo("es-ES"), System.Globalization.DateTimeStyles.None, out DateTime fechaVuelta))
                {
                    ModelState.AddModelError("Codigo", "Hubo un error");
                }
                else
                {
                    
                    #region New Images
                    if (String.IsNullOrEmpty(ReservaCotizacionesForm.Reserva.QrRuta) || ReservaCotizacionesForm.Reserva.QR != null)
                    {
                        ReservaCotizacionesForm.Reserva.QrRuta = GetImageRouteAndSave(ReservaCotizacionesForm.Reserva.QR, ReservaCotizacionesForm.Reserva.Codigo, "QRs");
                    }
                    if (String.IsNullOrEmpty(ReservaCotizacionesForm.Reserva.ReciboRuta) || ReservaCotizacionesForm.Reserva.Recibo != null)
                    {
                        ReservaCotizacionesForm.Reserva.ReciboRuta = GetImageRouteAndSave(ReservaCotizacionesForm.Reserva.Recibo, ReservaCotizacionesForm.Reserva.Codigo, "receipts");
                    }
                    if (String.IsNullOrEmpty(ReservaCotizacionesForm.Reserva.DocumentacionRuta) || ReservaCotizacionesForm.Reserva.Documentacion != null)
                    {
                        ReservaCotizacionesForm.Reserva.DocumentacionRuta = GetImageRouteAndSave(ReservaCotizacionesForm.Reserva.Documentacion, ReservaCotizacionesForm.Reserva.Codigo, "documentation");
                    }
                    #endregion

                    //Reseleccion de Plan para obtener nuevo precio base.
                    ReservaCotizacionesForm.Reserva.Plan = (Plan)database.Plans.Where(x => x.Id == ReservaCotizacionesForm.Reserva.PlanId).FirstOrDefault();
                    ReservaCotizacionesForm.Reserva.PrecioBase = ReservaCotizacionesForm.Reserva.Plan.PrecioBaseDia;

                    //Nuevo parseo de Fechas necesario
                    ReservaCotizacionesForm.Reserva.FechaIda = fechaIda;
                    ReservaCotizacionesForm.Reserva.FechaVuelta = fechaVuelta;

                    //Loop por Cotizacion, actualizando Pajasajeros y Cotizaciones Total
                    ReservaCotizacionesForm.Cotizaciones.ForEach(cotizacion => {
                        cotizacion.Total = CalcularTotalCotizacion(cotizacion.Pasajero.MenorDeEdad, cotizacion.CantidadDiasViaje, ReservaCotizacionesForm.Reserva.PrecioBase, ReservaCotizacionesForm.Reserva.ImpuestosPorcentaje, ReservaCotizacionesForm.Reserva.RecargoPorcentaje);
                        database.Update(cotizacion.Pasajero);
                        database.Update(cotizacion);
                    });

                    //Nuevo total a partir de la suma calculada.
                    ReservaCotizacionesForm.Reserva.Total = Math.Round(ReservaCotizacionesForm.Cotizaciones.Sum(x => x.Total), 2);
                    database.Update(ReservaCotizacionesForm.Reserva);

                    database.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.IconosPlanes = new SelectList(database.Icons.ToList(), "Id", "NombreIcono");
            ViewBag.Plans = new SelectList(database.Plans.ToList(), "Id", "Nombre");
            ViewBag.Regiones = new SelectList(database.Regions.ToList(), "Id", "Nombre");
            ViewBag.EstadoPago = new SelectList(database.EstadoPagos.ToList(), "Id", "Nombre");
            return View(ReservaCotizacionesForm.Reserva);
        }
        #endregion

        #region Detalles
        public IActionResult Detalle(int id)
        {
            var detalleVM = new ReservaCotizacionViewModel();
            detalleVM.Reserva = GetReservas().Where(x => x.Id == id).FirstOrDefault();
            detalleVM.Cotizaciones = GetCotizaciones().Where(x => x.Reserva.Id == id).ToList();
            return View(detalleVM);
        }
        #endregion

        #region Delete
        public IActionResult Eliminar(int id)
        {
            //Borrado logico
            var reservaEliminar = GetReservas().Where(x => x.Id == id).FirstOrDefault();
            reservaEliminar.Activa = false;
            database.Reservas.Update(reservaEliminar);
            database.SaveChanges();
            return RedirectToAction("Index");

        }
        #endregion

        #region ValidateCodeRepetition
        private bool ValidarRepeticionDeCodigo(string cod)
        {
            return GetReservas().Exists(x => x.Codigo == cod);
        }
        #endregion

        #region SaveImage
        private string GetImageRouteAndSave(IFormFile Image, string Codigo, string publicFolderName)
        {
            if (Image != null)
            {
                string QRImageName = publicFolderName + "_" + Codigo + "." + Path.GetExtension(Image.FileName).Substring(1);
                string Carpeta = Path.Combine(Hosting.WebRootPath, "images/" + publicFolderName);
                string ImageRouteInDB = "~/images/" + publicFolderName + "/" + QRImageName;
                string RutaDestino = Path.Combine(Carpeta, QRImageName);
                Image.CopyTo(new FileStream(RutaDestino, FileMode.Create));
                return ImageRouteInDB;
            }
            return "";
        }

        #endregion

        #region Utilities

        private Reserva getReservaFromSubmit(Reserva reservaSubmit, DateTime fechaIda, DateTime fechaVuelta)
        {
            Reserva ReservaNueva = reservaSubmit;
            //Modelos
            //ReservaNueva.Origen = (Region)database.Regions.Where(x => x.Id == reservaSubmit.Origen.Id).FirstOrDefault();
            //ReservaNueva.Destino = (Region)database.Regions.Where(x => x.Id == reservaSubmit.Destino.Id).FirstOrDefault();
            ReservaNueva.Plan = (Plan)database.Plans.Where(x => x.Id == reservaSubmit.PlanId).FirstOrDefault();

            //Imagenes
            ReservaNueva.QrRuta = GetImageRouteAndSave(reservaSubmit.QR, reservaSubmit.Codigo, "QRs");
            ReservaNueva.ReciboRuta = GetImageRouteAndSave(reservaSubmit.Recibo, reservaSubmit.Codigo, "receipts");
            ReservaNueva.DocumentacionRuta = GetImageRouteAndSave(reservaSubmit.Documentacion, reservaSubmit.Codigo, "documentation");

            //Calculos e informacion Final

            ReservaNueva.Tarjeta = reservaSubmit.Tarjeta.Substring(reservaSubmit.Tarjeta.Length - 4, 4);
            ReservaNueva.CantidadDiasViaje = 1 + (int)(fechaVuelta - fechaIda).TotalDays;
            ReservaNueva.PrecioBase = ReservaNueva.Plan.PrecioBaseDia;
            ReservaNueva.FechaIda = fechaIda;
            ReservaNueva.FechaVuelta = fechaVuelta;

            return ReservaNueva;
        }
        private bool IsMenorDeEdad(DateTime fechaInicioViaje, DateTime fechaNacimiento)
        {
            var years = (fechaInicioViaje.Year - fechaNacimiento.Year - 1) + (((fechaInicioViaje.Month > fechaNacimiento.Month) ||
                ((fechaInicioViaje.Month == fechaNacimiento.Month) && (fechaInicioViaje.Day >= fechaNacimiento.Day))) ? 1 : 0);
        return years < 17;
        }

        private double CalcularTotalCotizacion(bool menor, int cantidadDias, double precioBase, double impuestosPorcentaje, double recargoPorcentaje)
        {
            double total = cantidadDias * precioBase;
            total += (total * impuestosPorcentaje / 100) + (total * recargoPorcentaje / 100);
            if (menor)
            {
                return total / 2;
            }
            return Math.Round(total, 2); 
        }

        private List<Cotizacion> getListaCotizacionesfromSubmit(List<Cotizacion> ListaForm, Plan PlanForm, int CantidadDiasForm, Reserva ReservaForm)
        {
            var listaCotizacion = new List<Cotizacion>();
            foreach (var cotizacion in ListaForm)
            {
                if (!DateTime.TryParse(cotizacion.Pasajero.FechaNacimiento_string, new CultureInfo("es-ES"), System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    ModelState.AddModelError("Fecha de Nacimiento", "Hubo un error en la fecha de nacimiento del pasajero: " + cotizacion.Pasajero.CodigoID);
                }
                else
                {
                    var CotizacionNueva = new Cotizacion();
                    CotizacionNueva.CantidadDiasViaje = CantidadDiasForm;
                    CotizacionNueva.Pasajero = cotizacion.Pasajero;
                    CotizacionNueva.Pasajero.FechaNacimiento = fechaNacimiento;
                    CotizacionNueva.Pasajero.MenorDeEdad = IsMenorDeEdad(ReservaForm.FechaIda, fechaNacimiento);
                    CotizacionNueva.Total = CalcularTotalCotizacion(CotizacionNueva.Pasajero.MenorDeEdad, CotizacionNueva.CantidadDiasViaje, ReservaForm.Plan.PrecioBaseDia, ReservaForm.ImpuestosPorcentaje, ReservaForm.RecargoPorcentaje);

                    listaCotizacion.Add(CotizacionNueva);
                }
            }
            return listaCotizacion;
        }
        #endregion

    }
}
