#pragma checksum "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\Referencias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c01122cc226124dfcfcda2b3a2c4971d28458b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Work_IO.Pages.WorkIO.Pages_WorkIO_Referencias), @"mvc.1.0.razor-page", @"/Pages/WorkIO/Referencias.cshtml")]
namespace Work_IO.Pages.WorkIO
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
#line 1 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\_ViewImports.cshtml"
using Work_IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c01122cc226124dfcfcda2b3a2c4971d28458b", @"/Pages/WorkIO/Referencias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83d329f3d6bcfa1ba4fcd7122dba73cb5c1162c3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkIO_Referencias : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\Referencias.cshtml"
  
    ViewData["Title"] = "Referencias";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<div class=""container-fluid"">
    <section class=""container"">
        <div class=""container-page"">
            <h3 class=""dark-grey"">Agregar Referencias</h3>
            <div class=""col-md-6"">

                <div class=""form-group col-lg-6"">
                    <label for=""empresa"">Nombre de la empresa:</label>
                    <input type=""text"" name=""NameEmpresa"" class=""form-control""");
            BeginWriteAttribute("id", " id=\"", 826, "\"", 831, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 832, "\"", 840, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label>Telefono</label>\r\n                    <input type=\"tel\" name=\"Telefono\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1040, "\"", 1045, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1046, "\"", 1054, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-12\">\r\n                    <label for=\"direccion\">Direccion</label>\r\n                    <input type=\"text\" name=\"Direccion\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1274, "\"", 1279, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1280, "\"", 1288, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"nameInformante\">Nombre del informante</label>\r\n                    <input type=\"text\" name=\"NameInformante\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 1529, "\"", 1534, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1535, "\"", 1543, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <div class=""form-group col-lg-6"">
                    <label for=""nameJefe"">Nombre del Jefe</label>
                    <input type=""text"" id=""nameJefe"" class=""form-control"" name=""nameJefe"">
                </div>

                <div class=""form-group col-lg-6"">
                    <label for=""puestoInformante"">Puesto del informante</label>
                    <input type=""text"" name=""puestoInformante"" class=""form-control""");
            BeginWriteAttribute("id", " id=\"", 2024, "\"", 2029, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2030, "\"", 2038, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"puestoJefe\">Puesto del jefe</label>\r\n                    <input type=\"text\" name=\"puestoJefe\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 2265, "\"", 2270, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2271, "\"", 2279, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"puestoCandidato\">Puesto del candidato</label>\r\n                    <input type=\"text\" name=\"nacionalidad\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 2518, "\"", 2523, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2524, "\"", 2532, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"sueldo\">Sueldo Mensual</label>\r\n                    <input type=\"text\" name=\"sueldo\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 2750, "\"", 2755, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2756, "\"", 2764, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>


            </div>

            <div class=""col-md-6"">

                

                <div class=""form-group col-lg-6"">
                    <label>Inicio de labores:</label>
                    <input type=""date"" id=""inicioLabores"" class=""form-control""");
            BeginWriteAttribute("name", " name=\"", 3060, "\"", 3067, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label>Fin de labores:</label>\r\n                    <input type=\"date\" id=\"finLabores\" class=\"form-control\"");
            BeginWriteAttribute("name", " name=\"", 3275, "\"", 3282, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"tipoContrato\">Tipo de contrato</label>\r\n                    <input type=\"text\" name=\"tipoContrato\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 3514, "\"", 3519, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3520, "\"", 3528, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label for=\"funcion\">Funciones del puesto</label>\r\n                    <input type=\"text\" name=\"funciones\" class=\"form-control\"");
            BeginWriteAttribute("id", " id=\"", 3756, "\"", 3761, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3762, "\"", 3770, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>

                <div class=""form-group col-lg-12"">
                    <label class=""control-label col-sm-12"" for=""motivos"">Motivos de separacion:</label>
                    <div class=""col-sm-12"">
                        <textarea class=""form-control"" rows=""5"" id=""motivos""></textarea>
                    </div>
                </div>

                <div class=""col-xs-12 col-md-6""><input type=""submit"" value=""Cancelar"" class=""btn btn-primary btn-block btn-lg"" tabindex=""7""></div>
                <div class=""col-xs-12 col-md-6""><a href=""#"" class=""btn btn-success btn-block btn-lg"">Registrar</a></div>
            </div>
        </div>
    </section>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work_IO.Pages.WorkIO.ReferenciasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.WorkIO.ReferenciasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.WorkIO.ReferenciasModel>)PageContext?.ViewData;
        public Work_IO.Pages.WorkIO.ReferenciasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
