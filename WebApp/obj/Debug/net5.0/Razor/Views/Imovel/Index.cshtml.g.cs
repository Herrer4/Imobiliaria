#pragma checksum "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf36f1ec7c39ea4a39b03d0ce54c141b82e29494"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Imovel_Index), @"mvc.1.0.view", @"/Views/Imovel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf36f1ec7c39ea4a39b03d0ce54c141b82e29494", @"/Views/Imovel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Imovel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.ImovelViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Lista de Imoveis</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf36f1ec7c39ea4a39b03d0ce54c141b82e294944090", async() => {
                WriteLiteral("Criar Novo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table table-hover\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantidadeDeQuartos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorAluguel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 27 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td class=\"form-group\">\n        ");
#nullable restore
#line 31 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"form-group\">\n        ");
#nullable restore
#line 34 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.QuantidadeDeQuartos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"form-group\">\n        ");
#nullable restore
#line 37 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.ValorAluguel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td class=\"form-group\">\n        <div class=\"btn-group\">\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 42 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.ActionLink("Alterar", "Alterar", new { id = item.Id }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 45 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.ActionLink("Detalhar", "Detalhar", new { id = item.Id }, new { @class = "btn btn-outline-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 48 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
           Write(Html.ActionLink("Excluir", "Excluir", new { id = item.Id }, new { @class = "btn btn-outline-danger", @onClick = "javascript:return" + " confirm('Confirma a Exclus??o?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>                                 \n        </div>\n    </td>\n</tr>");
#nullable restore
#line 52 "C:\Workspace\ProjetoImobiliaria\ProjetoImobiliaria\WebApp\Views\Imovel\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.ImovelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
