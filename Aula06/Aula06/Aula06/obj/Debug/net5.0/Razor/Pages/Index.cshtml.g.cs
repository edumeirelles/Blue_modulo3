#pragma checksum "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8150a7f0caca61405db7defa85223af590c5e448"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Aula06.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Aula06.Pages
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
#line 1 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\_ViewImports.cshtml"
using Aula06;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8150a7f0caca61405db7defa85223af590c5e448", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bf96f4218e8484d2f3d66c316470d98f0c80c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n    <p>");
#nullable restore
#line 11 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml"
  Write(Model.NomeDaPagina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 15 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml"
 foreach (string produto in Model.ListaDeProdutos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"exemplo1\">\r\n    ");
#nullable restore
#line 18 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml"
Write(produto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>  \r\n");
#nullable restore
#line 21 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
