#pragma checksum "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\base-tooltips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "724afe9773017f4fe72ec1c87876de15ecfc0ddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_base_tooltips), @"mvc.1.0.view", @"/Views/CoreUI/base-tooltips.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/base-tooltips.cshtml", typeof(AspNetCore.Views_CoreUI_base_tooltips))]
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
#line 1 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp;

#line default
#line hidden
#line 2 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"724afe9773017f4fe72ec1c87876de15ecfc0ddc", @"/Views/CoreUI/base-tooltips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_base_tooltips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tooltips.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2340, true);
            WriteLiteral(@"<div class=""card"">
  <div class=""card-header"">
    Tooltips
    <div class=""card-header-actions"">
      <a href=""http://coreui.io/docs/components/bootstrap-tooltips/"" class=""card-header-action"" target=""_blank"">
        <small class=""text-muted"">docs</small>
      </a>
    </div>
  </div>
  <div class=""card-body"">
    <p class=""text-muted"">Hover over the links below to see tooltips:</p>
    <div class=""bd-example tooltip-demo"">
      <p class=""muted"">
        Tight pants next level keffiyeh
        <a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""Default tooltip"">you probably</a> haven't heard of them. Photo booth beard raw denim letterpress vegan messenger bag stumptown. Farm-to-table seitan, mcsweeney's fixie sustainable quinoa 8-bit american apparel
        <a href=""#"" data-toggle=""tooltip"" title=""""
           data-original-title=""Another tooltip"">have a</a> terry richardson vinyl chambray. Beard stumptown, cardigans banh mi lomo thundercats. Tofu biodiesel williamsburg marfa,");
            WriteLiteral(@" four loko mcsweeney's cleanse vegan chambray. A really ironic artisan
        <a href=""#"" data-toggle=""tooltip""
           title="""" data-original-title=""Another one here too"">whatever keytar</a>, scenester farm-to-table banksy Austin
        <a href=""#"" data-toggle=""tooltip"" title="""" data-original-title=""The last tip!"">twitter handle</a> freegan cred raw denim single-origin coffee viral.
      </p>
    </div>
  </div>
  <div class=""card-footer"">
    <button type=""button"" class=""btn btn-secondary"" data-toggle=""tooltip"" data-placement=""top"" title=""Tooltip on top"">
      Tooltip on top
    </button>
    <button type=""button"" class=""btn btn-secondary"" data-toggle=""tooltip"" data-placement=""right"" title=""Tooltip on right"">
      Tooltip on right
    </button>
    <button type=""button"" class=""btn btn-secondary"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Tooltip on bottom"">
      Tooltip on bottom
    </button>
    <button type=""button"" class=""btn btn-secondary"" data-toggle=""tooltip"" data-");
            WriteLiteral(@"placement=""left"" title=""Tooltip on left"">
      Tooltip on left
    </button>
    <button type=""button"" class=""btn btn-secondary"" data-toggle=""tooltip"" data-html=""true"" title="""" data-original-title=""<em>Tooltip</em> <u>with</u> <b>HTML</b>"">Tooltip with HTML</button>
  </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2358, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(2362, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eddf714041a481f9acbd795804a46f1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2402, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
