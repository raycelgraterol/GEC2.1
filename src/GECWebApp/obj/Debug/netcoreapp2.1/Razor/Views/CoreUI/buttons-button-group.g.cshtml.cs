#pragma checksum "C:\Repositorio\GitRespository\GEC\GEC2.1\src\GECWebApp\Views\CoreUI\buttons-button-group.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c06be097aeecb0f903b1de84f2ee90fc3a641f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoreUI_buttons_button_group), @"mvc.1.0.view", @"/Views/CoreUI/buttons-button-group.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoreUI/buttons-button-group.cshtml", typeof(AspNetCore.Views_CoreUI_buttons_button_group))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01c06be097aeecb0f903b1de84f2ee90fc3a641f", @"/Views/CoreUI/buttons-button-group.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834512f6ff5c9dc8a878a502f08bd0733ea6d90c", @"/Views/_ViewImports.cshtml")]
    public class Views_CoreUI_buttons_button_group : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2528, true);
            WriteLiteral(@"<div class=""row"">
  <div class=""col-md-6"">
    <div class=""card"">
      <div class=""card-header"">
        <strong>Button group</strong>
        <div class=""card-header-actions"">
          <a href=""http://coreui.io/docs/components/bootstrap-button-group/"" class=""card-header-action"" target=""_blank"">
            <small class=""text-muted"">docs</small>
          </a>
        </div>
      </div>
      <div class=""card-body"">
        <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
          <button type=""button"" class=""btn btn-secondary"">Left</button>
          <button type=""button"" class=""btn btn-secondary"">Middle</button>
          <button type=""button"" class=""btn btn-secondary"">Right</button>
        </div>
      </div>
    </div>
    <div class=""card"">
      <div class=""card-header"">
        Button group
        <small>toolbar</small>
      </div>
      <div class=""card-body"">
        <div class=""btn-toolbar mb-3"" role=""toolbar"" aria-label=""Toolbar with button groups"">
 ");
            WriteLiteral(@"         <div class=""btn-group mr-2"" role=""group"" aria-label=""First group"">
            <button type=""button"" class=""btn btn-secondary"">1</button>
            <button type=""button"" class=""btn btn-secondary"">2</button>
            <button type=""button"" class=""btn btn-secondary"">3</button>
            <button type=""button"" class=""btn btn-secondary"">4</button>
          </div>
          <div class=""btn-group mr-2"" role=""group"" aria-label=""Second group"">
            <button type=""button"" class=""btn btn-secondary"">5</button>
            <button type=""button"" class=""btn btn-secondary"">6</button>
            <button type=""button"" class=""btn btn-secondary"">7</button>
          </div>
          <div class=""btn-group"" role=""group"" aria-label=""Third group"">
            <button type=""button"" class=""btn btn-secondary"">8</button>
          </div>
        </div>

        <div class=""btn-toolbar mb-3"" role=""toolbar"" aria-label=""Toolbar with button groups"">
          <div class=""btn-group mr-2"" role=""group"" a");
            WriteLiteral(@"ria-label=""First group"">
            <button type=""button"" class=""btn btn-secondary"">1</button>
            <button type=""button"" class=""btn btn-secondary"">2</button>
            <button type=""button"" class=""btn btn-secondary"">3</button>
            <button type=""button"" class=""btn btn-secondary"">4</button>
          </div>
          <div class=""input-group"">
            <div class=""input-group-prepend"">
              <span class=""input-group-text"" id=""btnGroupAddon"">");
            EndContext();
            BeginContext(2529, 862, true);
            WriteLiteral(@"@</span>
            </div>
            <input type=""text"" class=""form-control"" placeholder=""Input group example"" aria-label=""Input group example"" aria-describedby=""btnGroupAddon"">
          </div>
        </div>

        <div class=""btn-toolbar justify-content-between"" role=""toolbar"" aria-label=""Toolbar with button groups"">
          <div class=""btn-group"" role=""group"" aria-label=""First group"">
            <button type=""button"" class=""btn btn-secondary"">1</button>
            <button type=""button"" class=""btn btn-secondary"">2</button>
            <button type=""button"" class=""btn btn-secondary"">3</button>
            <button type=""button"" class=""btn btn-secondary"">4</button>
          </div>
          <div class=""input-group"">
            <div class=""input-group-prepend"">
              <span class=""input-group-text"" id=""btnGroupAddon2"">");
            EndContext();
            BeginContext(3392, 5959, true);
            WriteLiteral(@"@</span>
            </div>
            <input type=""text"" class=""form-control"" placeholder=""Input group example"" aria-label=""Input group example"" aria-describedby=""btnGroupAddon2"">
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""col-md-6"">
    <div class=""card"">
      <div class=""card-header"">
        Button group
        <small>sizing</small>
      </div>
      <div class=""card-body"">
        <div class=""btn-group btn-group-lg mb-3"" role=""group"" aria-label=""Large button group"">
          <button type=""button"" class=""btn btn-secondary"">Left</button>
          <button type=""button"" class=""btn btn-secondary"">Middle</button>
          <button type=""button"" class=""btn btn-secondary"">Right</button>
        </div>
        <br />
        <div class=""btn-group mb-3"" role=""group"" aria-label=""Default button group"">
          <button type=""button"" class=""btn btn-secondary"">Left</button>
          <button type=""button"" class=""btn btn-secondary"">Middle</button>
     ");
            WriteLiteral(@"     <button type=""button"" class=""btn btn-secondary"">Right</button>
        </div>
        <br />
        <div class=""btn-group btn-group-sm"" role=""group"" aria-label=""Small button group"">
          <button type=""button"" class=""btn btn-secondary"">Left</button>
          <button type=""button"" class=""btn btn-secondary"">Middle</button>
          <button type=""button"" class=""btn btn-secondary"">Right</button>
        </div>
      </div>
    </div>
    <div class=""card"">
      <div class=""card-header"">
        Button group
        <small>nesting</small>
      </div>
      <div class=""card-body"">
        <div class=""btn-group"" role=""group"" aria-label=""Button group with nested dropdown"">
          <button type=""button"" class=""btn btn-secondary"">1</button>
          <button type=""button"" class=""btn btn-secondary"">2</button>

          <div class=""btn-group"" role=""group"">
            <button id=""btnGroupDrop1"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspop");
            WriteLiteral(@"up=""true"" aria-expanded=""false"">
              Dropdown
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""btnGroupDrop1"">
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
<div class=""row"">
  <div class=""col-md-6"">
    <div class=""card"">
      <div class=""card-header"">
        Button group
        <small>vertical variation</small>
      </div>
      <div class=""card-body"">
        <div class=""btn-group-vertical"" role=""group"" aria-label=""Vertical button group"">
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" clas");
            WriteLiteral(@"s=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
        </div>
      </div>
    </div>

  </div>
  <div class=""col-md-6"">
    <div class=""card"">
      <div class=""card-header"">
        Button group
        <small>vertical variation</small>
      </div>
      <div class=""card-body"">
        <div class=""btn-group-vertical"" role=""group"" aria-label=""Vertical button group"">
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <div class=""btn-group"" role=""group"">
            <button id=""btnGroupVerticalDrop1"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropdown
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop1"">
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
         ");
            WriteLiteral(@"     <a class=""dropdown-item"" href=""#"">Dropdown link</a>
            </div>
          </div>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <button type=""button"" class=""btn btn-secondary"">Button</button>
          <div class=""btn-group"" role=""group"">
            <button id=""btnGroupVerticalDrop2"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropdown
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop2"">
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
            </div>
          </div>
          <div class=""btn-group"" role=""group"">
            <button id=""btnGroupVerticalDrop3"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropdown
            </bu");
            WriteLiteral(@"tton>
            <div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop3"">
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
            </div>
          </div>
          <div class=""btn-group"" role=""group"">
            <button id=""btnGroupVerticalDrop4"" type=""button"" class=""btn btn-secondary dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
              Dropdown
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""btnGroupVerticalDrop4"">
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
              <a class=""dropdown-item"" href=""#"">Dropdown link</a>
            </div>
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
