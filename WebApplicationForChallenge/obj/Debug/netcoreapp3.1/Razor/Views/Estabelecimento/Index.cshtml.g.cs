#pragma checksum "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e17c66610be5ff11adae2a15de368dd2baaedb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estabelecimento_Index), @"mvc.1.0.view", @"/Views/Estabelecimento/Index.cshtml")]
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
#line 1 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\_ViewImports.cshtml"
using WebApplicationForChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\_ViewImports.cshtml"
using WebApplicationForChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e17c66610be5ff11adae2a15de368dd2baaedb0", @"/Views/Estabelecimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a1915c874125b87a299db0aeb3b6170886353b", @"/Views/_ViewImports.cshtml")]
    public class Views_Estabelecimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Estabelecimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
  
    ViewData["Title"] = "Lista de Estabelecimentos";    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Estabelecimentos</h1>\n\n<mensagem");
            BeginWriteAttribute("texto", " texto=\"", 129, "\"", 153, 1);
#nullable restore
#line 9 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
WriteAttributeValue("", 137, TempData["msg"], 137, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></mensagem>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e17c66610be5ff11adae2a15de368dd2baaedb05605", async() => {
                WriteLiteral("Cadastrar");
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
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>Código</th>
        <th>Nome</th>
        <th>CNPJ</th>
        <th>Razão Social</th>
        <th>Ramo de Atuação</th>
        <th>Porte</th>
        <th>Data Abertura</th>
        <th>Endereço</th>
        <th>Telefone</th>
        <th></th>
    </tr>
");
#nullable restore
#line 25 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 28 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Cnpj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.RazaoSocial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 32 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Ramo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Porte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 34 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!--Exibir somente a data-->     \n            <td>");
#nullable restore
#line 35 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 36 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
           Write(item.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <!--Envia o código da padaria pela URL-->\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e17c66610be5ff11adae2a15de368dd2baaedb010182", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
                     WriteLiteral(item.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <!-- Button trigger modal -->\n                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1177, "\"", 1225, 3);
            WriteAttributeValue("", 1187, "idEstabelecimento.value", 1187, 23, true);
            WriteAttributeValue(" ", 1210, "=", 1211, 2, true);
#nullable restore
#line 41 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
WriteAttributeValue(" ", 1212, item.Codigo, 1213, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-sm btn-danger\" data-toggle=\"modal\" data-target=\"#exampleModal\">\n                    Remover\n                </button>\n            </td>\n        </tr>\n");
#nullable restore
#line 46 "C:\Users\allan\OneDrive\Área de Trabalho\WebApplicationForChallenge\WebApplicationForChallenge\Views\Estabelecimento\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Deseja realmente apagar o cadastro?
            </div>
            <div class=""modal-footer"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e17c66610be5ff11adae2a15de368dd2baaedb014251", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""idEstabelecimento""/>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                    <button type=""submit"" class=""btn btn-danger"">Sim</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Estabelecimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591