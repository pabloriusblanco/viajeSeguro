using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using X.PagedList;
using Microsoft.AspNetCore.Identity;

namespace ViajeSeguro.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Email: Este campo es requerido")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password: Este campo es requerido")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirmar Password: Este campo es requerido")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Password")]
        [Compare("Password", ErrorMessage = "Los campos de Password deben coincidir.")]
        public string ConfirmPassword { get; set; }
    }
}
