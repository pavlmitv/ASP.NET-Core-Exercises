#pragma checksum "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\Cats\_Cat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44339fe7d5fc19a873b7c0ed2985607ea1d0dd9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cats__Cat), @"mvc.1.0.view", @"/Views/Cats/_Cat.cshtml")]
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
#line 1 "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44339fe7d5fc19a873b7c0ed2985607ea1d0dd9d", @"/Views/Cats/_Cat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b1f20c416716b317e9b0d7a679cc3b7f9d30ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Cats__Cat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 4 "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\Cats\_Cat.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 4 "C:\Users\Pavel\source\repos\C#_WebBasics_&_ASP.NETCore\ASP.NET Core Exercises\ASP.NET-Core-Exercises\ASP_Introduction_and_Razor_Views\WebApplication1\WebApplication1\Views\Cats\_Cat.cshtml"
             Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div> partial view - That\'s a CAT! </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
