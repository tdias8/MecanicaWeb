#pragma checksum "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f48237c729c996861d8bd2aa2dce27cc2235a66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MecanicaWeb.Pages.Clientes.Views_Clientes_Details), @"mvc.1.0.view", @"/Views/Clientes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Details.cshtml", typeof(MecanicaWeb.Pages.Clientes.Views_Clientes_Details))]
namespace MecanicaWeb.Pages.Clientes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\_ViewImports.cshtml"
using MecanicaWeb;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f48237c729c996861d8bd2aa2dce27cc2235a66", @"/Views/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b95dd3c695cf67be56c0c3d9f8e7bd45669215d", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MecanicaWeb.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 40, false);
#line 14 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(242, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(286, 36, false);
#line 17 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
            EndContext();
            BeginContext(322, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(366, 39, false);
#line 20 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(405, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(449, 35, false);
#line 23 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.cpf));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(528, 40, false);
#line 26 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fone));

#line default
#line hidden
            EndContext();
            BeginContext(568, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(612, 36, false);
#line 29 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.fone));

#line default
#line hidden
            EndContext();
            BeginContext(648, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(692, 41, false);
#line 32 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(733, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(777, 37, false);
#line 35 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(858, 44, false);
#line 38 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(946, 40, false);
#line 41 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.endereco));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1030, 52, false);
#line 44 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dataDeNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1126, 48, false);
#line 47 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.dataDeNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1218, 40, false);
#line 50 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.sexo));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1302, 36, false);
#line 53 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.sexo));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1382, 47, false);
#line 56 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.estadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1473, 43, false);
#line 59 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.estadoCivil));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1560, 41, false);
#line 62 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1645, 37, false);
#line 65 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1682, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1729, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edde2b3e7d384760b68ac3a84d63c287", async() => {
                BeginContext(1775, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\tdias\source\repos\MecanicaWeb\MecanicaWeb\Views\Clientes\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1783, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1791, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2359ca7347e04349b44760492c872945", async() => {
                BeginContext(1813, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1829, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MecanicaWeb.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
