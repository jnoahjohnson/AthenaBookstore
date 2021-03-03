#pragma checksum "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08fe69607c2a4ab66d6e716b4cc2e059a0a3386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\_ViewImports.cshtml"
using AthenaBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\_ViewImports.cshtml"
using AthenaBookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\_ViewImports.cshtml"
using AthenaBookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08fe69607c2a4ab66d6e716b4cc2e059a0a3386", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7990a560327b2a89edf150c5a09747c29770ed89", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"card mb-4\">\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h4 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 12 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                                              Write(Model.AuthorFirstName + (Model.AuthorMiddleName == "" ? " " : $" {Model.AuthorMiddleName} ") + Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h5 class=\"mb-3\">$");
#nullable restore
#line 13 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6>Details</h6>\r\n        <p class=\"mb-1\">Published by ");
#nullable restore
#line 15 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                                Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"mb-1\">Classification: ");
#nullable restore
#line 16 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                                   Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"mb-1\">Category: ");
#nullable restore
#line 17 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                             Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"mb-0\">ISBN: ");
#nullable restore
#line 18 "C:\Users\noahjohnson\source\repos\AthenaBookstore\AthenaBookstore\Views\Shared\BookSummary.cshtml"
                         Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
