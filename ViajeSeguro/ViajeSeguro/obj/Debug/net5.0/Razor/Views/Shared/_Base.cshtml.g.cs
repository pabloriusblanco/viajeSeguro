#pragma checksum "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c607d2f064b411c5b5d2b0d1601fdd91cda68c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Base), @"mvc.1.0.view", @"/Views/Shared/_Base.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c607d2f064b411c5b5d2b0d1601fdd91cda68c", @"/Views/Shared/_Base.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e064eb5c6c219157b722cb9aa667b38c767d5691", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Base : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c607d2f064b411c5b5d2b0d1601fdd91cda68c3609", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />\r\n    <meta name=\"author\" content=\"Pablo Rius Blanco\">\r\n    <title>");
#nullable restore
#line 8 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>

    <!--Fonts and icons-->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"" rel=""stylesheet"">
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css"" rel=""stylesheet"" crossorigin=""anonymous"">

    <!-- CSS -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""/css/now-ui-dashboard.css"" rel=""stylesheet"" />
    <link href=""/css/site.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4c607d2f064b411c5b5d2b0d1601fdd91cda68c5750", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
     if (ViewContext.RouteData.Values["controller"].ToString() == "Account")
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
                     
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"wrapper \" id=\"main_wrapper\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
   Write(await Html.PartialAsync("_SideMenu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"main-panel\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
       Write(await Html.PartialAsync("_topBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
       Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1434, "\'", 1479, 1);
#nullable restore
#line 38 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1440, Url.Content("~/js/core/jquery.min.js"), 1440, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1526, "\'", 1571, 1);
#nullable restore
#line 39 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1532, Url.Content("~/js/core/popper.min.js"), 1532, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1618, "\'", 1666, 1);
#nullable restore
#line 40 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1624, Url.Content("~/js/core/bootstrap.min.js"), 1624, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1713, "\'", 1779, 1);
#nullable restore
#line 41 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1719, Url.Content("~/js/plugins/perfect-scrollbar.jquery.min.js"), 1719, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1826, "\'", 1887, 1);
#nullable restore
#line 42 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1832, Url.Content("~/js/plugins/moment-with-locales.min.js"), 1832, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1911, "\'", 1973, 1);
#nullable restore
#line 43 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 1917, Url.Content("~/js/plugins/bootstrap-datetimepicker.js"), 1917, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 1997, "\'", 2057, 1);
#nullable restore
#line 44 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 2003, Url.Content("~/js/plugins/bootstrap-selectpicker.js"), 2003, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2081, "\'", 2136, 1);
#nullable restore
#line 45 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 2087, Url.Content("~/js/plugins/jquery-jvectormap.js"), 2087, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2160, "\'", 2219, 1);
#nullable restore
#line 46 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 2166, Url.Content("~/js/plugins/jquery.dataTables.min.js"), 2166, 53, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\" charset=\"utf8\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2281, "\'", 2338, 1);
#nullable restore
#line 47 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 2287, Url.Content("~/js/plugins/jasny-bootstrap.min.js"), 2287, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\'", 2362, "\'", 2396, 1);
#nullable restore
#line 48 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
WriteAttributeValue("", 2368, Url.Content("~/js/site.js"), 2368, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text/javascript\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Shared\_Base.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
