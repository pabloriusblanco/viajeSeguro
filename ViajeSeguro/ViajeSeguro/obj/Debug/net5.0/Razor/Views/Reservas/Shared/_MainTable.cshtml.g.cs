#pragma checksum "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08b72caf77133354748b94338aff52e8a05a4a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservas_Shared__MainTable), @"mvc.1.0.view", @"/Views/Reservas/Shared/_MainTable.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\_ViewImports.cshtml"
using ViajeSeguro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\_ViewImports.cshtml"
using ViajeSeguro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08b72caf77133354748b94338aff52e8a05a4a2e", @"/Views/Reservas/Shared/_MainTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e064eb5c6c219157b722cb9aa667b38c767d5691", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservas_Shared__MainTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table"">
        <thead class=""h6"">
            <tr>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Codigo</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 10 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 611, 1);
#nullable restore
#line 12 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 541, Url.Action("Index", null, new { sortOrder = ViewBag.CodigoSortParm }), 541, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 13 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.CodigoSortParm, "Codigo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                </a>\r\n");
#nullable restore
#line 15 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Titular Tarjeta</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 23 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1370, 1);
#nullable restore
#line 25 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 1300, Url.Action("Index", null, new { sortOrder = ViewBag.TitularTarjeta }), 1300, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 26 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.TitularTarjeta, "TitularTarjeta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 28 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Pago</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 36 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2048, "\"", 2121, 1);
#nullable restore
#line 38 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 2055, Url.Action("Index", null, new { sortOrder = ViewBag.EstadoPago }), 2055, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 39 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.EstadoPago, "EstadoPago"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 41 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Fecha Ida</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 49 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 2796, "\"", 2867, 1);
#nullable restore
#line 51 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 2803, Url.Action("Index", null, new { sortOrder = ViewBag.FechaIda }), 2803, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 52 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.FechaIda, "FechaIda"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 54 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Fecha Vuelta</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 62 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 3541, "\"", 3615, 1);
#nullable restore
#line 64 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 3548, Url.Action("Index", null, new { sortOrder = ViewBag.FechaVuelta }), 3548, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 65 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.FechaVuelta, "FechaVuelta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 67 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Plan Código</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 75 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 4294, "\"", 4367, 1);
#nullable restore
#line 77 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 4301, Url.Action("Index", null, new { sortOrder = ViewBag.PlanCodigo }), 4301, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 78 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.PlanCodigo, "PlanCodigo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 80 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Plan Nombre</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 88 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 5044, "\"", 5117, 1);
#nullable restore
#line 90 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 5051, Url.Action("Index", null, new { sortOrder = ViewBag.PlanNombre }), 5051, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 91 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.PlanNombre, "PlanNombre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 93 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Origen</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 101 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 5789, "\"", 5858, 1);
#nullable restore
#line 103 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 5796, Url.Action("Index", null, new { sortOrder = ViewBag.Origen }), 5796, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 104 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.Origen, "Origen"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 106 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pr-4"">
                    <div class=""d-flex align-items-center"">
                        <div class=""mr-2"">Destino</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 114 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 6523, "\"", 6593, 1);
#nullable restore
#line 116 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 6530, Url.Action("Index", null, new { sortOrder = ViewBag.Destino }), 6530, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 117 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.Destino, "Destino"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 119 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </th>
                <th scope=""col"" class=""text-truncate pl-4 text-right"">
                    <div class=""d-flex align-items-center justify-content-end text-right"">
                        <div class=""mr-2"">Total</div>
                        <div class=""d-flex flex-column"" style=""font-size:8px;"">
