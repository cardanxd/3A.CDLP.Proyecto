#pragma checksum "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b621be0317bc733d1582295ada86b92474b5d03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Work_IO.Pages.WorkIO.Pages_WorkIO_DeleteOrden), @"mvc.1.0.razor-page", @"/Pages/WorkIO/DeleteOrden.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b621be0317bc733d1582295ada86b92474b5d03", @"/Pages/WorkIO/DeleteOrden.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb09af94176fde2264109c6a818bf5803fb80f52", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkIO_DeleteOrden : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./OrdenesRegistrados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
  
    ViewData["Title"] = "DeleteOrden";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles de la orden #");
#nullable restore
#line 7 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
                     Write(Model.Orden.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-3\">\r\n            Titulo del Orden:\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 15 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
       Write(Html.DisplayFor(model => model.Orden.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            Puesto Solicitado:\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 21 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
       Write(Html.DisplayFor(model => model.Orden.TipoContrato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            Descripción:\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 27 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
       Write(Html.DisplayFor(model => model.Orden.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            Fecha de creación:\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 33 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
       Write(Html.DisplayFor(model => model.Orden.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-3\">\r\n            Fecha de actualización:\r\n        </dt>\r\n        <dd class=\"col-sm-9\">\r\n            ");
#nullable restore
#line 39 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
       Write(Html.DisplayFor(model => model.Orden.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n\r\n    </dl>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b621be0317bc733d1582295ada86b92474b5d037237", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b621be0317bc733d1582295ada86b92474b5d037503", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orden.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <!-- Button to Open the Modal -->
        <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#myModal"">
            Eliminar
        </button>

        <!-- The Modal -->
        <div class=""modal fade"" id=""myModal"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">

                    <!-- Modal Header -->
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">¿Está seguro que desea eliminar la orden #");
#nullable restore
#line 59 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\DeleteOrden.cshtml"
                                                                                     Write(Model.Orden.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>

                    <!-- Modal body -->
                    <div class=""modal-body"">
                        Si elimina la orden perderá los datos y candidatos registrados en ella.
                    </div>

                    <!-- Modal footer -->
                    <div class=""modal-footer"">

                        <input type=""submit"" value=""Eliminar"" class=""btn btn-danger"" />
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>

                </div>
            </div>
        </div>
        
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b621be0317bc733d1582295ada86b92474b5d0310840", async() => {
                    WriteLiteral("Cancelar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work_IO.Pages.WorkIO.DeleteOrdenModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.WorkIO.DeleteOrdenModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.WorkIO.DeleteOrdenModel>)PageContext?.ViewData;
        public Work_IO.Pages.WorkIO.DeleteOrdenModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
