#pragma checksum "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7781e8f5fe5ecc7968c85d43484312d015a5ca62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\_ViewImports.cshtml"
using Hamburgueria;

#line default
#line hidden
#line 2 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\_ViewImports.cshtml"
using Hamburgueria.Models;

#line default
#line hidden
#line 3 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7781e8f5fe5ecc7968c85d43484312d015a5ca62", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d31b7c71e805b0c51c2ec24ce81a437aad20412", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hamburgueria.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - McBonald's";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(153, 97, true);
            WriteLiteral("<header>\r\n    <hgroup>\r\n        <h1>McBonald\'s</h1>\r\n    </hgroup>\r\n</header>\r\n\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(251, 14, false);
#line 13 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 270, true);
            WriteLiteral(@"</h2>
    <h3>Seu histórico:</h3>
    <table>
        <thead>
            <tr>
                <th>Data</th>
                <th>Hamburguer</th>
                <th>Shake</th>
                <th>Preço</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 25 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(590, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(637, 19, false);
#line 27 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(656, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(688, 22, false);
#line 28 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
                   Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(710, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(742, 17, false);
#line 29 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
                   Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(759, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(791, 17, false);
#line 30 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
                   Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(808, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 32 "C:\Users\alexandre.fukaya\OneDrive\Documents\Consultoria\Senai\Tecnico Desenvolvimento de Sistemas - Sem1\SourceCode\Hamburgueria\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(853, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hamburgueria.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
