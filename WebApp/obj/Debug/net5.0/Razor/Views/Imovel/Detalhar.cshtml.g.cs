#pragma checksum "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc3de1ebe380d66990478d91e48b660c451a0544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imovel_Detalhar), @"mvc.1.0.view", @"/Views/Imovel/Detalhar.cshtml")]
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
#nullable restore
#line 1 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc3de1ebe380d66990478d91e48b660c451a0544", @"/Views/Imovel/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Imovel_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp.Models.ImovelViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
   ViewData["Title"] = "Detalhar";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Detalhar</h1>\n\n<div>\n    <h4>");
#nullable restore
#line 9 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
   Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <hr />\n    <dl class=\"row\">\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeDeQuartos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.QuantidadeDeQuartos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.ValorAluguel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.ValorAluguel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoImovel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.TipoImovel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
#nullable restore
#line 52 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Detalhar.cshtml"
Write(Html.ActionLink("Alterar", "Alterar", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc3de1ebe380d66990478d91e48b660c451a05448193", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Models.ImovelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591