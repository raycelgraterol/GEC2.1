#pragma checksum "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d265611c0757855a8affb6fd2631e5bc9ac8faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagementChange__sellResult), @"mvc.1.0.view", @"/Views/ManagementChange/_sellResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManagementChange/_sellResult.cshtml", typeof(AspNetCore.Views_ManagementChange__sellResult))]
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
#line 1 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp;

#line default
#line hidden
#line 2 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\_ViewImports.cshtml"
using GECWebApp.Models;

#line default
#line hidden
#line 1 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
using GECApi.Entities;

#line default
#line hidden
#line 2 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d265611c0757855a8affb6fd2631e5bc9ac8faf", @"/Views/ManagementChange/_sellResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagementChange__sellResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 356, true);
            WriteLiteral(@"
<table class=""table table-responsive-sm table-hover mb-0"">
  <thead class=""thead-light"">
    <tr>
      <th class=""text-center""><i class=""icon-people""></i></th>
      <th class=""text-center"">Descripcion Pago</th>
      <th class=""text-center"">Precio de Venta</th>
      <th class=""text-center"">Rango Precios</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 14 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(452, 61, true);
            WriteLiteral("      <tr>\r\n        <td class=\"text-center\">\r\n          <div>");
            EndContext();
            BeginContext(514, 27, false);
#line 18 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
          Write(item.profile.name.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(541, 68, true);
            WriteLiteral("</div>\r\n          <div class=\"small text-muted\">\r\n            <span>");
            EndContext();
            BeginContext(610, 24, false);
#line 20 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
             Write(item.profile.trade_count);

#line default
#line hidden
            EndContext();
            BeginContext(634, 15, true);
            WriteLiteral("</span>   <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 649, "\"", 738, 2);
            WriteAttributeValue("", 657, "badge", 657, 5, true);
#line 20 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
WriteAttributeValue(" ", 662, item.profile.feedback_score == "100" ? "badge-success" : "badge-warning", 663, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(741, 27, false);
#line 20 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
                                                                                                                                                Write(item.profile.feedback_score);

#line default
#line hidden
            EndContext();
            BeginContext(768, 104, true);
            WriteLiteral("</span>\r\n          </div>\r\n        </td>\r\n        <td class=\"text-center\">\r\n          <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 872, "\"", 896, 1);
#line 24 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
WriteAttributeValue("", 879, item.public_view, 879, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(897, 19, true);
            WriteLiteral(" class=\"text-dark\">");
            EndContext();
            BeginContext(917, 14, false);
#line 24 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
                                                                   Write(item.bank_name);

#line default
#line hidden
            EndContext();
            BeginContext(931, 53, true);
            WriteLiteral("</a>\r\n        </td>\r\n        <td class=\"text-center\">");
            EndContext();
            BeginContext(985, 74, false);
#line 26 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
                           Write(item.temp_price.ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 92, true);
            WriteLiteral("</td>\r\n        <td class=\"text-center\">\r\n          <div id=\"minAmount\" class=\"text-primary\">");
            EndContext();
            BeginContext(1152, 74, false);
#line 28 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
                                              Write(item.min_amount.ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 59, true);
            WriteLiteral("</div>\r\n          <div id=\"maxAmount\" class=\"text-primary\">");
            EndContext();
            BeginContext(1286, 74, false);
#line 29 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
                                              Write(item.max_amount.ToString("C3", CultureInfo.CreateSpecificCulture("es-VE")));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 36, true);
            WriteLiteral("</div>\r\n        </td>\r\n      </tr>\r\n");
            EndContext();
#line 32 "C:\Repositorio\GitRespository\GEC\raycelgraterol\GEC2.1\src\GECWebApp\Views\ManagementChange\_sellResult.cshtml"
    }

#line default
#line hidden
            BeginContext(1403, 521, true);
            WriteLiteral(@"  </tbody>
</table>
<ul class=""pagination"">
  <li class=""page-item"">
    <a class=""page-link"" href=""#"">Prev</a>
  </li>
  <li class=""page-item active"">
    <a class=""page-link"" href=""#"">1</a>
  </li>
  <li class=""page-item"">
    <a class=""page-link"" href=""#"">2</a>
  </li>
  <li class=""page-item"">
    <a class=""page-link"" href=""#"">3</a>
  </li>
  <li class=""page-item"">
    <a class=""page-link"" href=""#"">4</a>
  </li>
  <li class=""page-item"">
    <a class=""page-link"" href=""#"">Next</a>
  </li>
</ul>");
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
