#pragma checksum "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e2046a079b7af876f468fc41c7c5aff03327d38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2046a079b7af876f468fc41c7c5aff03327d38", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/charts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page Master";

#line default
#line hidden
            BeginContext(52, 192, true);
            WriteLiteral("<div class=\"row\">\r\n  <div class=\"col-lg-5\">\r\n    <div class=\"alert alert-primary\" role=\"alert\">\r\n      Precio de venta promedio Medio\r\n      <a href=\"#\" id=\"minAmountAbout\" class=\"alert-link\">");
            EndContext();
            BeginContext(245, 14, false);
#line 8 "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\Home\Index.cshtml"
                                                    Write(ViewBag.sellVe);

#line default
#line hidden
            EndContext();
            BeginContext(259, 652, true);
            WriteLiteral(@"</a> Venezuela.
    </div>
  </div>
  <div class=""col-lg-2"">
    <button type=""button"" onclick=""exchangeRates.clearSession()"" class=""btn btn-block btn-primary"">Limpiar venta</button>
    <button type=""button"" onclick=""exchangeRates.hideGain()"" class=""btn btn-block btn-ghost-info showRate"">Publicar tasas</button>
    <button type=""button"" onclick=""exchangeRates.showGain()"" class=""btn btn-block btn-ghost-warning showGain"" style=""display:none"">Ganancias</button>
  </div>
  <div class=""col-lg-5"">
    <div class=""alert alert-danger"" role=""alert"">
      Precio de venta promedio Alto
      <a href=""#"" id=""maxAmountAbout"" class=""alert-link"">");
            EndContext();
            BeginContext(912, 18, false);
#line 19 "C:\Repositories\GitCraycelDot0\GEC2.1\src\GECWebApp\Views\Home\Index.cshtml"
                                                    Write(ViewBag.sellVeHigh);

#line default
#line hidden
            EndContext();
            BeginContext(930, 11268, true);
            WriteLiteral(@"</a> Venezuela.
    </div>
  </div>
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshCO"" onclick=""exchangeRates.showCountryRate('CO', 'transfers-with-specific-bank', 'COP', $('#valueGainCO').val(), 'rateCOVE', true)"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Colombia</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-co h1"" title=""co"" id=""co""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateCOVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainCO"" max=""100"" min=""0"" value=""10"">
        </div>
        <div id=""rateCOVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""pr");
            WriteLiteral(@"ogress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateCOVEG"" class=""text-value""></div>
      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshPE"" onclick=""exchangeRates.showCountryRate('PE', 'transfers-with-specific-bank', 'PEN', $('#valueGainPE').val(), 'ratePEVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Peru</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-pe h1"" title=""pe"" id=""pe""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""ratePEVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""widt");
            WriteLiteral(@"h:50%"" id=""valueGainPE"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""ratePEVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""ratePEVEG"" class=""text-value""></div>
      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshPEU"" onclick=""exchangeRates.showCountryRate('PE', 'transfers-with-specific-bank', 'USD', $('#valueGainPEU').val(), 'ratePEUVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Peru Dolar</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-pe h1"" title=""pe"" i");
            WriteLiteral(@"d=""pe""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""ratePEUVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainPEU"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""ratePEUVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""ratePEUVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshDO"" onclick=""exchangeRates.showCountryRate('DO', 'transfers-with-specific-bank', 'DOP', $('#valueGainDO').val(), 'rateDOVE')"" type=""button"" class=""btn btn-transparent ");
            WriteLiteral(@"p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">R. Dominicana</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-do h1"" title=""do"" id=""do""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateDOVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainDO"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""rateDOVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateDOVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
  ");
            WriteLiteral(@"    <div class=""card-body pb-0"">
        <button id=""refreshCL"" onclick=""exchangeRates.showCountryRate('CL', 'national-bank-transfer', 'CLP', $('#valueGainCL').val(), 'rateCLVE', false)"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Chile</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-cl h1"" title=""cl"" id=""cl""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateCLVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainCL"" max=""100"" min=""0"" value=""6"">
        </div>
        <div>Tasa cambio</div>
        <div id=""rateCLVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""widt");
            WriteLiteral(@"h: 70%""></div>
        </div>
        <div id=""rateCLVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshMX"" onclick=""exchangeRates.showCountryRate('MX', 'cash-deposit', 'MXN', $('#valueGainMX').val(), 'rateMXVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Mexico</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-mx h1"" title=""mx"" id=""mx""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateMXVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainMX"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""rateMXVELoader"" class=""progress"" style=""display:none;");
            WriteLiteral(@"position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateMXVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshEC"" onclick=""exchangeRates.showCountryRate('EC', 'national-bank-transfer', 'USD', $('#valueGainEC').val(), 'rateECVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Ecuador</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-ec h1"" title=""ec"" id=""ec""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateECVE"" class=""text-value""></div>
    ");
            WriteLiteral(@"      <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainEC"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""rateECVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateECVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshES"" onclick=""exchangeRates.showCountryRate('ES', 'transfers-with-specific-bank', 'EUR', $('#valueGainES').val(), 'rateESVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Spain</div>
        <div class=""text");
            WriteLiteral(@"-center"">
          <i class=""flag-icon flag-icon-es h1"" title=""es"" id=""es""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateESVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainES"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""rateESVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateESVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
  <div class=""col-sm-4 col-lg-3"">
    <div class=""card text-white bg-info"">
      <div class=""card-body pb-0"">
        <button id=""refreshAR"" onclick=""exchangeRates.showCountryRate('AR', 'transfers-with-specific-bank', 'ARS', $('#valueGain");
            WriteLiteral(@"AR').val(), 'rateARVE')"" type=""button"" class=""btn btn-transparent p-0 float-right"">
          <i class=""fa fa-refresh fa-lg""></i>
        </button>
        <div class=""text-value"">Argentina</div>
        <div class=""text-center"">
          <i class=""flag-icon flag-icon-ar h1"" title=""ar"" id=""ar""></i>
        </div>
        <div class=""rate-gain"">
          <div>Tasa </div>
          <div id=""rateARVE"" class=""text-value""></div>
          <input class=""form-control form-control-sm "" type=""number"" style=""width:50%"" id=""valueGainAR"" max=""100"" min=""0"" value=""6"">
        </div>
        <div id=""rateARVELoader"" class=""progress"" style=""display:none;position: absolute;width: 75%;top: 50%;left: 10%;"">
          <div class=""progress-bar progress-bar-striped progress-bar-animated bg-warning"" role=""progressbar"" style=""width: 70%""></div>
        </div>
        <div>Tasa cambio</div>
        <div id=""rateARVEG"" class=""text-value""></div>

      </div>
    </div>
  </div>
  <!--/.col-->
</div>
<!--/.row-");
            WriteLiteral("->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(12216, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(12220, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a12fc32b0ae4011addf5a5fa86f3762", async() => {
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
                BeginContext(12276, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(12280, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a49677899a441dba93465bd31e69993", async() => {
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
                BeginContext(12387, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(12391, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786d84676bcf4222a64037a266d30e7d", async() => {
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
                BeginContext(12427, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(12431, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cee043649744f7ba1a6ae7c30a089c8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12469, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(12474, 4, true);
            WriteLiteral("\r\n\r\n");
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