");
#nullable restore
#line 127 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 7300, "\"", 7368, 1);
#nullable restore
#line 129 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 7307, Url.Action("Index", null, new { sortOrder = ViewBag.Total }), 7307, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 130 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(getSortOrderIcon(ViewBag.Total, "Total"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n");
#nullable restore
#line 132 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </th>\r\n");
#nullable restore
#line 136 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                 if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"col\" class=\"text-truncate pl-4 text-right\">Acciones</th>\r\n");
#nullable restore
#line 139 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 143 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
             if (Model.Count != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                 foreach (var Reserva in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                     if (Reserva.Activa)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8159, "\"", 8223, 1);
#nullable restore
#line 152 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 8166, Url.Action("Detalle","Reservas", new {id= @Reserva.Id }), 8166, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bold text-primary\">\r\n                                    ");
#nullable restore
#line 153 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(Reserva.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 156 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                           Write(Reserva.TitularTarjeta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            ");
#nullable restore
#line 157 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                       Write(getEstadoColoresYTexto(@Reserva.EstadoPagoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td class=\"text-truncate\">\r\n                                ");
#nullable restore
#line 159 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                           Write(Reserva.FechaIda.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-truncate\">\r\n                                ");
#nullable restore
#line 162 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                           Write(Reserva.FechaVuelta.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"d-flex align-items-center\">\r\n                                    <i");
            BeginWriteAttribute("class", " class=\"", 9005, "\"", 9052, 3);
            WriteAttributeValue("", 9013, "mr-2", 9013, 4, true);
            WriteAttributeValue(" ", 9017, "fas", 9018, 4, true);
#nullable restore
#line 166 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue(" ", 9021, Reserva.Plan.Icon.CodigoIcono, 9022, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                    ");
#nullable restore
#line 167 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                               Write(Reserva.Plan.CodigoPlan);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"text-truncate\">");
#nullable restore
#line 170 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                                                 Write(Reserva.Plan.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-truncate\">\r\n                                <img class=\"mr-2\"");
            BeginWriteAttribute("src", " src=", 9383, "", 9464, 1);
#nullable restore
#line 172 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 9388, Url.Content("~/images/icons/globe/" + @Reserva.Origen.IconoNombre + ".svg"), 9388, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"14\" width=\"14\" />\r\n                                ");
#nullable restore
#line 173 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                           Write(Reserva.Origen.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-truncate\">\r\n                                <img class=\"mr-2\"");
            BeginWriteAttribute("src", " src=", 9688, "", 9770, 1);
#nullable restore
#line 176 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 9693, Url.Content("~/images/icons/globe/" + @Reserva.Destino.IconoNombre + ".svg"), 9693, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"14\" width=\"14\" />\r\n                                ");
#nullable restore
#line 177 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                           Write(Reserva.Destino.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-truncate text-right\">$");
#nullable restore
#line 179 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                                                             Write(Reserva.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 180 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                             if (ViewContext.RouteData.Values["controller"].ToString() == "Reservas")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <div class=\"d-flex justify-content-end\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 10269, "\"", 10321, 1);
#nullable restore
#line 184 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
WriteAttributeValue("", 10276, Url.Action("Editar", new {id= @Reserva.Id }), 10276, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning rounded-pill btn-sm mr-2"">
                                            <i class=""fas fa-edit"" style=""font-size: 14px;""></i>
                                        </a>
                                        <button data-target=""#deleteModal"" data-toggle=""modal"" data-code=""");
#nullable restore
#line 187 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                                                                                                     Write(Reserva.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                data-path=\"");
#nullable restore
#line 188 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                                                      Write(Url.Action("Eliminar", new {id= @Reserva.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-danger rounded-pill btn-sm deleteReserva"">
                                            <i class=""fas fa-times px-1"" style=""font-size: 14px;""></i>
                                        </button>
                                    </div>
                                </td>
");
#nullable restore
#line 193 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 195 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 196 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"11\">\r\n                        <div class=\"w-100 h6 mt-5 text-center\">No se encontraron resultados</div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 205 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- Delete Modal-->
<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">
                    <i class=""now-ui-icons ui-1_simple-remove""></i>
                </button>
                <div class=""w-100 text-center"">
                    <svg viewBox=""0 0 24 24"" stroke=""currentColor"" stroke-width=""2"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-danger col-2"">
                        <circle cx=""12"" cy=""12"" r=""10""></circle>
                        <line x1=""15"" y1=""9"" x2=""9"" y2=""15""></line>
                        <line x1=""9"" y1=""9"" x2=""15"" y2=""15""></line>
                    </svg>
                    <h4 class=""title title-up ml-2"">¡Atención!</h4>");
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-body"">
                <p class=""text-center"">
                    ¿Está seguro que desea eliminar la reserva <span class=""bold text-danger"" id=""codigoReservaSpan""></span>?
                    <br>
                    <span");
            BeginWriteAttribute("class", " class=\"", 12751, "\"", 12759, 0);
            EndWriteAttribute();
            WriteLiteral(@">Esta acción no se puede deshacer.</span>
                </p>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default btn-round"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-danger btn-round"" data-dismiss=""modal"" id=""btnContinueDelete"">Eliminar</button>
            </div>
        </div>
    </div>
</div>




");
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 247 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
 
    public string getEstadoColoresYTexto(int EstadoPagoId)
    {
        switch (EstadoPagoId)
        {
            case 1:

#line default
#line hidden
#nullable disable
        WriteLiteral("                <td class=\"bold truncate text-danger\">\r\n                    Rechazado\r\n                </td>\r\n");
#nullable restore
#line 256 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                break;
            case 2:

#line default
#line hidden
#nullable disable
        WriteLiteral("                <td class=\"bold truncate text-warning\">\r\n                    Procesando\r\n                </td>\r\n");
#nullable restore
#line 261 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                break;
            case 3:

#line default
#line hidden
#nullable disable
        WriteLiteral("                <td class=\"bold truncate text-success\">\r\n                    Confirmado\r\n                </td>\r\n");
#nullable restore
#line 266 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
                break;
            default:
                break;
        }

        return string.Empty;
    }

    public string getSortOrderIcon(string viewBagValue, string defaultOrder)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 277 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
         if (viewBagValue == defaultOrder || viewBagValue == null)
        {

#line default
#line hidden
#nullable disable
        WriteLiteral("            <i class=\"fas fa-chevron-up order_icon order_asc\" style=\"cursor: pointer;\"></i>\r\n");
#nullable restore
#line 280 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
        WriteLiteral("            <i class=\"fas fa-chevron-up order_icon order_asc\" style=\"cursor: pointer; transform: rotate(180deg);\"></i>\r\n");
#nullable restore
#line 284 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 284 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Reservas\Shared\_MainTable.cshtml"
         

        return string.Empty;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
