#pragma checksum "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\Exchanges\ExchangesAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80faba79407b60cb402b3564608846466075958a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exchanges_ExchangesAdded), @"mvc.1.0.view", @"/Views/Exchanges/ExchangesAdded.cshtml")]
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
#line 1 "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80faba79407b60cb402b3564608846466075958a", @"/Views/Exchanges/ExchangesAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f0e01d906794e7d20db596d96f08e9d5ca555d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exchanges_ExchangesAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExchangeThings.Web.Models.ExchangesAddViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Your Exchange was successfully added!</h1>\r\n\r\n<h5>Some stats:</h5>\r\n\r\n<div>Chars in Name: ");
#nullable restore
#line 7 "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\Exchanges\ExchangesAdded.cshtml"
               Write(Model.NumberOfCharsInName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Chars in Description: ");
#nullable restore
#line 8 "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\Exchanges\ExchangesAdded.cshtml"
                      Write(Model.NumberOfCharsInDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Is the Company currently hidden: ");
#nullable restore
#line 9 "H:\Github\NewBrandingStyle\ASP.NET-Project\NewBrandingStyle.Web\Views\Exchanges\ExchangesAdded.cshtml"
                                  Write(Model.IsHidden ? "yes" : "no");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExchangeThings.Web.Models.ExchangesAddViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
