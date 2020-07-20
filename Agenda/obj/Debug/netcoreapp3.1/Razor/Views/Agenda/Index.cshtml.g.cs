#pragma checksum "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346fcb50f25eb05c91e147c311fa5de19b9a4e53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agenda_Index), @"mvc.1.0.view", @"/Views/Agenda/Index.cshtml")]
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
#line 1 "C:\Desafio\Desafio\Agenda\Agenda\Views\_ViewImports.cshtml"
using Agenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Desafio\Desafio\Agenda\Agenda\Views\_ViewImports.cshtml"
using Agenda.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"346fcb50f25eb05c91e147c311fa5de19b9a4e53", @"/Views/Agenda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d36845afd86d39266a46b24ffb4cec0212e7cd5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Agenda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Agenda.Models.Entidades.Agendas>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 41 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
                     if (item.tipo == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>Exclusivo</h4>\r\n");
#nullable restore
#line 44 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
                    }
                    else if (item.tipo == "2")
                    { 


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>Compartilhado</h4>\r\n");
#nullable restore
#line 49 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 53 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.ActionLink("Detalhes", "Detalhes", new { id = item.Id  /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 54 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id/* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Desafio\Desafio\Agenda\Agenda\Views\Agenda\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Agenda.Models.Entidades.Agendas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
