#pragma checksum "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/Shared/_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef09c2e68c276c7e16ecd355491a03da160c7cfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
#line 2 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/_ViewImports.cshtml"
using webUi.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/_ViewImports.cshtml"
using webUi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef09c2e68c276c7e16ecd355491a03da160c7cfa", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb34432093ec2d544d7246faf1b77ec92393a9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row mb-4\" style=\"justify-content: center;\">\n    <div class=\"container col-md-10\">\n        <div class=\"alert\"");
            BeginWriteAttribute("style", " style=\"", 140, "\"", 183, 3);
            WriteAttributeValue("", 148, "background-color:", 148, 17, true);
#nullable restore
#line 4 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/Shared/_ResultMessage.cshtml"
WriteAttributeValue(" ", 165, Model.AlertType, 166, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 182, ";", 182, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <h4 class=\"alert-title text-center\" style=\"color:white;\">");
#nullable restore
#line 5 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/Shared/_ResultMessage.cshtml"
                                                                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <p class=\"text-center\" style=\"color:white;\">");
#nullable restore
#line 6 "/Users/emre/Documents/Projelerim/yayinlanan/Tor Services/webUi/Views/Shared/_ResultMessage.cshtml"
                                                   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
