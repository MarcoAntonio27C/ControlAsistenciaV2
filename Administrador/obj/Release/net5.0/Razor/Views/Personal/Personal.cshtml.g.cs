#pragma checksum "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "708a1c81d27acd3681afead82dc8307f304611aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Personal), @"mvc.1.0.view", @"/Views/Personal/Personal.cshtml")]
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
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"708a1c81d27acd3681afead82dc8307f304611aa", @"/Views/Personal/Personal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84bd8aa5f184b9336eed34c097c70c58346561b", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Personal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/personal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Personal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buscar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Personal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
  
    ViewData["Title"] = "Personal";
    List<Empleado> empleados = (List<Empleado>)ViewData["empleados"];
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "708a1c81d27acd3681afead82dc8307f304611aa7537", async() => {
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
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
<div>
    <h5 id=""titulo"" class=""text-center py-3 rounded mt-4"">Empleados</h5>
    <div>
        <div class=""row py-4"">
            <div class=""col-9"">
                <input class=""form-control"" type=""text"" name=""nombreCompleto""");
            BeginWriteAttribute("value", " value=\"", 543, "\"", 551, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Nombre\" />\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708a1c81d27acd3681afead82dc8307f304611aa9235", async() => {
                WriteLiteral("Buscar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708a1c81d27acd3681afead82dc8307f304611aa10754", async() => {
                WriteLiteral("Agregar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <hr />
    </div>

    <div>
        <table class=""table text-secondary text-center bg-light"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Nombre Completo</th>
                    <th scope=""col"">N??Expediente</th>
                    <th scope=""col"">Detalles</th>
                    <th scope=""col"">Editar</th>
                    <th scope=""col"">Asistencias</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 40 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
                  
                    foreach (var empleado in empleados)
                    {
                        var actualizar = "Actualizar/?idEmpleado=" + empleado.Id;
                        var asistencias = "/Asistencias/Empleado/?idEmpleado=" + empleado.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
                           Write(empleado.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
                           Write(empleado.NumeroExpediente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><button data-toggle=\"modal\" data-target=\"#staticBackdrop\" class=\"btn btn-info detalles\"");
            BeginWriteAttribute("id", " id=\"", 2043, "\"", 2060, 1);
#nullable restore
#line 49 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
WriteAttributeValue("", 2048, empleado.Id, 2048, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"material-icons\">description</span></button></td>\r\n                            <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2181, "\"", 2199, 1);
#nullable restore
#line 50 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
WriteAttributeValue("", 2188, actualizar, 2188, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"material-icons\">edit_square</span></a></td>\r\n                            <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2315, "\"", 2334, 1);
#nullable restore
#line 51 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
WriteAttributeValue("", 2322, asistencias, 2322, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <span class=\"material-icons\">calendar_month</span></a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
                    i = i + 1;
                }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708a1c81d27acd3681afead82dc8307f304611aa16911", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col"">
                            <label>Nombre Completo</label>
                            <input readonly class=""form-control"" type=""text"" id=""nombreCompleto"" name=""nombreCompleto""");
                BeginWriteAttribute("value", " value=\"", 3495, "\"", 3503, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Numero de Expediente</label>
                            <input readonly class=""form-control"" type=""text"" id=""numeroExpediente"" name=""numeroExpediente""");
                BeginWriteAttribute("value", " value=\"", 3838, "\"", 3846, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <label>UR</label>\r\n                            <input readonly class=\"form-control\" type=\"text\" id=\"ur\" name=\"ur\"");
                BeginWriteAttribute("value", " value=\"", 4068, "\"", 4076, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Horario</label>
                            <input readonly class=""form-control"" type=""text"" id=""horario"" name=""horario""");
                BeginWriteAttribute("value", " value=\"", 4380, "\"", 4388, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Municipio</label>
                            <input readonly class=""form-control"" type=""text"" id=""municipio"" name=""municipio""");
                BeginWriteAttribute("value", " value=\"", 4698, "\"", 4706, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Inmueble</label>
                            <input readonly class=""form-control"" type=""text"" id=""inmueble"" name=""inmueble""");
                BeginWriteAttribute("value", " value=\"", 5013, "\"", 5021, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Centro de Trabajo</label>
                            <input readonly class=""form-control"" type=""text"" id=""centroTrabajo"" name=""centroTrabajo""");
                BeginWriteAttribute("value", " value=\"", 5347, "\"", 5355, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Unidad Administrativa</label>
                            <input readonly class=""form-control"" type=""text"" id=""unidadAdministrativa"" name=""unidadAdministrativa""");
                BeginWriteAttribute("value", " value=\"", 5699, "\"", 5707, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col"">
                            <label>Cargo</label>
                            <input readonly class=""form-control"" type=""text"" id=""cargo"" name=""cargo""");
                BeginWriteAttribute("value", " value=\"", 6005, "\"", 6013, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cerrar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "708a1c81d27acd3681afead82dc8307f304611aa22965", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 136 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Personal.cshtml"
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
