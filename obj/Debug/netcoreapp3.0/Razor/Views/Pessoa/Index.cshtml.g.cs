#pragma checksum "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03019a196ee282b71ac4d56366ef7392c3d76884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
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
#line 1 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\_ViewImports.cshtml"
using Cadastro_de_Pessoas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\_ViewImports.cshtml"
using Cadastro_de_Pessoas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03019a196ee282b71ac4d56366ef7392c3d76884", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2ecb455e20b1a1894f6f39158b4c7de5e0f24d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Cadastro de Pessoas</h1>
<table class=""table table-bordered table-striped"">
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Endereço</th>
        <th>Telefone</th>
        <th>Email</th>
        <th>Editar</th>
        <th>Excluir</th>
    </tr>
");
#nullable restore
#line 17 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
     for (int i = 0; i < Model.Rows.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
           Write(Model.Rows[i][0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
           Write(Model.Rows[i][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
           Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
           Write(Model.Rows[i][3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
           Write(Model.Rows[i][4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a class=\"btn btn-outline-primary\"");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 735, 1);
#nullable restore
#line 25 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 676, Url.Action("Edit", "Pessoa", new { @id=@Model.Rows[i][0]}), 676, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n            <td><a class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 871, 1);
#nullable restore
#line 26 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 810, Url.Action("Delete", "Pessoa", new { @id=@Model.Rows[i][0]}), 810, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 991, 1);
#nullable restore
#line 32 "C:\Users\anacarolinemoraes\Documents\GitHub\Projeto_Cliente\Cadastro de Pessoas\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 960, Url.Action("Create", "Pessoa"), 960, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cadastrar</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591