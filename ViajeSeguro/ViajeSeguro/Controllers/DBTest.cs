using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViajeSeguro.Models;

namespace ViajeSeguro.Controllers
{
    static public class DBTest
    {
        //static List<Reserva> ListaReserva = new()
        //{
        //    new Reserva() { Id = 1, Codigo = "AB2202", Apellido = "Bernardi", EstadoPago = 2, FechaIda_string = "15-09-2021", FechaEmision = new DateTime(2021, 9, 18, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "02-10-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "International Básico", Icon = new Icon() { NombreIcono = "Corona", CodigoIcono = "fa-crown" } }, Origen = new Region() { Nombre = "América del Norte", IconoNombre = "NA" }, Destino = new Region() { Nombre = "Europa", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 2, Codigo = "BC2203", Apellido = "Romanili", EstadoPago = 0, FechaIda_string = "18-09-2021", FechaEmision = new DateTime(2021, 11, 14, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "30-10-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "Premium Gold", Icon = new Icon() { NombreIcono = "Estrella", CodigoIcono = "fa-star" } }, Origen = new Region() { Nombre = "América del Sur", IconoNombre = "NA" }, Destino = new Region() { Nombre = "América del Norte", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 3, Codigo = "AB2204", Apellido = "Gomez", EstadoPago = 1, FechaIda_string = "21-09-2021", FechaEmision = new DateTime(2021, 10, 25, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "01-11-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "International Gold", Icon = new Icon() { NombreIcono = "Corona", CodigoIcono = "fa-crown" } }, Origen = new Region() { Nombre = "Europa", IconoNombre = "NA" }, Destino = new Region() { Nombre = "Europa", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 4, Codigo = "C42205", Apellido = "Fernandez", EstadoPago = 2, FechaIda_string = "21-09-2021", FechaEmision = new DateTime(2021, 10, 28, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "05-10-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "International Standard", Icon = new Icon() { NombreIcono = "Gema", CodigoIcono = "fa-gem" } }, Origen = new Region() { Nombre = "América del Sur", IconoNombre = "NA" }, Destino = new Region() { Nombre = "América Central", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 5, Codigo = "AB2206", Apellido = "Smith", EstadoPago = 0, FechaIda_string = "25-09-2021", FechaEmision = new DateTime(2021, 6, 30, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "01-10-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "Ultimate Cover", Icon = new Icon() { NombreIcono = "Medico", CodigoIcono = "fa-briefcase-medical" } }, Origen = new Region() { Nombre = "América del Sur", IconoNombre = "NA" }, Destino = new Region() { Nombre = "África", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 6, Codigo = "132202", Apellido = "Cantarin", EstadoPago = 2, FechaIda_string = "26-09-2021", FechaEmision = new DateTime(2021, 7, 2, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "15-12-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "Covid Ensurance", Icon = new Icon() { NombreIcono = "Estrella", CodigoIcono = "fa-star" } }, Origen = new Region() { Nombre = "América del Norte", IconoNombre = "NA" }, Destino = new Region() { Nombre = "Asia", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 7, Codigo = "AB2208", Apellido = "Fioro", EstadoPago = 0, FechaIda_string = "27-09-2021", FechaEmision = new DateTime(2021, 8, 3, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "03-19-2022", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "Premium Gold", Icon = new Icon() { NombreIcono = "Gema", CodigoIcono = "fa-gem" } }, Origen = new Region() { Nombre = "América del Sur", IconoNombre = "NA" }, Destino = new Region() { Nombre = "América Central", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //    new Reserva() { Id = 8, Codigo = "AB2209", Apellido = "Fritz", EstadoPago = 1, FechaIda_string = "30-09-2021", FechaEmision = new DateTime(2021, 5, 15, 10, 30, 50), FechaIda = new DateTime(2021, 9, 15), FechaVuelta_string = "31-09-2021", FechaVuelta = new DateTime(2021, 9, 21), Plan = new Plan() { CodigoPlan = "F4", Nombre = "International Básico", Icon = new Icon() { NombreIcono = "Medico", CodigoIcono = "fa-briefcase-medical" } }, Origen = new Region() { Nombre = "América Central", IconoNombre = "NA" }, Destino = new Region() { Nombre = "Oceanía", IconoNombre = "EU" }, Precio = 1234, Activa = true, QrRuta = "~/images/QRs/QRs_testimages.jpg", ReciboRuta = "~/images/receipts/receipts_testimages.jpg", DocumentacionRuta = "~/images/documentation/documentation_testimages.jpg" },
        //};

        static List<Icon> ListaIconosPlanes = new List<Icon>()
        {
            new Icon() {NombreIcono = "Corona", CodigoIcono = "fa-crown"},
            new Icon() {NombreIcono = "Gema", CodigoIcono = "fa-gem"},
            new Icon() {NombreIcono = "Valija", CodigoIcono = "fa-suitcase-rolling"},
            new Icon() {NombreIcono = "Spa", CodigoIcono = "fa-spa"},
            new Icon() {NombreIcono = "Medico", CodigoIcono = "fa-briefcase-medical"},
            new Icon() {NombreIcono = "Premio", CodigoIcono = "fa-award"},
            new Icon() {NombreIcono = "Estrella", CodigoIcono = "fa-star"},
            new Icon() {NombreIcono = "Trofeo", CodigoIcono = "fa-trophy"},
        };

        static readonly List<Region> ListaRegiones = new List<Region>()
        {
            new Region() {Nombre="América del Norte",IconoNombre="NA" },
            new Region() {Nombre="América Central",IconoNombre="CA" },
            new Region() {Nombre="América del Sur",IconoNombre="SA" },
            new Region() {Nombre="Europa",IconoNombre="EU" },
            new Region() {Nombre="Africa",IconoNombre="AF" },
            new Region() {Nombre="Asia",IconoNombre="AS" },
            new Region() {Nombre="Oceania",IconoNombre="OC" }
        };

        //static public List<Reserva> IniciateListaReserva()
        //{
        //    return ListaReserva;
        //}

        //static public void DeleteReservaFromListaReserva(Reserva reservaEncontrada)
        //{
        //    ListaReserva.Remove(reservaEncontrada);
        //}

        //static public void InsertReservaToListaReserva(Reserva nuevaReserva)
        //{
        //    ListaReserva.Add(nuevaReserva);
        //}

        static public List<Icon> IniciateIconosPlanes()
        {
            return ListaIconosPlanes;
        }

        static public List<Region> IniciateListaRegiones()
        {
            return ListaRegiones;
        }
    }
}
