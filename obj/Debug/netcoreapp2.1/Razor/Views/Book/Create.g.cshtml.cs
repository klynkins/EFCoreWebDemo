#pragma checksum "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e77c90b6585524f4864df26d5f7cd825c4eb9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Create), @"mvc.1.0.view", @"/Views/Book/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Create.cshtml", typeof(AspNetCore.Views_Book_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e77c90b6585524f4864df26d5f7cd825c4eb9a", @"/Views/Book/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56e3cb575225e75b359599a007749e2d400f4bd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
  
    ViewBag.Title = "New Book";

#line default
#line hidden
            BeginContext(49, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(55, 13, false);
#line 6 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(68, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 8 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
            BeginContext(101, 31, true);
            WriteLiteral("  <div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(133, 38, false);
#line 10 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
Write(Html.LabelFor(model => model.AuthorId));

#line default
#line hidden
            EndContext();
            BeginContext(171, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(177, 135, false);
#line 11 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
Write(Html.DropDownListFor(model => model.AuthorId, (IEnumerable<SelectListItem>)ViewBag.Authors, string.Empty, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(312, 42, true);
            WriteLiteral(" \n  </div>\n  <div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(355, 35, false);
#line 14 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(390, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(396, 67, false);
#line 15 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
Write(Html.TextBoxFor(model => model.Title, new { @class="form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(463, 75, true);
            WriteLiteral(" \n  </div>\n  <button type=\"submit\" class=\"btn btn-default\">Submit</button>\n");
            EndContext();
#line 18 "/Users/katelynncampbell/Documents/EFCoreWebDemo/Views/Book/Create.cshtml"
}

#line default
#line hidden
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
