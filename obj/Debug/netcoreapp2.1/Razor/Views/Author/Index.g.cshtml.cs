#pragma checksum "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dee02fb27f1384c07171fda301aa4c3a0908180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Index.cshtml", typeof(AspNetCore.Views_Author_Index))]
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
#line 1 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/_ViewImports.cshtml"
using EFCoreWebDemo;

#line default
#line hidden
#line 2 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/_ViewImports.cshtml"
using EFCoreWebDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dee02fb27f1384c07171fda301aa4c3a0908180", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e3cb575225e75b359599a007749e2d400f4bd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
  
    ViewBag.Title = "Authors";

#line default
#line hidden
            BeginContext(63, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(68, 13, false);
#line 5 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(81, 11, true);
            WriteLiteral("</h1>\n<ul>\n");
            EndContext();
#line 7 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
 foreach (var author in Model)
{

#line default
#line hidden
            BeginContext(125, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(134, 16, false);
#line 9 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
   Write(author.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(150, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(152, 15, false);
#line 9 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
                     Write(author.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(167, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 10 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
}

#line default
#line hidden
            BeginContext(175, 12, true);
            WriteLiteral("</ul>\n\n<div>");
            EndContext();
            BeginContext(188, 32, false);
#line 13 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Author/Index.cshtml"
Write(Html.ActionLink("New", "create"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
