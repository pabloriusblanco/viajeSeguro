#pragma checksum "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7e238cc4a344afe42c471dc4d77040392255227"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alumnos_Crear), @"mvc.1.0.view", @"/Views/Alumnos/Crear.cshtml")]
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
#line 1 "C:\Users\Pablo\source\repos\clase01\clase01\Views\_ViewImports.cshtml"
using clase01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pablo\source\repos\clase01\clase01\Views\_ViewImports.cshtml"
using clase01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e238cc4a344afe42c471dc4d77040392255227", @"/Views/Alumnos/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cf169cf5c90779b0dc5d77ccb10a3332b086c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Alumnos_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Alumno>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Agregando un nuevo Alumno </h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
 using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.LabelFor(alumno => alumno.Legajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.TextBoxFor(alumno => alumno.Legajo, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.LabelFor(alumno => alumno.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 14 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.TextBoxFor(alumno => alumno.Nombre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.LabelFor(alumno => alumno.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.TextBoxFor(alumno => alumno.Apellido, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.LabelFor(alumno => alumno.Dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
       Write(Html.TextBoxFor(alumno => alumno.Dni, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Guardar\"/>\r\n");
#nullable restore
#line 25 "C:\Users\Pablo\source\repos\clase01\clase01\Views\Alumnos\Crear.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Alumno> Html { get; private set; }
    }
}
#pragma warning restore 1591
