#pragma checksum "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc1d589f2fd39d673dc41b0025ee34d6b28ed4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Asistencias), @"mvc.1.0.view", @"/Views/Home/Asistencias.cshtml")]
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
#line 1 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\_ViewImports.cshtml"
using ReporteAsistencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\_ViewImports.cshtml"
using ReporteAsistencia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dc1d589f2fd39d673dc41b0025ee34d6b28ed4b", @"/Views/Home/Asistencias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0b2b75c883210df727cbbab2396fca3f1cebbb7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Asistencias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ReportePDF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" form-control btn btn-info align-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DescargarPDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formtarget", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/asistencias.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
   
    Empleado empleado = (Empleado)ViewData["empleado"];
    //var FechaActual = DateTime.Now.ToString("yyyy-MM-01");
    var FechaActual = DateTime.Now.ToString("yyyy-MM-01");
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <h3 class=""text-center text-secondary"" >Asistencias</h3>
    <div class=""mt-5 px-4 py-4 border rounded"">
        <div class=""row"">
            <div class=""col"">
                <label>Nombre</label>
                <input class=""form-control"" type=""text"" readonly name=""name""");
            BeginWriteAttribute("value", " value=\"", 520, "\"", 544, 1);
#nullable restore
#line 15 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 528, empleado.Nombre, 528, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <label>Apellido Paterno</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 726, "\"", 759, 1);
#nullable restore
#line 19 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 734, empleado.ApellidoPaterno, 734, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <label>Apellido Materno</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 941, "\"", 974, 1);
#nullable restore
#line 23 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 949, empleado.ApellidoMaterno, 949, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-3\">\r\n            <div class=\"col\">\r\n                <label>Numero de Expediente</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1208, "\"", 1242, 1);
#nullable restore
#line 29 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1216, empleado.NumeroExpediente, 1216, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <label>Adscripción</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1419, "\"", 1448, 1);
#nullable restore
#line 33 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1427, empleado.Adscripcion, 1427, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <label>Fecha Ingreso</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1627, "\"", 1657, 1);
#nullable restore
#line 37 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1635, empleado.FechaIngreso, 1635, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <label>Cargo</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1828, "\"", 1851, 1);
#nullable restore
#line 41 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1836, empleado.Cargo, 1836, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n        <hr />\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc1d589f2fd39d673dc41b0025ee34d6b28ed4b11590", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col text-center\">\r\n                        <input type=\"hidden\" name=\"idEmpleado\" id=\"idEmpleado\"");
                BeginWriteAttribute("value", " value=\"", 2127, "\"", 2147, 1);
#nullable restore
#line 51 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2135, empleado.Id, 2135, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <label>Seleccionar Mes:</label>\r\n                        <input class=\"form-control\" type=\"date\" min=\"2020-01-01\" name=\"mes\" id=\"mes\"");
                BeginWriteAttribute("value", " value=\"", 2310, "\"", 2330, 1);
#nullable restore
#line 53 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2318, FechaActual, 2318, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                    <div class=""col text-center"">
                        <label class=""text-white"">.</label>
                        <button id=""Buscar"" type=""button"" class=""form-control btn btn-info"">Consultar Asistencias</button>
                    </div>
                    <div class=""col text-center"">
                        <label class=""text-white"">.</label>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc1d589f2fd39d673dc41b0025ee34d6b28ed4b13489", async() => {
                    WriteLiteral("Generar Reporte");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""alert alert-warning alert-dismissible fade show mt-3"" role=""alert"">
            No hay registros de asistencias.
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""my-5"">
            <table id=""tabla"" class=""table table-hover w-90 m-auto"">
                <thead class=""text-secondary text-center"">
                    <tr>
                        <th scope=""col"">Dia</th>
                        <th scope=""col"">Entrada</th>
                        <th scope=""col"">Salida Comida</th>
                        <th scope=""col"">Entrada Comida</th>
                        <th scope=""col"">Salida</th>
                    </tr>
                </thead>
                <tbody class=""text-center"">
                </tbody>
            </table>
        </div>

    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dc1d589f2fd39d673dc41b0025ee34d6b28ed4b17564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 91 "C:\Users\Marco Antonio C\source\repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
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
