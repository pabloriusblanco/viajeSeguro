using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    //[Table("Regiones")] // Nombre de la tabla en la DB

    public class Region
    {
        public int Id { get; set; }

        [Column("Nombre", TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        public string IconoNombre { get; set; }
        //public CodigoRegiones Codigo { get; set; }

        //public string DisplayName()
        //{
        //    return this.Codigo.GetType().GetMember(this.Codigo.ToString()).First().GetCustomAttribute<DisplayAttribute>().GetName();
        //}
    }

    //public enum CodigoRegiones
    //{
    //    [Display(Name = "América del Norte")]
    //    NA,
    //    [Display(Name = "Europa")]
    //    EU,
    //    [Display(Name = "América Central")]
    //    CA,
    //    [Display(Name = "América del Sur")]
    //    SA,
    //    [Display(Name = "África")]
    //    AF,
    //    [Display(Name = "Asia")]
    //    AS,
    //    [Display(Name = "Oceanía")]
    //    OC
    //}
}
