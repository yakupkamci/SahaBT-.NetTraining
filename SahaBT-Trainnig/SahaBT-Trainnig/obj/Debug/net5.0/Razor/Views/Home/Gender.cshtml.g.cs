#pragma checksum "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6429d665fbe3c2f88756bd494cbe8f7b2a442f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SahaBT_Trainnig.Pages.Home.Views_Home_Gender), @"mvc.1.0.view", @"/Views/Home/Gender.cshtml")]
namespace SahaBT_Trainnig.Pages.Home
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
#line 1 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\_ViewImports.cshtml"
using SahaBT_Trainnig.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6429d665fbe3c2f88756bd494cbe8f7b2a442f97", @"/Views/Home/Gender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f877d11706beda47dbb8fe3d37444202f95c9b32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Gender : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Persons>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
  
    ViewData["Title"] = "Gender";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Gender</h2>

<table>
    <thead>
        <tr>
            <td width=""100px""><b>id</b></td>
            <td width=""120px""><b>FirstName</b></td>
            <td width=""120px""><b>LastName</b></td>
            <td width=""120px""><b>Email</b></td>
            <td width=""120px""><b>Gender</b></td>
            <td width=""120px""><b>Country</b></td>
        </tr>
        <tr></tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
               Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "E:\deneme\SahaBT-Trainnig\SahaBT-Trainnig\Views\Home\Gender.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Persons>> Html { get; private set; }
    }
}
#pragma warning restore 1591
