#pragma checksum "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fefa531b3f982040c9f84e92905e3f99bbcbe30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(myWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace myWebApp.Pages
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
#line 1 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\_ViewImports.cshtml"
using myWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fefa531b3f982040c9f84e92905e3f99bbcbe30", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721989a388ce7a3f056d1e9ef37c2e43a92d4382", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to Assigment 07</h1>\r\n    <p>Here is where the banking magic happens.</p>\r\n</div>\r\n<table class=\"table\">\r\n    <tr>\r\n");
#nullable restore
#line 13 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
         foreach(var property in Model.Accounts.First().GetType().GetProperties())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>");
#nullable restore
#line 15 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
           Write(property.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 16 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    \r\n");
#nullable restore
#line 19 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
     foreach (var account in Model.Accounts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
           Write(account.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
           Write(account.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
           Write(account.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
           Write(account.Owner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\youse\Desktop\HKr\Webbutveckling\websoft\work\s07\webapp\myWebApp\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
