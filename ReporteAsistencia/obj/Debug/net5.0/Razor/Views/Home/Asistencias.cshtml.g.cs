#pragma checksum "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d9d101f1e12e26cc302739943b29ea44d685119"
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
#line 1 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\_ViewImports.cshtml"
using ReporteAsistencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\_ViewImports.cshtml"
using ReporteAsistencia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d9d101f1e12e26cc302739943b29ea44d685119", @"/Views/Home/Asistencias.cshtml")]
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
#line 2 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
   
    DatosEmpleado empleado = (DatosEmpleado)ViewData["empleado"];
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
            <div class=""col-6"">
                <label>Nombre Completo</label>
                <input class=""form-control"" type=""text"" readonly name=""name""");
            BeginWriteAttribute("value", " value=\"", 541, "\"", 573, 1);
#nullable restore
#line 15 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 549, empleado.NombreCompleto, 549, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-3\">\r\n                <label>Numero de Expediente</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 761, "\"", 795, 1);
#nullable restore
#line 19 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 769, empleado.NumeroExpediente, 769, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-3\">\r\n                <label>Contratación</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 975, "\"", 1005, 1);
#nullable restore
#line 23 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 983, empleado.Contratacion, 983, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-2\">\r\n\r\n            <div class=\"col\">\r\n                <label>Fecha Ingreso</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1234, "\"", 1264, 1);
#nullable restore
#line 30 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1242, empleado.FechaIngreso, 1242, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <label>Centro Trabajo</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1446, "\"", 1477, 1);
#nullable restore
#line 34 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1454, empleado.CentroTrabajo, 1454, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n                <label>Cargo</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1650, "\"", 1673, 1);
#nullable restore
#line 39 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1658, empleado.Cargo, 1658, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row mt-2\">\r\n            <div class=\"col-2\">\r\n                <label>UR</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1893, "\"", 1913, 1);
#nullable restore
#line 46 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 1901, empleado.UR, 1901, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <label>Horario</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2088, "\"", 2113, 1);
#nullable restore
#line 50 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2096, empleado.Horario, 2096, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <label>Unidad Administrativa</label>\r\n                <input class=\"form-control\" type=\"text\" readonly name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 2302, "\"", 2340, 1);
#nullable restore
#line 54 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2310, empleado.UnidadAdministrativa, 2310, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n        <hr />\r\n\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9d101f1e12e26cc302739943b29ea44d68511912896", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col text-center\">\r\n                        <input type=\"hidden\" name=\"idEmpleado\" id=\"idEmpleado\"");
                BeginWriteAttribute("value", " value=\"", 2615, "\"", 2635, 1);
#nullable restore
#line 64 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2623, empleado.Id, 2623, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <label>Seleccionar Mes:</label>\r\n                        <input class=\"form-control\" type=\"date\" min=\"2022-01-01\" name=\"mes\" id=\"mes\"");
                BeginWriteAttribute("value", " value=\"", 2798, "\"", 2818, 1);
#nullable restore
#line 66 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
WriteAttributeValue("", 2806, FechaActual, 2806, 12, false);

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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9d101f1e12e26cc302739943b29ea44d68511914795", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9d101f1e12e26cc302739943b29ea44d68511918870", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 104 "C:\Users\Marco Antonio C\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\ReporteAsistencia\Views\Home\Asistencias.cshtml"
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
