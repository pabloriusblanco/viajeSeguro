using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class Reserva
    {
        #region Id
        [Display(Name = "Id")]
        public int Id { get; set; }
        #endregion

        #region Codigo
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Codigo: Este campo es requerido")]
        [MinLength(4, ErrorMessage = "Codigo: Por favor ingresar como mínimo 4 caracterees")]
        [MaxLength(20, ErrorMessage = "Codigo: Por favor ingresar como máximo 20 caracteres")]
        //[RegularExpression("([a-zA-Z0-9_ .&'-]+)", ErrorMessage = "Por favor ingresar solo caracteres alfanuméricos.")]
        public string Codigo { get; set; }
        #endregion
        public int CantidadPasajeros { get; set; }

        #region Pago
        [Display(Name = "Titular Tarjeta")]
        [Required(ErrorMessage = "Titular Tarjeta: Este campo es requerido")]
        [MinLength(1, ErrorMessage = "Titular Tarjeta: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(30, ErrorMessage = "Titular Tarjeta: Por favor ingresar como máximo 30 caracteres")]
        public string TitularTarjeta { get; set; }

        public int EstadoPagoId { get; set; }
        [Display(Name = "Estado Pago")]
        public virtual EstadoPago EstadoPago{ get; set; }

        [Display(Name = "Tarjeta Numero")]
        [Required(ErrorMessage = "Tarjeta Numero: Este campo es requerido")]
        [StringLength(19, ErrorMessage = "Tarjeta Numero: Por favor ingresar 16 dígitos")]
        public string Tarjeta { get; set; }
        #endregion

        #region FechaEmision
        public DateTime FechaEmision { get; set; } = DateTime.Now;        
        #endregion

        #region FechaIda
        [Display(Name = "Fecha Ida")]
        public DateTime FechaIda { get; set; }

        [Required(ErrorMessage = "Fecha Inicio: Este campo es requerido")]
        public string FechaIda_string { get; set; }
        #endregion

        #region FechaVuelta
        [Display(Name = "Fecha Vuelta")]
        public DateTime FechaVuelta { get; set; }

        [Required(ErrorMessage = "Fecha Regreso: Este campo es requerido")]
        public string FechaVuelta_string { get; set; }
        #endregion

        #region CantidadDiasViaje
        public int CantidadDiasViaje { get; set; }
        #endregion

        #region Plan   
        public int PlanId { get; set; }
        public virtual Plan Plan { get; set; }
        #endregion

        #region OrigenRegion
        [Display(Name = "Region Origen")]
        [Required(ErrorMessage = "Origen: Este campo es requerido")]
        public int OrigenId { get; set; }
        public virtual Region Origen { get; set; }
        #endregion

        #region DestinoRegion
        [Display(Name = "Region destino")]
        [Required(ErrorMessage = "Destino: Este campo es requerido")]
        public int DestinoId { get; set; }
        public virtual Region Destino { get; set; }
        #endregion

        #region Precio
 
        public double PrecioBase { get; set; }

        //[Display(Name = "Recargo")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Recargo: Por favor ingresar solo numeros")]
        //[Range(0, Int32.MaxValue, ErrorMessage = "Recargo: Debe ingresar un numero mayor a 1")]
        public double RecargoPorcentaje { get; set; } = 0;

        //[Display(Name = "Impuestos")]
        //[RegularExpression("([1-9][0-9]*)", ErrorMessage = "Impuestos: Por favor ingresar solo numeros")]
        //[Range(1, Int32.MaxValue, ErrorMessage = "Impuestos: Debe ingresar un numero mayor a 1")]
        public double ImpuestosPorcentaje { get; set; } = 15;

        [Display(Name = "Total")]
        public double Total { get; set; } = 1;
        #endregion

        public bool Activa { get; set; } = true;

        public string QrRuta { get; set; }

        [NotMapped()]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile QR { get; set; }

        public string ReciboRuta { get; set; }

        [NotMapped()]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile Recibo { get; set; }

        public string DocumentacionRuta { get; set; }

        [NotMapped()]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile Documentacion { get; set; }

    }
}
