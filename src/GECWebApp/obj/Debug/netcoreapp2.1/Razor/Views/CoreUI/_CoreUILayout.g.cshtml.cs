#pragma checksum "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00aa59394c19cbcbc531f0bef0edf1443b32075f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI__CoreUILayout), @"mvc.1.0.view", @"/Views/CoreUI/_CoreUILayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/_CoreUILayout.cshtml", typeof(AspNetCore.Views_CoreUI__CoreUILayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00aa59394c19cbcbc531f0bef0edf1443b32075f", @"/Views/CoreUI/_CoreUILayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI__CoreUILayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumb-items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_breadcrumb-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml"
   Layout = "_Layout"; 

#line default
#line hidden
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(64, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(69, 40, false);
#line 5 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(109, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Breadcrumbs", async() => {
                BeginContext(160, 66, true);
                WriteLiteral("\r\n  <ol class=\"breadcrumb\">\r\n\r\n    <!-- BREADCRUMB-ITEMS -->\r\n    ");
                EndContext();
                BeginContext(226, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a48c2c8d29e459ebc31694b5eb5a05d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(262, 70, true);
                WriteLiteral("\r\n    <!-- /BREADCRUMB-ITEMS -->\r\n\r\n    <!-- BREADCRUMB-MENU -->\r\n    ");
                EndContext();
                BeginContext(332, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b67feb0ac86a45c8bcb5bd87ce4c3195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(367, 44, true);
                WriteLiteral("\r\n    <!-- /BREADCRUMB-MENU -->\r\n\r\n  </ol>\r\n");
                EndContext();
            }
            );
            BeginContext(414, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(417, 12, false);
#line 23 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(429, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(469, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(474, 40, false);
#line 27 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Modals", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(514, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(519, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(559, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(564, 41, false);
#line 32 "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\_CoreUILayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(605, 2, true);
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
