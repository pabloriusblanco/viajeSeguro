#pragma checksum "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddce524bb9c0cc3bfc7dd5d46479f64869132b7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddce524bb9c0cc3bfc7dd5d46479f64869132b7a", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e064eb5c6c219157b722cb9aa667b38c767d5691", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Registro - ViajeSeguro";
    Layout = "_Base";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
 if (!Html.ViewData.ModelState.IsValid)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-danger position-absolute col-md-12 alert_safe fixed-top"" style=""z-index:9999;"">
        <button type=""button"" aria-hidden=""true"" class=""close"" data-dismiss=""alert"" id=""buttonCloseAlert"">
            <i class=""now-ui-icons ui-1_simple-remove""></i>
        </button>
        <div>
            <div class=""mb-2"">Por favor revise los siguientes campos:</div>
            <div");
            BeginWriteAttribute("class", " class=\"", 561, "\"", 569, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 16 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                      Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""wrapper wrapper-full-page "">
    <div class=""full-page login-page section-image login_image"" filter-color=""black"">
        <div class=""content"">
            <div class=""container"">
                <div class=""col-md-4 ml-auto mr-auto"">
");
#nullable restore
#line 30 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                     using (@Html.BeginForm("Register", "Account", FormMethod.Post, new { enctype = "multipart/form-data" }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card card-login card-plain"">
                            <div class=""card-header "">
                                <div class=""logo d-flex flex-column justify-content-center align-items-center"">
                                    <h3 class=""text-white bold mb-0"">Backoffice</h3>
                                    <img");
            BeginWriteAttribute("src", " src=\'", 1638, "\'", 1688, 1);
#nullable restore
#line 36 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
WriteAttributeValue("", 1644, Url.Content("~/images/ViajaSeguroLogo.png"), 1644, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""viajeseguro logo"" class=""sidebarLogo py-3"">
                                </div>
                            </div>
                            <div class=""card-body "">
                                <div class=""input-group no-border form-control-lg"">
                                    <span class=""input-group-prepend"">
                                        <div class=""input-group-text"">
                                            <i class=""fas fa-at""></i>
                                        </div>
                                    </span>
                                    ");
#nullable restore
#line 46 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                               Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control", @placeholder = "Email...", @autocomplete = "off", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""input-group no-border form-control-lg pt-2"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text"">
                                            <i class=""fas fa-unlock""></i>
                                        </div>
                                    </div>
                                    ");
#nullable restore
#line 54 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                               Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control", @placeholder = "Password...", @autocomplete = "off", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""input-group no-border form-control-lg pt-3"">
                                    <div class=""input-group-prepend"">
                                        <div class=""input-group-text"">
                                            <i class=""fas fa-unlock""></i>
                                        </div>
                                    </div>
                                    ");
#nullable restore
#line 62 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                               Write(Html.TextBoxFor(x => x.ConfirmPassword, new { @class = "form-control", @placeholder = "Repita el Password... ", @autocomplete = "off", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""card-footer "">
                                <button type=""submit"" class=""btn btn-primary btn-round btn-lg btn-block mb-3"">Registrar</button>
                                <a");
            BeginWriteAttribute("href", " href=\"", 3979, "\"", 4017, 1);
#nullable restore
#line 67 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
WriteAttributeValue("", 3986, Url.Action("Login", "Account"), 3986, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-secondary btn-round btn-lg btn-block mb-3"">
                                    <i class=""fas fa-arrow-left mr-2"" style=""font-size: 14px;""></i>
                                    Login
                                </a>
                            </div>
                        </div>
");
#nullable restore
#line 73 "C:\Users\Pablo\source\repos\ViajeSeguro\ViajeSeguro\Views\Account\Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
