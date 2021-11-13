using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clase01.Models;

namespace clase01.Controllers
{
    public class Alumnos : Controller
    {
        static List<Alumno> ListaAlumnos = new List<Alumno>()
        {
            new Alumno(){Legajo=11111,Apellido="Flores",Nombre="Marcela",Dni=11112 },
            new Alumno(){Legajo=22222,Apellido="Mancini",Nombre="Luis",Dni=77777 },
            new Alumno(){Legajo=33333,Apellido="Martinez",Nombre="Marina",Dni=88888 },
            new Alumno(){Legajo=44444,Apellido="Rosati",Nombre="Juan",Dni=99999 },
        };

        public IActionResult Index()
        {
            List<Alumno> listaOrdenada = ListaAlumnos.OrderBy(lista => lista.Legajo).ToList();
            return View(listaOrdenada);
        }

        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Editar(int Legajo)
        {
            Alumno alumnoBuscado = ListaAlumnos.Where(alumno => alumno.Legajo == Legajo).FirstOrDefault();
            ViewBag.Titulo = "Estamos editando a: " + alumnoBuscado.Nombre;
            ViewBag.Mensaje = "Este mensaje se envio desde el controlador";
            ViewData["Mensaje2"] = "Este es un mensaje enviado con ViewData";

            int javascriptInfinity = 3 / 0;
            return View(alumnoBuscado);
        }

        [HttpPost]
        public IActionResult Editar(Alumno alumnoForm)
        {
            Alumno alumnoEditado = ListaAlumnos.Where(alumno => alumno.Legajo == alumnoForm.Legajo).FirstOrDefault();
            ListaAlumnos.Remove(alumnoEditado);
            ListaAlumnos.Add(alumnoForm);
            return RedirectToAction("Index");
        }


        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Alumno alumnoForm)
        {
            ListaAlumnos.Add(alumnoForm);
            return RedirectToAction("Index");
        }
    }
}
