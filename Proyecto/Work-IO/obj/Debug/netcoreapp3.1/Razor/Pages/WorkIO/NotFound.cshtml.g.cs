#pragma checksum "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72da607de59f36a5a5a0973233f6e7d79a0c288d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Work_IO.Pages.WorkIO.Pages_WorkIO_NotFound), @"mvc.1.0.razor-page", @"/Pages/WorkIO/NotFound.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72da607de59f36a5a5a0973233f6e7d79a0c288d", @"/Pages/WorkIO/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb09af94176fde2264109c6a818bf5803fb80f52", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkIO_NotFound : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/WorkIO/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-round"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\carlo\Documents\Aplicaciones web\Proyecto\Work-IO\Pages\WorkIO\NotFound.cshtml"
  
    ViewData["Title"] = "NotFound";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<style>


    h4{
        color: #253858;
        margin-bottom: .8rem;
        position: relative;
        font-family: 'Raleway', sans-serif;
        font-size: 1.5rem;
    }
    p{
        margin-top: 0;
        margin-bottom: 1rem;
        display: block;
        margin-block-start: 1em;
        margin-block-end: 1em;
        margin-inline-start: 0px;
        margin-inline-end: 0px;
        color: rgb(113, 120, 126);
        font-family: 'Lato', sans-serif;
    }
    .btn-primary:hover {
        color: #fff;
        background-color: #0069d9;
        border-color: #0062cc;
    }
    .btn-primary {
        color: #fff;
        background-c");
            WriteLiteral(@"olor: #0069d9;
        border-color: #0062cc;
    }
    .btn-round {
        border-radius: 30px !important;
        text-decoration: none;
    }

    .btn {
        font-size: 15px;
        font-weight: 600;
        padding: 9px 25px;
        border-width: 2px;
        box-shadow: 0 3px 8px 0 rgba(41,49,89,.15), inset 0 0 0 1px hsla(0,0%,100%,.1);
    }
    .btn {
        display: inline-block;
        font-weight: 400;
        text-align: center;
        white-space: nowrap;
        vertical-align: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        border: 1px solid transparent;
        padding: .375rem .75rem;
        font-size: 1rem;
        line-height: 1.5;
        border-radius: .25rem;
        transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;
    }
    .btn:not(:disabled):not(.disabled) {
        cursor:");
            WriteLiteral(@" pointer;
    }
    /*[404 error page]
--------------------------*/
    .error-content {
        padding: 0 0 70px;
    }
    .error-text{
        text-align: center;
    }
    .error {
        font-size: 180px;
        font-weight: 100;
    }
    
    .im-sheep {
        display: inline-block;
        position: relative;
        font-size: 1em;
        margin-bottom: 70px;
    }
    .im-sheep * {
        transition: transform 0.3s;
    }
    .im-sheep .top {
        position: relative;
        top: 0;
        animation: bob 1s infinite;
    }
    .im-sheep:hover .head {
        transform: rotate(0deg);
    }
    .im-sheep:hover .head .im-eye {
        width: 1.25em;
        height: 1.25em;
    }
    .im-sheep:hover .head .im-eye:before {
        right: 30%;
    }
    .im-sheep:hover .top {
        animation-play-state: paused;
    }
    .im-sheep .head {
        display: inline-block;
        width: 5em;
        height: 5em;
        border-radius: 100%;
        ");
            WriteLiteral(@"background: #253858;
        vertical-align: middle;
        position: relative;
        top: 1em;
        transform: rotate(30deg);
    }
    .im-sheep .head:before {
        content: '';
        display: inline-block;
        width: 80%;
        height: 50%;
        background: #253858;
        position: absolute;
        bottom: 0;
        right: -10%;
        border-radius: 50% 40%;
    }
    .im-sheep .head:hover .im-ear.one, .im-sheep .head:hover .im-ear.two {
        transform: rotate(0deg);
    }
    .im-sheep .head .im-eye {
        display: inline-block;
        width: 1em;
        height: 1em;
        border-radius: 100%;
        background: white;
        position: absolute;
        overflow: hidden;
    }
    .im-sheep .head .im-eye:before {
        content: '';
        display: inline-block;
        background: black;
        width: 50%;
        height: 50%;
        border-radius: 100%;
        position: absolute;
        right: 10%;
        bottom: 10%;
  ");
            WriteLiteral(@"      transition: all 0.3s;
    }
    .im-sheep .head .im-eye.one {
        right: -2%;
        top: 1.7em;
    }
    .im-sheep .head .im-eye.two {
        right: 2.5em;
        top: 1.7em;
    }
    .im-sheep .head .im-ear {
        background: #253858;
        width: 50%;
        height: 30%;
        border-radius: 100%;
        position: absolute;
    }
    .im-sheep .head .im-ear.one {
        left: -10%;
        top: 5%;
        transform: rotate(-30deg);
    }
    .im-sheep .head .im-ear.two {
        top: 2%;
        right: -5%;
        transform: rotate(20deg);
    }
    .im-sheep .body {
        display: inline-block;
        width: 7em;
        height: 7em;
        border-radius: 100%;
        background: #0054D1;
        position: relative;
        vertical-align: middle;
        margin-right: -3em;
    }
    .im-sheep .im-legs {
        display: inline-block;
        position: absolute;
        top: 80%;
        left: 10%;
        z-index: -1;
    }
    ");
            WriteLiteral(@".im-sheep .im-legs .im-leg {
        display: inline-block;
        background: #141214;
        width: 0.5em;
        height: 2.5em;
        margin: 0.2em;
    }
    .im-sheep::before {
        left: 0;
        content: '';
        display: inline-block;
        position: absolute;
        top: 112%;
        width: 100%;
        height: 18%;
        border-radius: 100%;
        background: rgba(0, 0, 0, 0.2);
    }



</style>

<div class=""error-content"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 "">
                <div class=""error-text"">
                    <h1 class=""error"">404 Error</h1>
                    <div class=""im-sheep"">
                        <div class=""top"">
                            <div class=""body""></div>
                            <div class=""head"">
                                <div class=""im-eye one""></div>
                                <div class=""im-eye two""></div>
                                ");
            WriteLiteral(@"<div class=""im-ear one""></div>
                                <div class=""im-ear two""></div>
                            </div>
                        </div>
                        <div class=""im-legs"">
                            <div class=""im-leg""></div>
                            <div class=""im-leg""></div>
                            <div class=""im-leg""></div>
                            <div class=""im-leg""></div>
                        </div>
                    </div>
                    <h4>Oops! This page Could Not Be Found!</h4>
                    <p>Sorry bit the page you are looking for does not exist, have been removed or name changed.</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72da607de59f36a5a5a0973233f6e7d79a0c288d10866", async() => {
                WriteLiteral("Go to homepage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work_IO.Pages.NotFoundModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.NotFoundModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Work_IO.Pages.NotFoundModel>)PageContext?.ViewData;
        public Work_IO.Pages.NotFoundModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
