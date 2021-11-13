using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViajeSeguro.Models
{
    public class Pasajero
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre: Este campo es requerido")]
        [MinLength(1, ErrorMessage = "Nombre: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(255, ErrorMessage = "Nombre: Por favor ingresar como máximo 255 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellido: Este campo es requerido")]
        [MinLength(1, ErrorMessage = "Apellido: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(255, ErrorMessage = "Apellido: Por favor ingresar como máximo 255 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Email: Este campo es requerido")]
        [MinLength(4, ErrorMessage = "Email: Por favor ingresar como mínimo 4 caracteres")]
        [MaxLength(255, ErrorMessage = "Email: Por favor ingresar como máximo 255 caracteres")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MinLength(4, ErrorMessage = "Telefono: Por favor ingresar como mínimo 4 números")]
        [MaxLength(40, ErrorMessage = "Telefono: Por favor ingresar como máximo 40 números")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [MinLength(4, ErrorMessage = "Movil: Por favor ingresar como mínimo 4 números")]
        [MaxLength(40, ErrorMessage = "Movil: Por favor ingresar como máximo 40 números")]
        [Display(Name = "Movil")]
        public string Movil { get; set; }

        [Required(ErrorMessage = "Código ID: Este campo es requerido")]
        [MinLength(4, ErrorMessage = "Código ID: Por favor ingresar como mínimo 4 caracteres")]
        [MaxLength(40, ErrorMessage = "Código ID: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Código ID")]
        public string CodigoID { get; set; }

        [Required(ErrorMessage = "ID Tipo: Este campo es requerido")]
        [MinLength(1, ErrorMessage = "ID Tipo: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(20, ErrorMessage = "ID Tipo: Por favor ingresar como máximo 20 caracteres")]
        [Display(Name = "ID Tipo")]
        public string TipoID { get; set; }

        #region FechaNacimiento

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Fecha Inicio: Este campo es requerido")]
        public string FechaNacimiento_string { get; set; }

        public bool MenorDeEdad { get; set; } = false;
        #endregion

        [Required(ErrorMessage = "Pais Nacionalidad: Este campo es requerido")]
        [MinLength(4, ErrorMessage = "Pais Nacionalidad: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Pais Nacionalidad: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Pais Nacionalidad")]
        public string PaisNacionalidad { get; set; }

        [MinLength(4, ErrorMessage = "Calle y Dirección: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Calle y Dirección: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Calle y Dirección")]
        public string DireccionCalle { get; set; }

        [MinLength(4, ErrorMessage = "Código Postal: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Código Postal: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Código Postal")]
        public string CodigoPostal { get; set; }

        [MinLength(4, ErrorMessage = "Ciudad: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Ciudad: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [MinLength(4, ErrorMessage = "Estado: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Estado: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Pais de Residencia: Este campo es requerido")]
        [MinLength(4, ErrorMessage = "Pais de Residencia: Por favor ingresar como mínimo 1 caracter")]
        [MaxLength(40, ErrorMessage = "Pais de Residencia: Por favor ingresar como máximo 40 caracteres")]
        [Display(Name = "Pais de Residencia")]
        public string PaisResidencia { get; set; }

    }
}
