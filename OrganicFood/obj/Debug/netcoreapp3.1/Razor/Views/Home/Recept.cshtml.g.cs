#pragma checksum "D:\GitHub\OrganicFood\OrganicFood\Views\Home\Recept.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e307257a49e613e73477cf02886c7cf5e5ad3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Recept), @"mvc.1.0.view", @"/Views/Home/Recept.cshtml")]
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
#line 1 "D:\GitHub\OrganicFood\OrganicFood\Views\_ViewImports.cshtml"
using OrganicFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\OrganicFood\OrganicFood\Views\_ViewImports.cshtml"
using OrganicFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e307257a49e613e73477cf02886c7cf5e5ad3e", @"/Views/Home/Recept.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b282fe8390c02456887675b89f9c18dc2e3828", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Recept : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\OrganicFood\OrganicFood\Views\Home\Recept.cshtml"
  
    ViewData["Title"] = "Рецепты";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\GitHub\OrganicFood\OrganicFood\Views\Home\Recept.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Рецепты из домашних продуктов</p>\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\'", 177, "\'", 218, 1);
#nullable restore
#line 11 "D:\GitHub\OrganicFood\OrganicFood\Views\Home\Recept.cshtml"
WriteAttributeValue("", 183, Url.Content("~/Pictures/logo.png"), 183, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
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