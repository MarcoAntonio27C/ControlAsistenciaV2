#pragma checksum "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eab6405b8247f26d0bf64fa79259f99c4fca9af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Inicio), @"mvc.1.0.view", @"/Views/Usuarios/Inicio.cshtml")]
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
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\_ViewImports.cshtml"
using Administrador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\_ViewImports.cshtml"
using Administrador.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eab6405b8247f26d0bf64fa79259f99c4fca9af4", @"/Views/Usuarios/Inicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84bd8aa5f184b9336eed34c097c70c58346561b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Inicio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/personal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Personal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarPorUnidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarGeneral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
  
    ViewData["Title"] = "Inicio";
    var usuarios = (List<Usuario>)ViewData["usuarios"];
    var roles = (List<Roles>)ViewData["roles"];
    var UnidadAdministrativa = (List<UnidadAdministrativa>)ViewData["unidades"];
    var rol = User.Claims.ElementAt(2).Value.ToUpper();
    var i = 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eab6405b8247f26d0bf64fa79259f99c4fca9af47290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n\r\n<div>\r\n    <h5 id=\"titulo\" class=\"text-center py-3 rounded mt-4\">Empleados</h5>\r\n    <div>\r\n        <div class=\"row py-4\">\r\n            <div class=\"col-10\">\r\n");
#nullable restore
#line 20 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                 if (rol.Equals("592D923A-9D0B-424C-8BC3-0C42FF72495E"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eab6405b8247f26d0bf64fa79259f99c4fca9af49008", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-10\">\r\n                                <input class=\"form-control\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 1078, "\"", 1086, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Nombre"" />
                            </div>
                            <div class=""col"">
                                <button type=""submit"" class=""btn btn-info my-auto"">Buscar</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eab6405b8247f26d0bf64fa79259f99c4fca9af411792", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-9\">\r\n                                <input class=\"form-control\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 1725, "\"", 1733, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Nombre"" />
                            </div>
                            <div class=""col"">
                                <button type=""submit"" class=""btn btn-info my-auto px-5"">Buscar</button>
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
             if (User.IsInRole("77a225a3-1266-4b1f-b11c-504969afa856") || User.IsInRole("9a39bcce-b092-4f90-9de7-9e0fb2137034"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eab6405b8247f26d0bf64fa79259f99c4fca9af414969", async() => {
                WriteLiteral("Agregar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <hr />
    </div>
    <div>
        <table class=""table text-secondary text-center bg-light"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Administrador</th>
                    <th scope=""col"">Nombre Usuario</th>
                    <th scope=""col"">Unidad Administrativa</th>
                    <th scope=""col"">Rol</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 69 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                  
                    foreach (var usuario in usuarios)
                    {
                        //var actualizar = "Actualizar/?idEmpleado=" + empleado.Id;
                        //var asistencias = "/Asistencias/Empleado/?idEmpleado=" + empleado.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                           Write(usuario.Administrador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                           Write(usuario.NombreUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 78 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                             foreach(var _rol in roles)
                {
                    if (_rol.Id.Equals(Guid.Parse(usuario.IdRol)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 82 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                       Write(_rol.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 83 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                                    break;
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <td>");
#nullable restore
#line 87 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                           Write(usuario.IdRol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 101 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Usuarios\Inicio.cshtml"
                        i = i + 1;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
