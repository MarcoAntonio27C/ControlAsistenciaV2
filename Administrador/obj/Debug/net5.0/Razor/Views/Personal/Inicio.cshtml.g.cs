#pragma checksum "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be6b5f24b0538b494df5684b114a78b05b4dfa2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Inicio), @"mvc.1.0.view", @"/Views/Personal/Inicio.cshtml")]
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
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be6b5f24b0538b494df5684b114a78b05b4dfa2", @"/Views/Personal/Inicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84bd8aa5f184b9336eed34c097c70c58346561b", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Inicio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/personal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Personal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarPorUnidad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuscarGeneral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Incidencias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Empleado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Asistencias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Personal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
  
    ViewData["Title"] = "Inicio";
    List<Empleado> empleados = (List<Empleado>)ViewData["empleados"];
    var rol = User.Claims.ElementAt(2).Value.ToUpper();
    var i = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4be6b5f24b0538b494df5684b114a78b05b4dfa29267", async() => {
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
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/icon?family=Material+Icons\" rel=\"stylesheet\">\r\n<div>\r\n    <h5 id=\"titulo\" class=\"text-center py-3 rounded mt-4\">Empleados</h5>\r\n    <div>\r\n        <div class=\"row py-4\">\r\n            <div class=\"col-10\">\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                 if (rol.Equals("592D923A-9D0B-424C-8BC3-0C42FF72495E"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa210981", async() => {
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-10\">\r\n                            <input class=\"form-control\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 949, "\"", 957, 0);
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
#line 32 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                }
                else 
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa213733", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <div class=\"col-9\">\r\n                                    <input class=\"form-control\" type=\"text\" name=\"nombre\"");
                BeginWriteAttribute("value", " value=\"", 1589, "\"", 1597, 0);
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
#line 45 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
             if (User.IsInRole("77a225a3-1266-4b1f-b11c-504969afa856") || User.IsInRole("9a39bcce-b092-4f90-9de7-9e0fb2137034"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa216946", async() => {
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
#line 53 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
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
                    <th scope=""col"">Nombre Completo</th>
                    <th scope=""col"">N°Expediente</th>
                    <th scope=""col"">Detalles</th>

");
#nullable restore
#line 66 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                     if (User.IsInRole("77a225a3-1266-4b1f-b11c-504969afa856") || User.IsInRole("9a39bcce-b092-4f90-9de7-9e0fb2137034"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th scope=\"col\">Incidencias</th>\r\n                        <th scope=\"col\">Editar</th>\r\n");
#nullable restore
#line 70 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <th scope=\"col\">Asistencias</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 76 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                  
                    foreach (var empleado in empleados)
                    {
                        var actualizar = "Actualizar/?idEmpleado=" + empleado.Id;
                        var asistencias = "/Asistencias/Empleado/?idEmpleado=" + empleado.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 82 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 83 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                           Write(empleado.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 84 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                           Write(empleado.NumeroExpediente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><button data-toggle=\"modal\" data-target=\"#staticBackdrop\" class=\"btn btn-info detalles\"");
            BeginWriteAttribute("id", " id=\"", 3692, "\"", 3709, 1);
#nullable restore
#line 85 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
WriteAttributeValue("", 3697, empleado.Id, 3697, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"material-icons\">description</span></button></td>\r\n");
#nullable restore
#line 86 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                             if (User.IsInRole("77a225a3-1266-4b1f-b11c-504969afa856") || User.IsInRole("9a39bcce-b092-4f90-9de7-9e0fb2137034"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa222376", async() => {
                WriteLiteral("<span class=\"material-icons text-white\">event_note</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idEmpleado", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                                                                                                                         WriteLiteral(empleado.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEmpleado"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idEmpleado", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEmpleado"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                                                                                                                                                      WriteLiteral(DateTime.Now);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mes"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mes", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mes"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 4256, "\"", 4274, 1);
#nullable restore
#line 89 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
WriteAttributeValue("", 4263, actualizar, 4263, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"material-icons\">edit_square</span></a></td>\r\n");
#nullable restore
#line 90 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa226651", async() => {
                WriteLiteral(" <span class=\"material-icons\">calendar_month</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idEmpleado", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                                                                                                                     WriteLiteral(empleado.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEmpleado"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idEmpleado", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idEmpleado"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                                                                                                                                                  WriteLiteral(DateTime.Now);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mes"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mes", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mes"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 94 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
                        i = i + 1;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<!-- Modal -->
<div class=""modal"" id=""staticBackdrop"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header text-center"">
                <h5 class="" text-center"" id=""staticBackdropLabel"">Empleado</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa231185", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col"">
                            <label>Nombre Completo</label>
                            <input readonly class=""form-control"" type=""text"" id=""nombreCompleto"" name=""nombreCompleto""");
                BeginWriteAttribute("value", " value=\"", 5700, "\"", 5708, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Numero de Expediente</label>
                            <input readonly class=""form-control"" type=""text"" id=""numeroExpediente"" name=""numeroExpediente""");
                BeginWriteAttribute("value", " value=\"", 6043, "\"", 6051, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <label>UR</label>\r\n                            <input readonly class=\"form-control\" type=\"text\" id=\"ur\" name=\"ur\"");
                BeginWriteAttribute("value", " value=\"", 6273, "\"", 6281, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Horario</label>
                            <input readonly class=""form-control"" type=""text"" id=""horario"" name=""horario""");
                BeginWriteAttribute("value", " value=\"", 6585, "\"", 6593, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Municipio</label>
                            <input readonly class=""form-control"" type=""text"" id=""municipio"" name=""municipio""");
                BeginWriteAttribute("value", " value=\"", 6903, "\"", 6911, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Inmueble</label>
                            <input readonly class=""form-control"" type=""text"" id=""inmueble"" name=""inmueble""");
                BeginWriteAttribute("value", " value=\"", 7218, "\"", 7226, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Centro de Trabajo</label>
                            <input readonly class=""form-control"" type=""text"" id=""centroTrabajo"" name=""centroTrabajo""");
                BeginWriteAttribute("value", " value=\"", 7552, "\"", 7560, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Unidad Administrativa</label>
                            <input readonly class=""form-control"" type=""text"" id=""unidadAdministrativa"" name=""unidadAdministrativa""");
                BeginWriteAttribute("value", " value=\"", 7904, "\"", 7912, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Cargo</label>
                            <input readonly class=""form-control"" type=""text"" id=""cargo"" name=""cargo""");
                BeginWriteAttribute("value", " value=\"", 8210, "\"", 8218, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cerrar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4be6b5f24b0538b494df5684b114a78b05b4dfa237240", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#nullable restore
#line 177 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Inicio.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
