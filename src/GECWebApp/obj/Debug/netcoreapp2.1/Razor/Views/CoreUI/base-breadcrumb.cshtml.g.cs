#pragma checksum "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\CoreUI\base-breadcrumb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e523149e7be578a1f8252cf495aba1b768856b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_base_breadcrumb), @"mvc.1.0.view", @"/Views/CoreUI/base-breadcrumb.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/base-breadcrumb.cshtml", typeof(AspNetCore.Views_CoreUI_base_breadcrumb))]
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
#line 1 "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp;

#line default
#line hidden
#line 2 "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e523149e7be578a1f8252cf495aba1b768856b", @"/Views/CoreUI/base-breadcrumb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_base_breadcrumb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1703, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-lg-12"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Bootstrap Breadcrumb
        <div class=""card-header-actions"">
          <a href=""http://coreui.io/docs/components/bootstrap-breadcrumb/"" class=""card-header-action"" target=""_blank"">
            <small class=""text-muted"">docs</small>
          </a>
        </div>
      </div>
      <div class=""card-body"">
        <nav aria-label=""breadcrumb"" role=""navigation"">
          <ol class=""breadcrumb"">
            <li class=""breadcrumb-item active"" aria-current=""page"">Home</li>
          </ol>
        </nav>

        <nav aria-label=""breadcrumb"" role=""navigation"">
          <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
              <a href=""#"">Home</a>
            </li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Library</li>
          </ol>
        </nav>

        <nav aria-label=""breadcrumb"" role=""navigation");
            WriteLiteral(@""">
          <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
              <a href=""#"">Home</a>
            </li>
            <li class=""breadcrumb-item"">
              <a href=""#"">Library</a>
            </li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Data</li>
          </ol>
        </nav>

        <nav class=""breadcrumb"">
          <a class=""breadcrumb-item"" href=""#"">Home</a>
          <a class=""breadcrumb-item"" href=""#"">Library</a>
          <a class=""breadcrumb-item"" href=""#"">Data</a>
          <span class=""breadcrumb-item active"">Bootstrap</span>
        </nav>
      </div>
    </div>
  </div>
</div>
");
            EndContext();
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
