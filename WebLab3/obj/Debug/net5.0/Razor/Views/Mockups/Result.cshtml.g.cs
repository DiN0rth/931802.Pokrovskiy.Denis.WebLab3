#pragma checksum "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db0d4b11b39966644c89ad0c512825ff57839e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_Result), @"mvc.1.0.view", @"/Views/Mockups/Result.cshtml")]
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
#line 1 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\_ViewImports.cshtml"
using WebLab3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\_ViewImports.cshtml"
using WebLab3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db0d4b11b39966644c89ad0c512825ff57839e4", @"/Views/Mockups/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb8620a93480e3dfd9cf553cdec5da7a481a079", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
   ViewData["Title"] = "Quiz"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Quiz results</h1>\r\n<div>\r\n    <h2>Right Answers ");
#nullable restore
#line 5 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
                 Write(ViewData["Correct"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out ");
#nullable restore
#line 5 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
                                          Write(ViewData["Total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <ol>\r\n");
#nullable restore
#line 7 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
         foreach (var res in (ViewBag.Result))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li> ");
#nullable restore
#line 9 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
            Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n");
#nullable restore
#line 10 "C:\Users\1\Source\Repos\WebLab3\WebLab3\Views\Mockups\Result.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n</div>");
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
