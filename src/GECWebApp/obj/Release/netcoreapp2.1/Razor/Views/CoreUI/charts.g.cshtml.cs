#pragma checksum "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\charts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed256bc7fbd4ba99b587156a400f8cd10f6335de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_charts), @"mvc.1.0.view", @"/Views/CoreUI/charts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/charts.cshtml", typeof(AspNetCore.Views_CoreUI_charts))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed256bc7fbd4ba99b587156a400f8cd10f6335de", @"/Views/CoreUI/charts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_charts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/charts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2628, true);
            WriteLiteral(@"<div class=""card-columns cols-2"">
  <div class=""card"">
    <div class=""card-header"">
      Line Chart
      <div class=""card-header-actions"">
        <a href=""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-1""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Bar Chart
      <div class=""card-header-actions"">
        <a href=""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-2""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Doughnut Chart
      <div class=""card-header-actions"">
        <a href=");
            WriteLiteral(@"""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-3""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Radar Chart
      <div class=""card-header-actions"">
        <a href=""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-4""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Pie Chart
      <div class=""card-header-actions"">
        <a href=""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <d");
            WriteLiteral(@"iv class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-5""></canvas>
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"">
      Polar Area Chart
      <div class=""card-header-actions"">
        <a href=""http://www.chartjs.org"" class=""card-header-action"" target=""_blank"">
          <small class=""text-muted"">docs</small>
        </a>
      </div>
    </div>
    <div class=""card-body"">
      <div class=""chart-wrapper"">
        <canvas id=""canvas-6""></canvas>
      </div>
    </div>
  </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2646, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(2650, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0170ea901ae24b8aaeb60772ca209ddb", async() => {
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
                BeginContext(2706, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(2710, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "718ce0daf4d3495e9e9fb21b9676755c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("~/lib/@");
                WriteLiteral("coreui/coreui-plugin-chartjs-custom-tooltips/dist/js/custom-tooltips.min.js");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2817, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(2821, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a37808c6d3d14c3a8c9be5798a121347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2859, 2, true);
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
