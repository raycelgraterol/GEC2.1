#pragma checksum "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\buttons-dropdowns.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b47583d603f1b37b42174fa8a77577e23bd325f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_buttons_dropdowns), @"mvc.1.0.view", @"/Views/CoreUI/buttons-dropdowns.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/buttons-dropdowns.cshtml", typeof(AspNetCore.Views_CoreUI_buttons_dropdowns))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b47583d603f1b37b42174fa8a77577e23bd325f6", @"/Views/CoreUI/buttons-dropdowns.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_buttons_dropdowns : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-4 py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 19351, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Dropdowns
        <div class=""card-header-actions"">
          <a href=""http://coreui.io/docs/components/bootstrap-dropdowns/"" class=""card-header-action"" target=""_blank"">
            <small class=""text-muted"">docs</small>
          </a>
        </div>
      </div>
      <div class=""card-body"">
        <div class=""row"">
          <div class=""col"">
            <div class=""btn-group"">
              <div class=""dropdown"">
                <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                  Dropdown button
                </button>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
                  <a class=""dropdown-item"" href=""#"">Action</a>
                  <a class=""dropdown-item"" href=""#"">Another action</a>");
            WriteLiteral(@"
                  <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
              </div>
            </div>
            <div class=""btn-group"">
              <div class=""dropdown show"">
                <a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                  Dropdown link
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                  <a class=""dropdown-item"" href=""#"">Action</a>
                  <a class=""dropdown-item"" href=""#"">Another action</a>
                  <a class=""dropdown-item"" href=""#"">Something else here</a>
                </div>
              </div>
            </div>
          </div>
        </div>
        <hr />
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expande");
            WriteLiteral(@"d=""false"">
            Primary
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Secondary
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a clas");
            WriteLiteral(@"s=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-success dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Success
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown");
            WriteLiteral(@"-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-info dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Info
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-warning dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=");
            WriteLiteral(@"""false"">
            Warning
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-danger dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Danger
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropd");
            WriteLiteral(@"own-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <hr />
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-primary"">Primary</button>
          <button type=""button"" class=""btn btn-primary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(71px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
         ");
            WriteLiteral(@"   <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-secondary"">Secondary</button>
          <button type=""button"" class=""btn btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(89px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
    ");
            WriteLiteral(@"        <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-success"">Success</button>
          <button type=""button"" class=""btn btn-success dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-info"">Info</button>
          <button type=""button"" class");
            WriteLiteral(@"=""btn btn-info dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-warning"">Warning</button>
          <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"">
            <a class=""d");
            WriteLiteral(@"ropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-danger"">Danger</button>
          <button type=""button"" class=""btn btn-danger dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <span class=""sr-only"">Toggle Dropdown</span>
          </button>
          <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#");
            WriteLiteral(@""">Separated link</a>
          </div>
        </div>
        <!-- /btn-group -->
        <hr />
        <div class=""btn-toolbar"" role=""toolbar"">
          <div class=""btn-group"">
            <button class=""btn btn-secondary btn-lg dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Large button
            </button>
            <div class=""dropdown-menu"">
              <a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
          </div>
          <!-- /btn-group -->
          <div class=""btn-group ml-2"">
            <button type=""button"" class=""btn btn-lg btn-secondary"">Large split button</button>
            <button type=""button"" class=""btn btn-lg btn-secondary dro");
            WriteLiteral(@"pdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              <span class=""sr-only"">Toggle Dropdown</span>
            </button>
            <div class=""dropdown-menu"">
              <a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
          </div>
          <!-- /btn-group -->
        </div>
        <!-- /btn-toolbar -->
        <hr />
        <div class=""btn-toolbar"" role=""toolbar"">
          <div class=""btn-group"">
            <button class=""btn btn-secondary btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Small button
            </button>
            <div class=""dropdown-menu"">
              <");
            WriteLiteral(@"a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
          </div>
          <!-- /btn-group -->
          <div class=""btn-group ml-2"">
            <button type=""button"" class=""btn btn-sm btn-secondary"">Small split button</button>
            <button type=""button"" class=""btn btn-sm btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              <span class=""sr-only"">Toggle Dropdown</span>
            </button>
            <div class=""dropdown-menu"">
              <a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <");
            WriteLiteral(@"div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
          </div>
          <!-- /btn-group -->
        </div>
        <!-- /btn-toolbar -->
        <hr />
        <div class=""bd-example"">
          <div class=""btn-group dropup"">
            <button type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropup
            </button>
            <div class=""dropdown-menu"" x-placement=""top-start"" style=""position: absolute; transform: translate3d(0px, -2px, 0px); top: 0px; left: 0px; will-change: transform;"">
              <a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
   ");
            WriteLiteral(@"       </div>

          <div class=""btn-group dropup"">
            <button type=""button"" class=""btn btn-secondary"">
              Split dropup
            </button>
            <button type=""button"" class=""btn btn-secondary dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              <span class=""sr-only"">Toggle Dropdown</span>
            </button>
            <div class=""dropdown-menu"" x-placement=""top-start"" style=""position: absolute; transform: translate3d(101px, -188px, 0px); top: 0px; left: 0px; will-change: transform;"">
              <a class=""dropdown-item"" href=""#"">Action</a>
              <a class=""dropdown-item"" href=""#"">Another action</a>
              <a class=""dropdown-item"" href=""#"">Something else here</a>
              <div class=""dropdown-divider""></div>
              <a class=""dropdown-item"" href=""#"">Separated link</a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
<d");
            WriteLiteral(@"iv class=""row"">
  <div class=""col"">
    <div class=""card"">
      <div class=""card-header"">
        <i class=""fa fa-align-justify""></i> Menus
      </div>
      <div class=""card-body"">
        <div class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Dropdown
          </button>
          <div class=""dropdown-menu"" aria-labelledby=""dropdownMenu2"" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 34px, 0px); top: 0px; left: 0px; will-change: transform;"">
            <button class=""dropdown-item"" type=""button"">Action</button>
            <button class=""dropdown-item"" type=""button"">Another action</button>
            <button class=""dropdown-item"" type=""button"">Something else here</button>
          </div>
        </div>
        <hr />
        <div class=""btn-group"">
          <button type=""button"" class=""btn btn-secondary dropdo");
            WriteLiteral(@"wn-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            This dropdown's menu is right-aligned
          </button>
          <div class=""dropdown-menu dropdown-menu-right"">
            <button class=""dropdown-item"" type=""button"">Action</button>
            <button class=""dropdown-item"" type=""button"">Another action</button>
            <button class=""dropdown-item"" type=""button"">Something else here</button>
          </div>
        </div>
        <hr />
        <div class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu3"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Menu header
          </button>
          <div class=""dropdown-menu"">
            <h6 class=""dropdown-header"">Dropdown header</h6>
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
          </div>
        </div>
        <hr />
        <d");
            WriteLiteral(@"iv class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu4"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Menu divider
          </button>
          <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">Action</a>
            <a class=""dropdown-item"" href=""#"">Another action</a>
            <a class=""dropdown-item"" href=""#"">Something else here</a>
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">Separated link</a>
          </div>
        </div>
        <hr />
        <div class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu5"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Menu forms
          </button>
          <div class=""dropdown-menu"">
            ");
            EndContext();
            BeginContext(19351, 860, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "244fe648b9754af1a9ac549a648552ea", async() => {
                BeginContext(19375, 829, true);
                WriteLiteral(@"
              <div class=""form-group"">
                <label for=""exampleDropdownFormEmail1"">Email address</label>
                <input type=""email"" class=""form-control"" id=""exampleDropdownFormEmail1"" placeholder=""email@example.com"">
              </div>
              <div class=""form-group"">
                <label for=""exampleDropdownFormPassword1"">Password</label>
                <input type=""password"" class=""form-control"" id=""exampleDropdownFormPassword1"" placeholder=""Password"">
              </div>
              <div class=""form-check"">
                <label class=""form-check-label"">
                  <input type=""checkbox"" class=""form-check-input""> Remember me
                </label>
              </div>
              <button type=""submit"" class=""btn btn-primary"">Sign in</button>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(20211, 806, true);
            WriteLiteral(@"
            <div class=""dropdown-divider""></div>
            <a class=""dropdown-item"" href=""#"">New around here? Sign up</a>
            <a class=""dropdown-item"" href=""#"">Forgot password?</a>
          </div>
        </div>
        <hr />
        <div class=""dropdown"">
          <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu5"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            Disabled item
          </button>
          <div class=""dropdown-menu"">
            <a class=""dropdown-item"" href=""#"">Regular link</a>
            <a class=""dropdown-item disabled"" href=""#"">Disabled link</a>
            <a class=""dropdown-item"" href=""#"">Another link</a>
          </div>
        </div>
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
