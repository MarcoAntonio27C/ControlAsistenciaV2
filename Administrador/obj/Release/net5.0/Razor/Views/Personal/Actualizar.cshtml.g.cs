#pragma checksum "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78743a898cf725e336c2d8c9912671970d589694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Actualizar), @"mvc.1.0.view", @"/Views/Personal/Actualizar.cshtml")]
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
#line 1 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
using ControlAsistencia_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78743a898cf725e336c2d8c9912671970d589694", @"/Views/Personal/Actualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84bd8aa5f184b9336eed34c097c70c58346561b", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Actualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/personal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formularioUpdate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Personal-Editar.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
  
    Empleado empleado = (Empleado)ViewData["empleado"];
    DatosEmpleado datosEmpleado = (DatosEmpleado)ViewData["datosEmpleado"];
    var mensaje = ViewData["mensaje"];
    var error = ViewData["error"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78743a898cf725e336c2d8c9912671970d5896946040", async() => {
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
            WriteLiteral("\r\n<div>\r\n    <h5 id=\"titulo\" class=\"text-center py-3 rounded mt-4\">Editar Información Empleado</h5>\r\n    <div class=\"mt-3 border rounded px-3 py-3 bg-light\">\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d5896947362", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 647, "\"", 667, 1);
#nullable restore
#line 15 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 655, empleado.Id, 655, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"row mt-1\">\r\n                <div class=\"col-7\">\r\n                    <label>Nombre Completo</label>\r\n                    <input class=\"form-control\" id=\"nombreCompleto\" type=\"text\" name=\"nombreCompleto\"");
                BeginWriteAttribute("value", " value=\"", 899, "\"", 931, 1);
#nullable restore
#line 19 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 907, empleado.NombreCompleto, 907, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Paterno / Materno / Nombre(s)"" />
                </div>
                <div class=""col-2"">
                    <label>Numero Expediente</label>
                    <input class=""form-control"" type=""text"" id=""numeroExpediente"" name=""numeroExpediente""");
                BeginWriteAttribute("value", " value=\"", 1201, "\"", 1235, 1);
#nullable restore
#line 23 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 1209, empleado.NumeroExpediente, 1209, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1236, "\"", 1250, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    <label>UR</label>\r\n                    <input class=\"form-control\" type=\"text\" id=\"ur\" name=\"ur\"");
                BeginWriteAttribute("value", " value=\"", 1433, "\"", 1453, 1);
#nullable restore
#line 27 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 1441, empleado.UR, 1441, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    <label>Fecha Ingreso</label>\r\n                    <input class=\"form-control\" type=\"text\" id=\"fechaIngreso\" name=\"fechaIngreso\"");
                BeginWriteAttribute("value", " value=\"", 1667, "\"", 1697, 1);
#nullable restore
#line 31 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 1675, empleado.FechaIngreso, 1675, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""dd/mm/aaaa"" />
                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-4"">
                    <label>Municipio:</label>
                    <select class=""form-control"" id=""municipio"" name=""municipio"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969411133", async() => {
#nullable restore
#line 38 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                         Write(datosEmpleado.Municipio);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdMunicipio);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-6"">
                    <label>Inmueble donde labora:</label>
                    <select class=""form-control"" id=""inmueble"" name=""inmueble"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969413358", async() => {
#nullable restore
#line 44 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                        Write(datosEmpleado.Inmueble);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdInmueble);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-2"">
                    <label>Contratación:</label>
                    <select class=""form-control"" id=""contratacion"" name=""contratacion"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969415579", async() => {
#nullable restore
#line 50 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                            Write(datosEmpleado.Contratacion);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdContratacion);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-6"">
                    <label>Unidad Administrativa:</label>
                    <select class=""form-control"" id=""unidadAdministrativa"" name=""unidadAdministrativa"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969417895", async() => {
#nullable restore
#line 58 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                                    Write(datosEmpleado.UnidadAdministrativa);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdUnidadAdministrativa);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-6"">
                    <label>Centro de Trabajo:</label>
                    <select class=""form-control"" id=""centroTrabajo"" name=""centroTrabajo"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969420159", async() => {
#nullable restore
#line 64 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                             Write(datosEmpleado.CentroTrabajo);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdCentroTrabajo);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row mt-3"">
                <div class=""col-4"">
                    <label>Cargo:</label>
                    <select class=""form-control"" id=""cargo"" name=""cargo"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969422432", async() => {
#nullable restore
#line 72 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                     Write(datosEmpleado.Cargo);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdCargo);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-4"">
                    <label>Cargo Homologado:</label>
                    <select class=""form-control"" id=""cargoHomologado"" name=""cargoHomologado"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969424654", async() => {
#nullable restore
#line 78 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                                                               Write(datosEmpleado.CargoHomologado);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
                           WriteLiteral(empleado.IdCargoHomologado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col-4\">\r\n                    <label>Horario</label>\r\n                    <input class=\"form-control\" type=\"text\" id=\"horario\" name=\"horario\"");
                BeginWriteAttribute("value", " value=\"", 4435, "\"", 4460, 1);
#nullable restore
#line 83 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
WriteAttributeValue("", 4443, empleado.Horario, 4443, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 4461, "\"", 4475, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"text-center mt-3\">\r\n                <button id=\"actualizar\" type=\"button\" class=\"btn btn-info py-2 px-4\">Actualizar</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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

<!-- Modal -->
<div class=""modal-ok modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""alert alert-success text-center"" role=""alert"">
                    Cambios Guardados Correctamente
                </div>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78743a898cf725e336c2d8c9912671970d58969429528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 120 "C:\Users\Ast\Source\Repos\MarcoAntonio27C\ControlAsistenciaV2\Administrador\Views\Personal\Actualizar.cshtml"
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
