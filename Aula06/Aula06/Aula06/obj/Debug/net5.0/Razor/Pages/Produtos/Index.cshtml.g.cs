#pragma checksum "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee20050d5fb7ed645a6776be1030147e709b2033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Aula06.Pages.Produtos.Pages_Produtos_Index), @"mvc.1.0.razor-page", @"/Pages/Produtos/Index.cshtml")]
namespace Aula06.Pages.Produtos
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
#nullable restore
#line 3 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
using Aula06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee20050d5fb7ed645a6776be1030147e709b2033", @"/Pages/Produtos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bf96f4218e8484d2f3d66c316470d98f0c80c7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Produtos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>Esta é a Página inical dos produtos</p>\r\n\r\n");
#nullable restore
#line 9 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
 foreach (Product prod in Model.produtos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"produtos\">\r\n    ");
#nullable restore
#line 12 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
Write(prod.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 13 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
Write(prod.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    ");
#nullable restore
#line 14 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
Write(prod.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n");
#nullable restore
#line 16 "D:\OneDrive\Blue\Repositórios\Blue_modulo3\Aula06\Aula06\Aula06\Pages\Produtos\Index.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aula06.Pages.Produtos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Aula06.Pages.Produtos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Aula06.Pages.Produtos.IndexModel>)PageContext?.ViewData;
        public Aula06.Pages.Produtos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
